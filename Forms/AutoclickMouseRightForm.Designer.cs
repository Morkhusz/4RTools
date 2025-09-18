namespace _4RTools.Forms
{
    partial class AutoclickMouseRightForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblToggleKey = new System.Windows.Forms.Label();
            this.txtToggleKey = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.lblDelayMs = new System.Windows.Forms.Label();
            this.chkAudioFeedback = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.groupConfig = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.groupConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToggleKey
            // 
            this.lblToggleKey.AutoSize = true;
            this.lblToggleKey.Location = new System.Drawing.Point(15, 25);
            this.lblToggleKey.Name = "lblToggleKey";
            this.lblToggleKey.Size = new System.Drawing.Size(64, 13);
            this.lblToggleKey.TabIndex = 0;
            this.lblToggleKey.Text = "Toggle Key:";
            // 
            // txtToggleKey
            // 
            this.txtToggleKey.Location = new System.Drawing.Point(85, 22);
            this.txtToggleKey.Name = "txtToggleKey";
            this.txtToggleKey.ReadOnly = true;
            this.txtToggleKey.Size = new System.Drawing.Size(100, 20);
            this.txtToggleKey.TabIndex = 1;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(15, 55);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(65, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Click Delay:";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(85, 53);
            this.numDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(60, 20);
            this.numDelay.TabIndex = 3;
            this.numDelay.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblDelayMs
            // 
            this.lblDelayMs.AutoSize = true;
            this.lblDelayMs.Location = new System.Drawing.Point(151, 55);
            this.lblDelayMs.Name = "lblDelayMs";
            this.lblDelayMs.Size = new System.Drawing.Size(20, 13);
            this.lblDelayMs.TabIndex = 4;
            this.lblDelayMs.Text = "ms";
            // 
            // chkAudioFeedback
            // 
            this.chkAudioFeedback.AutoSize = true;
            this.chkAudioFeedback.Checked = true;
            this.chkAudioFeedback.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAudioFeedback.Location = new System.Drawing.Point(18, 85);
            this.chkAudioFeedback.Name = "chkAudioFeedback";
            this.chkAudioFeedback.Size = new System.Drawing.Size(99, 17);
            this.chkAudioFeedback.TabIndex = 5;
            this.chkAudioFeedback.Text = "Audio Feedback";
            this.chkAudioFeedback.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(15, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(142, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status: INACTIVE";
            // 
            // btnToggle
            // 
            this.btnToggle.BackColor = System.Drawing.Color.Red;
            this.btnToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.Location = new System.Drawing.Point(200, 145);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 25);
            this.btnToggle.TabIndex = 7;
            this.btnToggle.Text = "OFF";
            this.btnToggle.UseVisualStyleBackColor = false;
            // 
            // groupConfig
            // 
            this.groupConfig.Controls.Add(this.lblToggleKey);
            this.groupConfig.Controls.Add(this.txtToggleKey);
            this.groupConfig.Controls.Add(this.lblDelay);
            this.groupConfig.Controls.Add(this.numDelay);
            this.groupConfig.Controls.Add(this.lblDelayMs);
            this.groupConfig.Controls.Add(this.chkAudioFeedback);
            this.groupConfig.Location = new System.Drawing.Point(15, 15);
            this.groupConfig.Name = "groupConfig";
            this.groupConfig.Size = new System.Drawing.Size(260, 120);
            this.groupConfig.TabIndex = 8;
            this.groupConfig.TabStop = false;
            this.groupConfig.Text = "Autoclick Mouse Right Configuration";
            // 
            // AutoclickMouseRightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 185);
            this.Controls.Add(this.groupConfig);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoclickMouseRightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autoclick Mouse Right";
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.groupConfig.ResumeLayout(false);
            this.groupConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToggleKey;
        private System.Windows.Forms.TextBox txtToggleKey;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label lblDelayMs;
        private System.Windows.Forms.CheckBox chkAudioFeedback;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.GroupBox groupConfig;
    }
}