using Buttplug;
using Buttplug.SystemTextJson;

namespace VibrateGames
{
    public partial class VibrateGames : Form
    {
        private ButtplugClient? bpClient;
        private EldenRingDataHelper? eldenRingDataHelper;

        private static readonly int pollingRate = 10;
        private static readonly CancellationToken cancellationToken = CancellationToken.None;

        private string serverAddress = "ws://127.0.0.1:12345/";

        public VibrateGames()
        {
            InitializeComponent();
            InitializeClient();
            DetectEldenRing();
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

            if (bpClient != null)
            {
                await bpClient.DisconnectAsync();
            }
            try
            {
                var converter = new ButtplugSystemTextJsonConverter();
                bpClient = new("Vibrate Souls", converter);
                await bpClient.ConnectAsync(new Uri(serverAddress), cancellationToken);
                DetectDevices();
            }
            catch (Exception)
            {
                NumDevicesLabel.Text = "Could not connect to server";
                RescanButton.Enabled = false;
            }
            IntifaceConnectButton.Enabled = true;
        }

        private async void DetectDevices()
        {
            if (bpClient == null)
            {
                RescanButton.Enabled = false;
                NumDevicesLabel.Text = "Could not connect to server";
                return;
            }
            NumDevicesLabel.Text = "Scanning...";
            await bpClient.StartScanningAsync(cancellationToken);
            await Task.Delay(100);
            await bpClient.StopScanningAsync(cancellationToken);
            SetNumDeviceText();
        }

        private void SetNumDeviceText()
        {
            if (bpClient == null)
            {
                NumDevicesLabel.Text = "Scanning...";
            }
            else
            {
                int numDevices = bpClient.Devices.Count;
                if (numDevices == 0)
                {
                    VibrateButton.Enabled = false;
                    NumDevicesLabel.Text = "No devices found";
                }
                else 
                {
                    VibrateButton.Enabled = true;
                    if (numDevices == 1)
                    {
                        NumDevicesLabel.Text = "1 device found";
                    }
                    else
                    {
                        NumDevicesLabel.Text = numDevices.ToString() + " devices found";
                    }
                }
            }
        }

        public async void VibrateAll()
        {
            if (bpClient == null)
            {
                return;
            }
            foreach (var device in bpClient.Devices)
                await device.ScalarAsync(1, ActuatorType.Vibrate, cancellationToken);

            foreach (var actuator in bpClient.Devices.SelectMany(d => d.GetActuators<ButtplugDeviceScalarActuator>(ActuatorType.Vibrate)))
                await actuator.ScalarAsync(0.5, cancellationToken);

            await Task.Delay(1000);
            await bpClient.StopAllDevicesAsync(cancellationToken);
        }

        #endregion

        #region Elden Ring

        private void DetectEldenRing()
        {
            MemoryHelper.ProcessInfo? eldenRing = MemoryHelper.FindProcess("eldenring", "eldenring.exe");
            if (eldenRing == null)
            {
                DetectEldenRingButton.Enabled = true;
                DetectEldenRingLabel.Text = "Elden Ring not found";
                return;
            }
            eldenRingDataHelper = new EldenRingDataHelper(eldenRing);
            DetectEldenRingButton.Enabled = true;
            DetectEldenRingLabel.Text = "Elden Ring detected";
            CheckHp();
        }

        private async void CheckHp()
        {
            int previousHp = eldenRingDataHelper?.GetHP() ?? -1;
            while (true)
            {
                if (eldenRingDataHelper == null)
                {
                    return;
                }
                int hp = eldenRingDataHelper.GetHP();
                if (hp < previousHp)
                {
                    VibrateAll();
                }
                previousHp = hp;
                HealthPointsLabel.Text = "HP: " + hp;
                await Task.Delay(pollingRate);
            }
        }

        #endregion

    }
}
