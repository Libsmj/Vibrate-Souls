namespace VibrateGames
{
    partial class VibrateGames
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
            VibrateButton = new Button();
            RescanButton = new Button();
            NumDevicesLabel = new Label();
            DetectEldenRingLabel = new Label();
            DetectEldenRingButton = new Button();
            HealthPointsLabel = new Label();
            IntifaceConnectButton = new Button();
            SuspendLayout();
            // 
            // VibrateButton
            // 
            VibrateButton.Enabled = false;
            VibrateButton.Location = new Point(12, 93);
            VibrateButton.Name = "VibrateButton";
            VibrateButton.Size = new Size(75, 23);
            VibrateButton.TabIndex = 0;
            VibrateButton.Text = "Vibrate All";
            VibrateButton.UseVisualStyleBackColor = true;
            VibrateButton.Click += VibrateButton_Clicked;
            // 
            // RescanButton
            // 
            RescanButton.Enabled = false;
            RescanButton.Location = new Point(93, 24);
            RescanButton.Name = "RescanButton";
            RescanButton.Size = new Size(75, 23);
            RescanButton.TabIndex = 1;
            RescanButton.Text = "Rescan";
            RescanButton.UseVisualStyleBackColor = true;
            RescanButton.Click += RescanButton_Click;
            // 
            // NumDevicesLabel
            // 
            NumDevicesLabel.AutoSize = true;
            NumDevicesLabel.Location = new Point(12, 61);
            NumDevicesLabel.Name = "NumDevicesLabel";
            NumDevicesLabel.Size = new Size(65, 15);
            NumDevicesLabel.TabIndex = 2;
            NumDevicesLabel.Text = "Scanning...";
            // 
            // DetectEldenRingLabel
            // 
            DetectEldenRingLabel.AutoSize = true;
            DetectEldenRingLabel.Location = new Point(12, 146);
            DetectEldenRingLabel.Name = "DetectEldenRingLabel";
            DetectEldenRingLabel.Size = new Size(126, 15);
            DetectEldenRingLabel.TabIndex = 4;
            DetectEldenRingLabel.Text = "Detecting Elden Ring...";
            // 
            // DetectEldenRingButton
            // 
            DetectEldenRingButton.Enabled = false;
            DetectEldenRingButton.Location = new Point(12, 164);
            DetectEldenRingButton.Name = "DetectEldenRingButton";
            DetectEldenRingButton.Size = new Size(128, 23);
            DetectEldenRingButton.TabIndex = 5;
            DetectEldenRingButton.Text = "Detect Elden Ring";
            DetectEldenRingButton.UseVisualStyleBackColor = true;
            DetectEldenRingButton.Click += DetectEldenRing_Click;
            // 
            // HealthPointsLabel
            // 
            HealthPointsLabel.AutoSize = true;
            HealthPointsLabel.Location = new Point(12, 201);
            HealthPointsLabel.Name = "HealthPointsLabel";
            HealthPointsLabel.Size = new Size(26, 15);
            HealthPointsLabel.TabIndex = 6;
            HealthPointsLabel.Text = "Hp:";
            // 
            // IntifaceConnectButton
            // 
            IntifaceConnectButton.Enabled = false;
            IntifaceConnectButton.Location = new Point(12, 24);
            IntifaceConnectButton.Name = "IntifaceConnectButton";
            IntifaceConnectButton.Size = new Size(75, 23);
            IntifaceConnectButton.TabIndex = 7;
            IntifaceConnectButton.Text = "Reconnect";
            IntifaceConnectButton.UseVisualStyleBackColor = true;
            IntifaceConnectButton.Click += IntifaceConnectButton_Click;
            // 
            // VibrateGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 301);
            Controls.Add(IntifaceConnectButton);
            Controls.Add(HealthPointsLabel);
            Controls.Add(DetectEldenRingButton);
            Controls.Add(DetectEldenRingLabel);
            Controls.Add(NumDevicesLabel);
            Controls.Add(RescanButton);
            Controls.Add(VibrateButton);
            Name = "VibrateGames";
            Text = "Vibrate Souls";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button VibrateButton;
        private Button RescanButton;
        private Label NumDevicesLabel;
        private Label DetectEldenRingLabel;
        private Button DetectEldenRingButton;
        private Label HealthPointsLabel;
        private Button IntifaceConnectButton;
    }
}
