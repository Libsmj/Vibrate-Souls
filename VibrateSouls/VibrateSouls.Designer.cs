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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VibrateSouls));
            VibrateButton = new Button();
            RescanButton = new Button();
            DeviceStatusLabel = new Label();
            DetectEldenRingLabel = new Label();
            DetectEldenRingButton = new Button();
            HealthPointsLabel = new Label();
            IntifaceConnectButton = new Button();
            VibrationsEnabledButton = new CheckBox();
            SuspendLayout();
            // 
            // VibrateButton
            // 
            VibrateButton.Enabled = false;
            VibrateButton.Font = new Font("Microsoft Sans Serif", 12F);
            VibrateButton.Location = new Point(12, 99);
            VibrateButton.Margin = new Padding(3, 9, 3, 3);
            VibrateButton.Name = "VibrateButton";
            VibrateButton.Size = new Size(112, 34);
            VibrateButton.TabIndex = 0;
            VibrateButton.Text = "Vibrate All";
            VibrateButton.UseVisualStyleBackColor = true;
            VibrateButton.Click += VibrateButton_Clicked;
            // 
            // RescanButton
            // 
            RescanButton.Enabled = false;
            RescanButton.Font = new Font("Microsoft Sans Serif", 12F);
            RescanButton.Location = new Point(130, 24);
            RescanButton.Margin = new Padding(3, 9, 3, 3);
            RescanButton.Name = "RescanButton";
            RescanButton.Size = new Size(112, 34);
            RescanButton.TabIndex = 1;
            RescanButton.Text = "Rescan";
            RescanButton.UseVisualStyleBackColor = true;
            RescanButton.Click += RescanButton_Click;
            // 
            // NumDevicesLabel
            // 
            DeviceStatusLabel.AutoSize = true;
            DeviceStatusLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DeviceStatusLabel.Location = new Point(12, 70);
            DeviceStatusLabel.Margin = new Padding(3, 9, 3, 0);
            DeviceStatusLabel.Name = "NumDevicesLabel";
            DeviceStatusLabel.Size = new Size(167, 20);
            DeviceStatusLabel.TabIndex = 2;
            DeviceStatusLabel.Text = "Connecting to server...";
            // 
            // DetectEldenRingLabel
            // 
            DetectEldenRingLabel.AutoSize = true;
            DetectEldenRingLabel.Font = new Font("Microsoft Sans Serif", 12F);
            DetectEldenRingLabel.Location = new Point(12, 177);
            DetectEldenRingLabel.Name = "DetectEldenRingLabel";
            DetectEldenRingLabel.Size = new Size(172, 20);
            DetectEldenRingLabel.TabIndex = 4;
            DetectEldenRingLabel.Text = "Detecting Elden Ring...";
            // 
            // DetectEldenRingButton
            // 
            DetectEldenRingButton.Enabled = false;
            DetectEldenRingButton.Font = new Font("Microsoft Sans Serif", 12F);
            DetectEldenRingButton.Location = new Point(12, 206);
            DetectEldenRingButton.Margin = new Padding(3, 9, 3, 3);
            DetectEldenRingButton.Name = "DetectEldenRingButton";
            DetectEldenRingButton.Size = new Size(172, 34);
            DetectEldenRingButton.TabIndex = 5;
            DetectEldenRingButton.Text = "Detect Elden Ring";
            DetectEldenRingButton.UseVisualStyleBackColor = true;
            DetectEldenRingButton.Click += DetectEldenRing_Click;
            // 
            // HealthPointsLabel
            // 
            HealthPointsLabel.AutoSize = true;
            HealthPointsLabel.Font = new Font("Microsoft Sans Serif", 12F);
            HealthPointsLabel.Location = new Point(12, 243);
            HealthPointsLabel.Name = "HealthPointsLabel";
            HealthPointsLabel.Size = new Size(34, 20);
            HealthPointsLabel.TabIndex = 6;
            HealthPointsLabel.Text = "Hp:";
            // 
            // IntifaceConnectButton
            // 
            IntifaceConnectButton.Enabled = false;
            IntifaceConnectButton.Font = new Font("Microsoft Sans Serif", 12F);
            IntifaceConnectButton.Location = new Point(12, 24);
            IntifaceConnectButton.Margin = new Padding(3, 9, 3, 3);
            IntifaceConnectButton.Name = "IntifaceConnectButton";
            IntifaceConnectButton.Size = new Size(112, 34);
            IntifaceConnectButton.TabIndex = 7;
            IntifaceConnectButton.Text = "Reconnect";
            IntifaceConnectButton.UseVisualStyleBackColor = true;
            IntifaceConnectButton.Click += IntifaceConnectButton_Click;
            // 
            // VibrationsEnabledButton
            // 
            VibrationsEnabledButton.Appearance = Appearance.Button;
            VibrationsEnabledButton.BackColor = Color.Yellow;
            VibrationsEnabledButton.Enabled = false;
            VibrationsEnabledButton.Font = new Font("Microsoft Sans Serif", 12F);
            VibrationsEnabledButton.ForeColor = SystemColors.ControlText;
            VibrationsEnabledButton.Location = new Point(142, 99);
            VibrationsEnabledButton.Name = "VibrationsEnabledButton";
            VibrationsEnabledButton.Size = new Size(113, 52);
            VibrationsEnabledButton.TabIndex = 8;
            VibrationsEnabledButton.Text = "Vibrations Disabled";
            VibrationsEnabledButton.TextAlign = ContentAlignment.MiddleCenter;
            VibrationsEnabledButton.UseVisualStyleBackColor = false;
            // 
            // VibrateSouls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 364);
            Controls.Add(VibrationsEnabledButton);
            Controls.Add(IntifaceConnectButton);
            Controls.Add(HealthPointsLabel);
            Controls.Add(DetectEldenRingButton);
            Controls.Add(DetectEldenRingLabel);
            Controls.Add(DeviceStatusLabel);
            Controls.Add(RescanButton);
            Controls.Add(VibrateButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VibrateSouls";
            Text = "Vibrate Souls";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VibrateButton;
        private Button RescanButton;
        private Label DeviceStatusLabel;
        private Label DetectEldenRingLabel;
        private Button DetectEldenRingButton;
        private Label HealthPointsLabel;
        private Button IntifaceConnectButton;
        private CheckBox VibrationsEnabledButton;
    }
}
