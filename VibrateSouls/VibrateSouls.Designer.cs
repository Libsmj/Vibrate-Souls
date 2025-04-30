namespace VibrateSouls
{
    partial class VibrateSouls
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(VibrateSouls));
            VibrateButton = new MaterialSkin.Controls.MaterialButton();
            RescanButton = new MaterialSkin.Controls.MaterialButton();
            DeviceStatusLabel = new Label();
            IntifaceConnectButton = new MaterialSkin.Controls.MaterialButton();
            materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            VibrateSoulsTabControl = new MaterialSkin.Controls.MaterialTabControl();
            TabPage_Home = new TabPage();
            TabPage_EldenRing = new TabPage();
            HealthPointsLabel = new Label();
            DetectEldenRingButton = new MaterialSkin.Controls.MaterialButton();
            DetectEldenRingLabel = new Label();
            MenuTabIcons = new ImageList(components);
            VibrateSoulsTabControl.SuspendLayout();
            TabPage_Home.SuspendLayout();
            TabPage_EldenRing.SuspendLayout();
            SuspendLayout();
            // 
            // VibrateButton
            // 
            VibrateButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            VibrateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            VibrateButton.Depth = 0;
            VibrateButton.Enabled = false;
            VibrateButton.Font = new Font("Microsoft Sans Serif", 12F);
            VibrateButton.HighEmphasis = true;
            VibrateButton.Icon = null;
            VibrateButton.Location = new Point(81, 155);
            VibrateButton.Margin = new Padding(3, 9, 3, 3);
            VibrateButton.MouseState = MaterialSkin.MouseState.HOVER;
            VibrateButton.Name = "VibrateButton";
            VibrateButton.NoAccentTextColor = Color.Empty;
            VibrateButton.Size = new Size(110, 36);
            VibrateButton.TabIndex = 0;
            VibrateButton.Text = "Vibrate All";
            VibrateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            VibrateButton.UseAccentColor = false;
            VibrateButton.UseVisualStyleBackColor = true;
            VibrateButton.Click += VibrateButton_Clicked;
            // 
            // RescanButton
            // 
            RescanButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RescanButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            RescanButton.Depth = 0;
            RescanButton.Enabled = false;
            RescanButton.Font = new Font("Microsoft Sans Serif", 12F);
            RescanButton.HighEmphasis = true;
            RescanButton.Icon = null;
            RescanButton.Location = new Point(197, 78);
            RescanButton.Margin = new Padding(3, 9, 3, 3);
            RescanButton.MouseState = MaterialSkin.MouseState.HOVER;
            RescanButton.Name = "RescanButton";
            RescanButton.NoAccentTextColor = Color.Empty;
            RescanButton.Size = new Size(78, 36);
            RescanButton.TabIndex = 1;
            RescanButton.Text = "Rescan";
            RescanButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            RescanButton.UseAccentColor = false;
            RescanButton.UseVisualStyleBackColor = true;
            RescanButton.Click += RescanButton_Click;
            // 
            // DeviceStatusLabel
            // 
            DeviceStatusLabel.AutoSize = true;
            DeviceStatusLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DeviceStatusLabel.Location = new Point(81, 126);
            DeviceStatusLabel.Margin = new Padding(3, 9, 3, 0);
            DeviceStatusLabel.Name = "DeviceStatusLabel";
            DeviceStatusLabel.Size = new Size(167, 20);
            DeviceStatusLabel.TabIndex = 2;
            DeviceStatusLabel.Text = "Connecting to server...";
            // 
            // IntifaceConnectButton
            // 
            IntifaceConnectButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IntifaceConnectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            IntifaceConnectButton.Depth = 0;
            IntifaceConnectButton.Enabled = false;
            IntifaceConnectButton.Font = new Font("Microsoft Sans Serif", 12F);
            IntifaceConnectButton.HighEmphasis = true;
            IntifaceConnectButton.Icon = null;
            IntifaceConnectButton.Location = new Point(81, 78);
            IntifaceConnectButton.Margin = new Padding(3, 9, 6, 3);
            IntifaceConnectButton.MouseState = MaterialSkin.MouseState.HOVER;
            IntifaceConnectButton.Name = "IntifaceConnectButton";
            IntifaceConnectButton.NoAccentTextColor = Color.Empty;
            IntifaceConnectButton.Size = new Size(107, 36);
            IntifaceConnectButton.TabIndex = 7;
            IntifaceConnectButton.Text = "Reconnect";
            IntifaceConnectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            IntifaceConnectButton.UseAccentColor = false;
            IntifaceConnectButton.UseVisualStyleBackColor = true;
            IntifaceConnectButton.Click += IntifaceConnectButton_Click;
            // 
            // materialCheckbox1
            // 
            materialCheckbox1.Depth = 0;
            materialCheckbox1.Location = new Point(0, 0);
            materialCheckbox1.Margin = new Padding(0);
            materialCheckbox1.MouseLocation = new Point(-1, -1);
            materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox1.Name = "materialCheckbox1";
            materialCheckbox1.ReadOnly = false;
            materialCheckbox1.Ripple = true;
            materialCheckbox1.Size = new Size(104, 37);
            materialCheckbox1.TabIndex = 0;
            // 
            // materialCheckbox2
            // 
            materialCheckbox2.Depth = 0;
            materialCheckbox2.Location = new Point(0, 0);
            materialCheckbox2.Margin = new Padding(0);
            materialCheckbox2.MouseLocation = new Point(-1, -1);
            materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckbox2.Name = "materialCheckbox2";
            materialCheckbox2.ReadOnly = false;
            materialCheckbox2.Ripple = true;
            materialCheckbox2.Size = new Size(104, 37);
            materialCheckbox2.TabIndex = 0;
            // 
            // VibrateSoulsTabControl
            // 
            VibrateSoulsTabControl.Controls.Add(TabPage_Home);
            VibrateSoulsTabControl.Controls.Add(TabPage_EldenRing);
            VibrateSoulsTabControl.Depth = 0;
            VibrateSoulsTabControl.Dock = DockStyle.Fill;
            VibrateSoulsTabControl.ImageList = MenuTabIcons;
            VibrateSoulsTabControl.Location = new Point(3, 64);
            VibrateSoulsTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            VibrateSoulsTabControl.Multiline = true;
            VibrateSoulsTabControl.Name = "VibrateSoulsTabControl";
            VibrateSoulsTabControl.SelectedIndex = 0;
            VibrateSoulsTabControl.Size = new Size(824, 588);
            VibrateSoulsTabControl.TabIndex = 8;
            // 
            // TabPage_Home
            // 
            TabPage_Home.Controls.Add(IntifaceConnectButton);
            TabPage_Home.Controls.Add(VibrateButton);
            TabPage_Home.Controls.Add(RescanButton);
            TabPage_Home.Controls.Add(DeviceStatusLabel);
            TabPage_Home.ImageKey = "sync-512.png";
            TabPage_Home.Location = new Point(4, 39);
            TabPage_Home.Name = "TabPage_Home";
            TabPage_Home.Padding = new Padding(3);
            TabPage_Home.Size = new Size(816, 545);
            TabPage_Home.TabIndex = 0;
            TabPage_Home.Text = "Home";
            TabPage_Home.UseVisualStyleBackColor = true;
            // 
            // TabPage_EldenRing
            // 
            TabPage_EldenRing.BackColor = Color.Transparent;
            TabPage_EldenRing.Controls.Add(HealthPointsLabel);
            TabPage_EldenRing.Controls.Add(DetectEldenRingButton);
            TabPage_EldenRing.Controls.Add(DetectEldenRingLabel);
            TabPage_EldenRing.ImageKey = "EldenRing.png";
            TabPage_EldenRing.Location = new Point(4, 39);
            TabPage_EldenRing.Name = "TabPage_EldenRing";
            TabPage_EldenRing.Padding = new Padding(3);
            TabPage_EldenRing.Size = new Size(816, 545);
            TabPage_EldenRing.TabIndex = 1;
            TabPage_EldenRing.Text = "Elden Ring";
            TabPage_EldenRing.ToolTipText = "Elden Ring Settings";
            // 
            // HealthPointsLabel
            // 
            HealthPointsLabel.AutoSize = true;
            HealthPointsLabel.Font = new Font("Microsoft Sans Serif", 12F);
            HealthPointsLabel.Location = new Point(6, 74);
            HealthPointsLabel.Margin = new Padding(3, 3, 9, 0);
            HealthPointsLabel.Name = "HealthPointsLabel";
            HealthPointsLabel.Size = new Size(34, 20);
            HealthPointsLabel.TabIndex = 9;
            HealthPointsLabel.Text = "Hp:";
            // 
            // DetectEldenRingButton
            // 
            DetectEldenRingButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DetectEldenRingButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DetectEldenRingButton.Depth = 0;
            DetectEldenRingButton.Enabled = false;
            DetectEldenRingButton.Font = new Font("Microsoft Sans Serif", 12F);
            DetectEldenRingButton.HighEmphasis = true;
            DetectEldenRingButton.Icon = null;
            DetectEldenRingButton.Location = new Point(6, 32);
            DetectEldenRingButton.Margin = new Padding(3, 9, 3, 3);
            DetectEldenRingButton.MouseState = MaterialSkin.MouseState.HOVER;
            DetectEldenRingButton.Name = "DetectEldenRingButton";
            DetectEldenRingButton.NoAccentTextColor = Color.Empty;
            DetectEldenRingButton.Size = new Size(162, 36);
            DetectEldenRingButton.TabIndex = 8;
            DetectEldenRingButton.Text = "Detect Elden Ring";
            DetectEldenRingButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DetectEldenRingButton.UseAccentColor = false;
            DetectEldenRingButton.UseVisualStyleBackColor = true;
            // 
            // DetectEldenRingLabel
            // 
            DetectEldenRingLabel.AutoSize = true;
            DetectEldenRingLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DetectEldenRingLabel.Location = new Point(6, 3);
            DetectEldenRingLabel.Name = "DetectEldenRingLabel";
            DetectEldenRingLabel.Size = new Size(172, 20);
            DetectEldenRingLabel.TabIndex = 7;
            DetectEldenRingLabel.Text = "Detecting Elden Ring...";
            // 
            // MenuTabIcons
            // 
            MenuTabIcons.ColorDepth = ColorDepth.Depth32Bit;
            MenuTabIcons.ImageStream = (ImageListStreamer)resources.GetObject("MenuTabIcons.ImageStream");
            MenuTabIcons.TransparentColor = Color.Transparent;
            MenuTabIcons.Images.SetKeyName(0, "EldenRing.png");
            MenuTabIcons.Images.SetKeyName(1, "sync-512.png");
            MenuTabIcons.Images.SetKeyName(2, "256x256.png");
            // 
            // VibrateSouls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 655);
            Controls.Add(VibrateSoulsTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = VibrateSoulsTabControl;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VibrateSouls";
            Text = "Vibrate Souls";
            VibrateSoulsTabControl.ResumeLayout(false);
            TabPage_Home.ResumeLayout(false);
            TabPage_Home.PerformLayout();
            TabPage_EldenRing.ResumeLayout(false);
            TabPage_EldenRing.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton VibrateButton;
        private MaterialSkin.Controls.MaterialButton RescanButton;
        private Label DeviceStatusLabel;
        private MaterialSkin.Controls.MaterialButton IntifaceConnectButton;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialTabControl VibrateSoulsTabControl;
        private TabPage TabPage_Home;
        private TabPage TabPage_EldenRing;
        private Label HealthPointsLabel;
        private MaterialSkin.Controls.MaterialButton DetectEldenRingButton;
        private Label DetectEldenRingLabel;
        private ImageList MenuTabIcons;
    }
}
