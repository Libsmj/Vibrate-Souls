using MaterialSkin.Controls;

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
            VibrateAll_Button = new MaterialButton();
            ConnectionStatus_Label = new MaterialLabel();
            IntifaceConnect_Button = new MaterialButton();
            materialCheckbox1 = new MaterialCheckbox();
            materialCheckbox2 = new MaterialCheckbox();
            TabControl = new MaterialTabControl();
            TabPage_Home = new MaterialTabPage();
            DeviceCount_Label = new MaterialLabel();
            TabPage_EldenRing = new MaterialTabPage();
            HealthPointsLabel = new MaterialLabel();
            DetectEldenRingButton = new MaterialButton();
            DetectEldenRingLabel = new MaterialLabel();
            TabPage_DS1 = new MaterialTabPage();
            TabPage_DS1R = new MaterialTabPage();
            TabPage_DS2 = new MaterialTabPage();
            TabPage_DS3 = new MaterialTabPage();
            MenuTabIcons = new ImageList(components);
            TabControl.SuspendLayout();
            TabPage_Home.SuspendLayout();
            TabPage_EldenRing.SuspendLayout();
            SuspendLayout();
            // 
            // VibrateAll_Button
            // 
            VibrateAll_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            VibrateAll_Button.Density = MaterialButton.MaterialButtonDensity.Default;
            VibrateAll_Button.Depth = 0;
            VibrateAll_Button.Enabled = false;
            VibrateAll_Button.Font = new Font("Microsoft Sans Serif", 12F);
            VibrateAll_Button.HighEmphasis = true;
            VibrateAll_Button.Icon = null;
            VibrateAll_Button.Location = new Point(12, 141);
            VibrateAll_Button.Margin = new Padding(9);
            VibrateAll_Button.MouseState = MaterialSkin.MouseState.HOVER;
            VibrateAll_Button.Name = "VibrateAll_Button";
            VibrateAll_Button.NoAccentTextColor = Color.Empty;
            VibrateAll_Button.Size = new Size(110, 36);
            VibrateAll_Button.TabIndex = 3;
            VibrateAll_Button.Text = "Vibrate All";
            VibrateAll_Button.Type = MaterialButton.MaterialButtonType.Contained;
            VibrateAll_Button.UseAccentColor = false;
            VibrateAll_Button.UseVisualStyleBackColor = true;
            VibrateAll_Button.Click += VibrateButton_Click;
            // 
            // ConnectionStatus_Label
            // 
            ConnectionStatus_Label.AutoSize = true;
            ConnectionStatus_Label.Depth = 0;
            ConnectionStatus_Label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ConnectionStatus_Label.Location = new Point(12, 12);
            ConnectionStatus_Label.Margin = new Padding(9);
            ConnectionStatus_Label.MouseState = MaterialSkin.MouseState.HOVER;
            ConnectionStatus_Label.Name = "ConnectionStatus_Label";
            ConnectionStatus_Label.Size = new Size(157, 19);
            ConnectionStatus_Label.TabIndex = 2;
            ConnectionStatus_Label.Text = "Connecting to server...";
            // 
            // IntifaceConnect_Button
            // 
            IntifaceConnect_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            IntifaceConnect_Button.Density = MaterialButton.MaterialButtonDensity.Default;
            IntifaceConnect_Button.Depth = 0;
            IntifaceConnect_Button.Enabled = false;
            IntifaceConnect_Button.Font = new Font("Microsoft Sans Serif", 12F);
            IntifaceConnect_Button.HighEmphasis = true;
            IntifaceConnect_Button.Icon = null;
            IntifaceConnect_Button.Location = new Point(12, 49);
            IntifaceConnect_Button.Margin = new Padding(9);
            IntifaceConnect_Button.MouseState = MaterialSkin.MouseState.HOVER;
            IntifaceConnect_Button.Name = "IntifaceConnect_Button";
            IntifaceConnect_Button.NoAccentTextColor = Color.Empty;
            IntifaceConnect_Button.Size = new Size(107, 36);
            IntifaceConnect_Button.TabIndex = 0;
            IntifaceConnect_Button.Text = "Reconnect";
            IntifaceConnect_Button.Type = MaterialButton.MaterialButtonType.Contained;
            IntifaceConnect_Button.UseAccentColor = false;
            IntifaceConnect_Button.UseVisualStyleBackColor = true;
            IntifaceConnect_Button.Click += IntifaceConnectButton_Click;
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
            // TabControl
            // 
            TabControl.Controls.Add(TabPage_Home);
            TabControl.Controls.Add(TabPage_EldenRing);
            TabControl.Controls.Add(TabPage_DS1);
            TabControl.Controls.Add(TabPage_DS1R);
            TabControl.Controls.Add(TabPage_DS2);
            TabControl.Controls.Add(TabPage_DS3);
            TabControl.Depth = 0;
            TabControl.Dock = DockStyle.Fill;
            TabControl.ImageList = MenuTabIcons;
            TabControl.Location = new Point(3, 64);
            TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            TabControl.Multiline = true;
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.ShowToolTips = true;
            TabControl.Size = new Size(843, 636);
            TabControl.TabIndex = 0;
            // 
            // TabPage_Home
            // 
            TabPage_Home.BackColor = Color.White;
            TabPage_Home.Controls.Add(DeviceCount_Label);
            TabPage_Home.Controls.Add(IntifaceConnect_Button);
            TabPage_Home.Controls.Add(VibrateAll_Button);
            TabPage_Home.Controls.Add(ConnectionStatus_Label);
            TabPage_Home.Depth = 0;
            TabPage_Home.DrawIconSilhouette = true;
            TabPage_Home.ImageKey = "Sync";
            TabPage_Home.Location = new Point(4, 39);
            TabPage_Home.MouseState = MaterialSkin.MouseState.HOVER;
            TabPage_Home.Name = "TabPage_Home";
            TabPage_Home.Padding = new Padding(3);
            TabPage_Home.Size = new Size(835, 593);
            TabPage_Home.TabIndex = 0;
            TabPage_Home.Text = "Home";
            // 
            // DeviceCount_Label
            // 
            DeviceCount_Label.AutoSize = true;
            DeviceCount_Label.Depth = 0;
            DeviceCount_Label.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DeviceCount_Label.Location = new Point(12, 104);
            DeviceCount_Label.Margin = new Padding(9);
            DeviceCount_Label.MouseState = MaterialSkin.MouseState.HOVER;
            DeviceCount_Label.Name = "DeviceCount_Label";
            DeviceCount_Label.Size = new Size(73, 19);
            DeviceCount_Label.TabIndex = 4;
            DeviceCount_Label.Text = "Devices: 0";
            // 
            // TabPage_EldenRing
            // 
            TabPage_EldenRing.BackColor = Color.White;
            TabPage_EldenRing.Controls.Add(HealthPointsLabel);
            TabPage_EldenRing.Controls.Add(DetectEldenRingButton);
            TabPage_EldenRing.Controls.Add(DetectEldenRingLabel);
            TabPage_EldenRing.Depth = 0;
            TabPage_EldenRing.DrawIconSilhouette = false;
            TabPage_EldenRing.ImageKey = "EldenRing_256x256.png";
            TabPage_EldenRing.Location = new Point(4, 39);
            TabPage_EldenRing.MouseState = MaterialSkin.MouseState.HOVER;
            TabPage_EldenRing.Name = "TabPage_EldenRing";
            TabPage_EldenRing.Padding = new Padding(3);
            TabPage_EldenRing.Size = new Size(835, 593);
            TabPage_EldenRing.TabIndex = 1;
            TabPage_EldenRing.Text = "Elden Ring";
            TabPage_EldenRing.ToolTipText = "Elden Ring Settings";
            // 
            // HealthPointsLabel
            // 
            HealthPointsLabel.AutoSize = true;
            HealthPointsLabel.Depth = 0;
            HealthPointsLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            HealthPointsLabel.Location = new Point(12, 103);
            HealthPointsLabel.Margin = new Padding(9);
            HealthPointsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            HealthPointsLabel.Name = "HealthPointsLabel";
            HealthPointsLabel.Size = new Size(25, 19);
            HealthPointsLabel.TabIndex = 2;
            HealthPointsLabel.Text = "Hp:";
            // 
            // DetectEldenRingButton
            // 
            DetectEldenRingButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DetectEldenRingButton.Density = MaterialButton.MaterialButtonDensity.Default;
            DetectEldenRingButton.Depth = 0;
            DetectEldenRingButton.Enabled = false;
            DetectEldenRingButton.Font = new Font("Microsoft Sans Serif", 12F);
            DetectEldenRingButton.HighEmphasis = true;
            DetectEldenRingButton.Icon = null;
            DetectEldenRingButton.Location = new Point(12, 49);
            DetectEldenRingButton.Margin = new Padding(9);
            DetectEldenRingButton.MouseState = MaterialSkin.MouseState.HOVER;
            DetectEldenRingButton.Name = "DetectEldenRingButton";
            DetectEldenRingButton.NoAccentTextColor = Color.Empty;
            DetectEldenRingButton.Size = new Size(162, 36);
            DetectEldenRingButton.TabIndex = 1;
            DetectEldenRingButton.Text = "Detect Elden Ring";
            DetectEldenRingButton.Type = MaterialButton.MaterialButtonType.Contained;
            DetectEldenRingButton.UseAccentColor = false;
            DetectEldenRingButton.UseVisualStyleBackColor = true;
            // 
            // DetectEldenRingLabel
            // 
            DetectEldenRingLabel.AutoSize = true;
            DetectEldenRingLabel.Depth = 0;
            DetectEldenRingLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DetectEldenRingLabel.Location = new Point(12, 12);
            DetectEldenRingLabel.Margin = new Padding(9);
            DetectEldenRingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            DetectEldenRingLabel.Name = "DetectEldenRingLabel";
            DetectEldenRingLabel.Size = new Size(159, 19);
            DetectEldenRingLabel.TabIndex = 0;
            DetectEldenRingLabel.Text = "Detecting Elden Ring...";
            // 
            // TabPage_DS1
            // 
            TabPage_DS1.BackColor = Color.White;
            TabPage_DS1.Depth = 0;
            TabPage_DS1.DrawIconSilhouette = false;
            TabPage_DS1.ImageKey = "DS1-PTDE_256x256.png";
            TabPage_DS1.Location = new Point(4, 39);
            TabPage_DS1.MouseState = MaterialSkin.MouseState.HOVER;
            TabPage_DS1.Name = "TabPage_DS1";
            TabPage_DS1.Padding = new Padding(3);
            TabPage_DS1.Size = new Size(835, 593);
            TabPage_DS1.TabIndex = 3;
            TabPage_DS1.Text = "Dark Souls: PTDE";
            TabPage_DS1.ToolTipText = "Dark Souls: Prepare To Die Edition";
            // 
            // TabPage_DS1R
            // 
            TabPage_DS1R.BackColor = Color.White;
            TabPage_DS1R.Depth = 0;
            TabPage_DS1R.DrawIconSilhouette = false;
            TabPage_DS1R.ImageKey = "DS1-R_256x256.png";
            TabPage_DS1R.Location = new Point(4, 39);
            TabPage_DS1R.MouseState = MaterialSkin.MouseState.HOVER;
            TabPage_DS1R.Name = "TabPage_DS1R";
            TabPage_DS1R.Padding = new Padding(3);
            TabPage_DS1R.Size = new Size(835, 593);
            TabPage_DS1R.TabIndex = 4;
            TabPage_DS1R.Text = "Dark Souls: R";
            TabPage_DS1R.ToolTipText = "Dark Souls: Remastered";
            // 
            // TabPage_DS2
            // 
            TabPage_DS2.BackColor = Color.White;
            TabPage_DS2.Depth = 0;
            TabPage_DS2.DrawIconSilhouette = false;
            TabPage_DS2.ImageKey = "DS2-SOTFS_256x256.png";
            TabPage_DS2.Location = new Point(4, 39);
            TabPage_DS2.MouseState = MaterialSkin.MouseState.HOVER;
            TabPage_DS2.Name = "TabPage_DS2";
            TabPage_DS2.Padding = new Padding(3);
            TabPage_DS2.Size = new Size(835, 593);
            TabPage_DS2.TabIndex = 2;
            TabPage_DS2.Text = "Dark Souls 2: SotFS";
            TabPage_DS2.ToolTipText = "Dark Souls 2: Scholar of the First Sin";
            // 
            // TabPage_DS3
            // 
            TabPage_DS3.BackColor = Color.White;
            TabPage_DS3.Depth = 0;
            TabPage_DS3.DrawIconSilhouette = false;
            TabPage_DS3.ImageKey = "DS3_256x256.png";
            TabPage_DS3.Location = new Point(4, 39);
            TabPage_DS3.MouseState = MaterialSkin.MouseState.HOVER;
            TabPage_DS3.Name = "TabPage_DS3";
            TabPage_DS3.Padding = new Padding(3);
            TabPage_DS3.Size = new Size(835, 593);
            TabPage_DS3.TabIndex = 5;
            TabPage_DS3.Text = "Dark Souls 3";
            TabPage_DS3.ToolTipText = "Dark Souls 3";
            // 
            // MenuTabIcons
            // 
            MenuTabIcons.ColorDepth = ColorDepth.Depth32Bit;
            MenuTabIcons.ImageStream = (ImageListStreamer)resources.GetObject("MenuTabIcons.ImageStream");
            MenuTabIcons.TransparentColor = Color.Transparent;
            MenuTabIcons.Images.SetKeyName(0, "Sync");
            MenuTabIcons.Images.SetKeyName(1, "DS1-PTDE_256x256.png");
            MenuTabIcons.Images.SetKeyName(2, "DS1-R_256x256.png");
            MenuTabIcons.Images.SetKeyName(3, "DS2-SOTFS_256x256.png");
            MenuTabIcons.Images.SetKeyName(4, "DS3_256x256.png");
            MenuTabIcons.Images.SetKeyName(5, "EldenRing_256x256.png");
            // 
            // VibrateSouls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 703);
            Controls.Add(TabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControl;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VibrateSouls";
            Text = "Vibrate Souls";
            TabControl.ResumeLayout(false);
            TabPage_Home.ResumeLayout(false);
            TabPage_Home.PerformLayout();
            TabPage_EldenRing.ResumeLayout(false);
            TabPage_EldenRing.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialButton VibrateAll_Button;
        private MaterialLabel ConnectionStatus_Label;
        private MaterialButton IntifaceConnect_Button;
        private MaterialCheckbox materialCheckbox1;
        private MaterialCheckbox materialCheckbox2;
        private MaterialTabControl TabControl;
        private MaterialLabel HealthPointsLabel;
        private MaterialButton DetectEldenRingButton;
        private MaterialLabel DetectEldenRingLabel;
        private ImageList MenuTabIcons;
        private MaterialTabPage TabPage_Home;
        private MaterialTabPage TabPage_EldenRing;
        private MaterialTabPage TabPage_DS1;
        private MaterialTabPage TabPage_DS1R;
        private MaterialTabPage TabPage_DS2;
        private MaterialTabPage TabPage_DS3;
        private MaterialLabel DeviceCount_Label;
    }
}
