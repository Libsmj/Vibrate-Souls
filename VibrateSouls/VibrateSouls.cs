using Buttplug.Client;
using MaterialSkin;
using MaterialSkin.Controls;

namespace VibrateSouls
{
    public partial class VibrateSouls : MaterialForm
    {
        private ButtplugClient? bpClient;
        //private DarkSouls2DataHelper? darkSouls2DataHelper;
        private EldenRingDataHelper? eldenRingDataHelper;

        private static readonly int pollingRate = 10;
        private static readonly CancellationToken cancellationToken = CancellationToken.None;

        private string serverAddress = "ws://127.0.0.1:12345/";

        public VibrateSouls()
        {
            InitializeComponent();

            SetTheme();

            InitializeClient();
            DetectEldenRing();
        }

        private void SetTheme()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        #region Event Handlers

        private void IntifaceConnectButton_Click(object sender, EventArgs e)
        {
            InitializeClient();
        }

        private void RescanButton_Click(object sender, EventArgs e)
        {
            DetectDevices();
        }

        private void VibrateButton_Clicked(object sender, EventArgs e)
        {
            VibrateAll();
        }

        private void DetectEldenRing_Click(object sender, EventArgs e)
        {
            DetectEldenRing();
        }

        #endregion

        #region Buttplug Stuff

        private async void InitializeClient()
        {
            IntifaceConnectButton.Enabled = false;
            RescanButton.Enabled = false;
            VibrateButton.Enabled = false;
            DeviceStatusLabel.Text = "Connecting to server...";

            if (bpClient != null)
            {
                // Disconnect from current connection
                await bpClient.DisconnectAsync();
            }

            try
            {
                bpClient = new("Vibrate Souls");
                ButtplugWebsocketConnector connector = new(new Uri(serverAddress));
                await bpClient.ConnectAsync(connector);
                DetectDevices();
            }
            catch (Exception)
            {
                DeviceStatusLabel.Text = "Could not connect to server";
            }
            IntifaceConnectButton.Enabled = true;
        }

        private async void DetectDevices()
        {
            RescanButton.Enabled = false;
            VibrateButton.Enabled = false;

            if (bpClient == null)
            {
                DeviceStatusLabel.Text = "Could not connect to server";
                return;
            }
            DeviceStatusLabel.Text = "Scanning...";
            try
            {
                await bpClient.StartScanningAsync(cancellationToken);
                await Task.Delay(100);
                await bpClient.StopScanningAsync(cancellationToken);
                RescanButton.Enabled = true;
                SetNumDeviceText();
            }
            catch
            {
                DeviceStatusLabel.Text = "Disconnected, reconnecting...";
                InitializeClient();
            }
        }

        private void SetNumDeviceText()
        {
            if (bpClient == null)
            {
                return;
            }
            int numDevices = bpClient.Devices.Length;
            if (numDevices == 0)
            {
                VibrateButton.Enabled = false;
                DeviceStatusLabel.Text = "No devices found";
            }
            else
            {
                VibrateButton.Enabled = true;
                DeviceStatusLabel.Text = numDevices > 1 ? numDevices.ToString() + " devices found" : "1 device found";
            }
        }

        public async void VibrateAll()
        {
            if (bpClient == null || bpClient.Devices.Length == 0)
            {
                return;
            }
            try
            {
                foreach (ButtplugClientDevice? device in bpClient.Devices)
                {
                    await device.VibrateAsync(1);
                }

                await Task.Delay(1000);
                await bpClient.StopAllDevicesAsync(cancellationToken);
            }
            catch (Exception) { }
        }

        #endregion

        #region Elden Ring

        private void DetectEldenRing()
        {
            //MemoryHelper.ProcessInfo? darksouls2 = MemoryHelper.FindProcess("darksoulsii", "DarkSoulsII.exe");
            MemoryHelper.ProcessInfo? eldenRing = MemoryHelper.FindProcess("eldenring", "eldenring.exe");
            if (eldenRing == null)
            {
                eldenRingDataHelper = null;
                DetectEldenRingButton.Enabled = true;
                DetectEldenRingLabel.Text = "Elden Ring not found";
                return;
            }
            eldenRingDataHelper = new EldenRingDataHelper(eldenRing);
            DetectEldenRingButton.Enabled = true;
            DetectEldenRingLabel.Text = "Elden Ring detected";
            ScanPlayerParams();
        }

        private async void ScanPlayerParams()
        {
            if (eldenRingDataHelper == null)
            {
                return;
            }
            eldenRingDataHelper.PlayerParams.UpdateStats();
            int previousHp = eldenRingDataHelper.PlayerParams.Hp;
            string previousName = eldenRingDataHelper.PlayerParams.PlayerName;

            while (true)
            {
                eldenRingDataHelper.PlayerParams.UpdateStats();

                int hp = eldenRingDataHelper.PlayerParams.Hp;
                string name = eldenRingDataHelper.PlayerParams.PlayerName;
                if (hp < previousHp && name == previousName)
                {
                    VibrateAll();
                }
                previousHp = hp;
                previousName = name;

                HealthPointsLabel.Text = "HP: " + (name != "" ? hp : "");
                await Task.Delay(pollingRate);
            }
        }

        #endregion
    }
}
