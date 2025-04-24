using Buttplug;
using Buttplug.SystemTextJson;

namespace VibrateGames
{
    public partial class VibrateGames : Form
    {
        private ButtplugClient? bpClient;
        private readonly EldenRingDataHelper eldenRingDataHelper;

        private static readonly int pollingRate = 10;
        private static readonly CancellationToken cancellationToken = CancellationToken.None;

        public VibrateGames()
        {
            InitializeComponent();
            InitializeClient();

            eldenRingDataHelper = new EldenRingDataHelper();
            DetectEldenRing();
        }

        private async void InitializeClient()
        {
            try
            {
                var converter = new ButtplugSystemTextJsonConverter();
                bpClient = new("Buttplug.Net", converter);
                await bpClient.ConnectAsync(new Uri("ws://127.0.0.1:12345/"), cancellationToken);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not connect");
            }
            DetectDevices();
        }

        private async void DetectDevices()
        {
            NumDevicesLabel.Text = "Scanning...";
            if (bpClient == null || bpClient.Devices.Count == 0)
            {
                SetNumDeviceText();
                return;
            }
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
                NumDevicesLabel.Text = bpClient.Devices.Count.ToString() + " Devices found.";
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

        private void VibrateButton_Clicked(object sender, EventArgs e)
        {
            VibrateAll();
        }

        private void RescanButton_Click(object sender, EventArgs e)
        {
            DetectDevices();
        }


        private void DetectEldenRing()
        {
            if (eldenRingDataHelper.FindEldenRingProcess())
            {
                DetectEldenRingLabel.Text = "Elden Ring detected";
                CheckHp();
            }
            else
            {
                DetectEldenRingLabel.Text = "Elden Ring not found";
            }
        }

        private async void CheckHp()
        {
            while (true)
            {
                if (eldenRingDataHelper == null)
                {
                    return;
                }
                int hp = eldenRingDataHelper.GetHP();
                HealthPointsLabel.Text = "HP: " + hp;
                await Task.Delay(pollingRate);
            }
        }

        private void DetectEldenRing_Click(object sender, EventArgs e)
        {
            DetectEldenRing();
        }
    }
}
