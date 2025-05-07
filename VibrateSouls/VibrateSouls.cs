using MaterialSkin;
using MaterialSkin.Controls;
using VibrateSoulsCore;

namespace VibrateSouls
{
    public partial class VibrateSouls : MaterialForm
    {
        private readonly ButtPlugHelper BpHelper;

        public VibrateSouls()
        {
            InitializeComponent();

            BpHelper = new ButtPlugHelper("ws://127.0.0.1:12345/");

            SetTheme();
            InitializeBp();
        }

        private void SetTheme()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        #region BP Client

        private void InitializeBp()
        {
            BpHelper.ConnectionAttemptFinished += CheckConnectionChanged;
            BpHelper.DeviceListChanged += DeviceCountChanged;

            BpHelper.InitializeClient();
        }

        private void CheckConnectionChanged(object? sender, EventArgs e)
        {
            UpdateServerStatus();
            UpdateDeviceCount();
        }

        private void DeviceCountChanged(object? sender, EventArgs e)
        {
            UpdateDeviceCount();
        }

        private void IntifaceConnectButton_Click(object sender, EventArgs e)
        {
            ConnectionStatus_Label.Text = "Connecting to server...";
            BpHelper.InitializeClient();
        }

        private void VibrateButton_Click(object sender, EventArgs e)
        {
            BpHelper.VibrateAll();
        }

        private void UpdateDeviceCount()
        {
            int deviceCount = BpHelper.BpClient.Connected ? BpHelper.BpClient.Devices.Length : 0;
            string text = string.Format("Devices: {0}", deviceCount);
            bool vibrateEnabled = deviceCount > 0;

            WriteTextSafe(DeviceCount_Label, text);
            SetEnabledSafe(VibrateAll_Button, vibrateEnabled);
        }

        private void UpdateServerStatus()
        {
            string text = BpHelper.BpClient.Connected ? "Connected to server." : "Could not connect to server";
            WriteTextSafe(ConnectionStatus_Label, text);
            SetEnabledSafe(IntifaceConnect_Button, !BpHelper.BpClient.Connected);
        }

        #endregion

        #region Elden Ring

        

        #endregion

        #region Misc

        private void WriteTextSafe(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                void safeWrite() { WriteTextSafe(control, text); }
                control.Invoke(safeWrite);
            }
            else
            {
                control.Text = text;
            }
        }

        private void SetEnabledSafe(Control control, bool enabled)
        {
            if (control.InvokeRequired)
            {
                void safeWrite() { SetEnabledSafe(control, enabled); }
                control.Invoke(safeWrite);
            }
            else
            {
                control.Enabled = enabled;
            }
        }

        #endregion
    }
}
