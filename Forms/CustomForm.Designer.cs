using System.Windows.Forms;

namespace _4RTools.Forms
{
    partial class CustomForm
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
            this.lblCustomPlaceholder = new System.Windows.Forms.Label();
            this.groupAutoclickLeft = new System.Windows.Forms.GroupBox();
            this.lblToggleKeyLeft = new System.Windows.Forms.Label();
            this.txtToggleKeyLeft = new System.Windows.Forms.TextBox();
            this.lblDelayLeft = new System.Windows.Forms.Label();
            this.numDelayLeft = new System.Windows.Forms.NumericUpDown();
            this.lblDelayMsLeft = new System.Windows.Forms.Label();
            this.chkAudioFeedbackLeft = new System.Windows.Forms.CheckBox();
            this.lblStatusLeft = new System.Windows.Forms.Label();
            this.btnToggleLeft = new System.Windows.Forms.Button();
            this.groupAutoclickRight = new System.Windows.Forms.GroupBox();
            this.lblToggleKeyRight = new System.Windows.Forms.Label();
            this.txtToggleKeyRight = new System.Windows.Forms.TextBox();
            this.lblDelayRight = new System.Windows.Forms.Label();
            this.numDelayRight = new System.Windows.Forms.NumericUpDown();
            this.lblDelayMsRight = new System.Windows.Forms.Label();
            this.chkAudioFeedbackRight = new System.Windows.Forms.CheckBox();
            this.lblStatusRight = new System.Windows.Forms.Label();
            this.btnToggleRight = new System.Windows.Forms.Button();
            this.groupAutoclickLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayLeft)).BeginInit();
            this.groupAutoclickRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomPlaceholder
            // 
            this.lblCustomPlaceholder.AutoSize = true;
            this.lblCustomPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomPlaceholder.Location = new System.Drawing.Point(50, 20);
            this.lblCustomPlaceholder.Name = "lblCustomPlaceholder";
            this.lblCustomPlaceholder.Size = new System.Drawing.Size(300, 20);
            this.lblCustomPlaceholder.TabIndex = 0;
            this.lblCustomPlaceholder.Text = "AutoClick";
            // 
            // groupAutoclickLeft
            // 
            this.groupAutoclickLeft.Controls.Add(this.lblToggleKeyLeft);
            this.groupAutoclickLeft.Controls.Add(this.txtToggleKeyLeft);
            this.groupAutoclickLeft.Controls.Add(this.lblDelayLeft);
            this.groupAutoclickLeft.Controls.Add(this.numDelayLeft);
            this.groupAutoclickLeft.Controls.Add(this.lblDelayMsLeft);
            this.groupAutoclickLeft.Controls.Add(this.chkAudioFeedbackLeft);
            this.groupAutoclickLeft.Controls.Add(this.lblStatusLeft);
            this.groupAutoclickLeft.Controls.Add(this.btnToggleLeft);
            this.groupAutoclickLeft.Location = new System.Drawing.Point(50, 60);
            this.groupAutoclickLeft.Name = "groupAutoclickLeft";
            this.groupAutoclickLeft.Size = new System.Drawing.Size(250, 160);
            this.groupAutoclickLeft.TabIndex = 1;
            this.groupAutoclickLeft.TabStop = false;
            this.groupAutoclickLeft.Text = "Mouse Left Configuration";
            // 
            // lblToggleKeyLeft
            // 
            this.lblToggleKeyLeft.AutoSize = true;
            this.lblToggleKeyLeft.Location = new System.Drawing.Point(15, 25);
            this.lblToggleKeyLeft.Name = "lblToggleKeyLeft";
            this.lblToggleKeyLeft.Size = new System.Drawing.Size(64, 13);
            this.lblToggleKeyLeft.TabIndex = 0;
            this.lblToggleKeyLeft.Text = "Toggle Key:";
            // 
            // txtToggleKeyLeft
            // 
            this.txtToggleKeyLeft.Location = new System.Drawing.Point(85, 22);
            this.txtToggleKeyLeft.Name = "txtToggleKeyLeft";
            this.txtToggleKeyLeft.ReadOnly = true;
            this.txtToggleKeyLeft.Size = new System.Drawing.Size(100, 20);
            this.txtToggleKeyLeft.TabIndex = 1;
            // 
            // lblDelayLeft
            // 
            this.lblDelayLeft.AutoSize = true;
            this.lblDelayLeft.Location = new System.Drawing.Point(15, 55);
            this.lblDelayLeft.Name = "lblDelayLeft";
            this.lblDelayLeft.Size = new System.Drawing.Size(65, 13);
            this.lblDelayLeft.TabIndex = 2;
            this.lblDelayLeft.Text = "Click Delay:";
            // 
            // numDelayLeft
            // 
            this.numDelayLeft.Location = new System.Drawing.Point(85, 53);
            this.numDelayLeft.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDelayLeft.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDelayLeft.Name = "numDelayLeft";
            this.numDelayLeft.Size = new System.Drawing.Size(60, 20);
            this.numDelayLeft.TabIndex = 3;
            this.numDelayLeft.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblDelayMsLeft
            // 
            this.lblDelayMsLeft.AutoSize = true;
            this.lblDelayMsLeft.Location = new System.Drawing.Point(151, 55);
            this.lblDelayMsLeft.Name = "lblDelayMsLeft";
            this.lblDelayMsLeft.Size = new System.Drawing.Size(20, 13);
            this.lblDelayMsLeft.TabIndex = 4;
            this.lblDelayMsLeft.Text = "ms";
            // 
            // chkAudioFeedbackLeft
            // 
            this.chkAudioFeedbackLeft.AutoSize = true;
            this.chkAudioFeedbackLeft.Checked = true;
            this.chkAudioFeedbackLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAudioFeedbackLeft.Location = new System.Drawing.Point(18, 85);
            this.chkAudioFeedbackLeft.Name = "chkAudioFeedbackLeft";
            this.chkAudioFeedbackLeft.Size = new System.Drawing.Size(99, 17);
            this.chkAudioFeedbackLeft.TabIndex = 5;
            this.chkAudioFeedbackLeft.Text = "Audio Feedback";
            this.chkAudioFeedbackLeft.UseVisualStyleBackColor = true;
            // 
            // lblStatusLeft
            // 
            this.lblStatusLeft.AutoSize = true;
            this.lblStatusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStatusLeft.Location = new System.Drawing.Point(15, 115);
            this.lblStatusLeft.Name = "lblStatusLeft";
            this.lblStatusLeft.Size = new System.Drawing.Size(142, 15);
            this.lblStatusLeft.TabIndex = 6;
            this.lblStatusLeft.Text = "Status: INACTIVE";
            // 
            // btnToggleLeft
            // 
            this.btnToggleLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnToggleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleLeft.ForeColor = System.Drawing.Color.White;
            this.btnToggleLeft.Location = new System.Drawing.Point(165, 110);
            this.btnToggleLeft.Name = "btnToggleLeft";
            this.btnToggleLeft.Size = new System.Drawing.Size(75, 25);
            this.btnToggleLeft.TabIndex = 7;
            this.btnToggleLeft.Text = "OFF";
            this.btnToggleLeft.UseVisualStyleBackColor = false;
            // 
            // groupAutoclickRight
            // 
            this.groupAutoclickRight.Controls.Add(this.lblToggleKeyRight);
            this.groupAutoclickRight.Controls.Add(this.txtToggleKeyRight);
            this.groupAutoclickRight.Controls.Add(this.lblDelayRight);
            this.groupAutoclickRight.Controls.Add(this.numDelayRight);
            this.groupAutoclickRight.Controls.Add(this.lblDelayMsRight);
            this.groupAutoclickRight.Controls.Add(this.chkAudioFeedbackRight);
            this.groupAutoclickRight.Controls.Add(this.lblStatusRight);
            this.groupAutoclickRight.Controls.Add(this.btnToggleRight);
            this.groupAutoclickRight.Location = new System.Drawing.Point(320, 60);
            this.groupAutoclickRight.Name = "groupAutoclickRight";
            this.groupAutoclickRight.Size = new System.Drawing.Size(250, 160);
            this.groupAutoclickRight.TabIndex = 2;
            this.groupAutoclickRight.TabStop = false;
            this.groupAutoclickRight.Text = "Mouse Right Configuration";
            // 
            // lblToggleKeyRight
            // 
            this.lblToggleKeyRight.AutoSize = true;
            this.lblToggleKeyRight.Location = new System.Drawing.Point(15, 25);
            this.lblToggleKeyRight.Name = "lblToggleKeyRight";
            this.lblToggleKeyRight.Size = new System.Drawing.Size(64, 13);
            this.lblToggleKeyRight.TabIndex = 0;
            this.lblToggleKeyRight.Text = "Toggle Key:";
            // 
            // txtToggleKeyRight
            // 
            this.txtToggleKeyRight.Location = new System.Drawing.Point(85, 22);
            this.txtToggleKeyRight.Name = "txtToggleKeyRight";
            this.txtToggleKeyRight.ReadOnly = true;
            this.txtToggleKeyRight.Size = new System.Drawing.Size(100, 20);
            this.txtToggleKeyRight.TabIndex = 1;
            // 
            // lblDelayRight
            // 
            this.lblDelayRight.AutoSize = true;
            this.lblDelayRight.Location = new System.Drawing.Point(15, 55);
            this.lblDelayRight.Name = "lblDelayRight";
            this.lblDelayRight.Size = new System.Drawing.Size(65, 13);
            this.lblDelayRight.TabIndex = 2;
            this.lblDelayRight.Text = "Click Delay:";
            // 
            // numDelayRight
            // 
            this.numDelayRight.Location = new System.Drawing.Point(85, 53);
            this.numDelayRight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDelayRight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDelayRight.Name = "numDelayRight";
            this.numDelayRight.Size = new System.Drawing.Size(60, 20);
            this.numDelayRight.TabIndex = 3;
            this.numDelayRight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblDelayMsRight
            // 
            this.lblDelayMsRight.AutoSize = true;
            this.lblDelayMsRight.Location = new System.Drawing.Point(151, 55);
            this.lblDelayMsRight.Name = "lblDelayMsRight";
            this.lblDelayMsRight.Size = new System.Drawing.Size(20, 13);
            this.lblDelayMsRight.TabIndex = 4;
            this.lblDelayMsRight.Text = "ms";
            // 
            // chkAudioFeedbackRight
            // 
            this.chkAudioFeedbackRight.AutoSize = true;
            this.chkAudioFeedbackRight.Checked = true;
            this.chkAudioFeedbackRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAudioFeedbackRight.Location = new System.Drawing.Point(18, 85);
            this.chkAudioFeedbackRight.Name = "chkAudioFeedbackRight";
            this.chkAudioFeedbackRight.Size = new System.Drawing.Size(99, 17);
            this.chkAudioFeedbackRight.TabIndex = 5;
            this.chkAudioFeedbackRight.Text = "Audio Feedback";
            this.chkAudioFeedbackRight.UseVisualStyleBackColor = true;
            // 
            // lblStatusRight
            // 
            this.lblStatusRight.AutoSize = true;
            this.lblStatusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblStatusRight.Location = new System.Drawing.Point(15, 115);
            this.lblStatusRight.Name = "lblStatusRight";
            this.lblStatusRight.Size = new System.Drawing.Size(142, 15);
            this.lblStatusRight.TabIndex = 6;
            this.lblStatusRight.Text = "Status: INACTIVE";
            // 
            // btnToggleRight
            // 
            this.btnToggleRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnToggleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleRight.ForeColor = System.Drawing.Color.White;
            this.btnToggleRight.Location = new System.Drawing.Point(165, 110);
            this.btnToggleRight.Name = "btnToggleRight";
            this.btnToggleRight.Size = new System.Drawing.Size(75, 25);
            this.btnToggleRight.TabIndex = 7;
            this.btnToggleRight.Text = "OFF";
            this.btnToggleRight.UseVisualStyleBackColor = false;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.groupAutoclickRight);
            this.Controls.Add(this.groupAutoclickLeft);
            this.Controls.Add(this.lblCustomPlaceholder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomForm";
            this.Text = "Custom";
            this.groupAutoclickLeft.ResumeLayout(false);
            this.groupAutoclickLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayLeft)).EndInit();
            this.groupAutoclickRight.ResumeLayout(false);
            this.groupAutoclickRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelayRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomPlaceholder;
        private System.Windows.Forms.GroupBox groupAutoclickLeft;
        private System.Windows.Forms.Label lblToggleKeyLeft;
        private System.Windows.Forms.TextBox txtToggleKeyLeft;
        private System.Windows.Forms.Label lblDelayLeft;
        private System.Windows.Forms.NumericUpDown numDelayLeft;
        private System.Windows.Forms.Label lblDelayMsLeft;
        private System.Windows.Forms.CheckBox chkAudioFeedbackLeft;
        private System.Windows.Forms.Label lblStatusLeft;
        private System.Windows.Forms.Button btnToggleLeft;
        private System.Windows.Forms.GroupBox groupAutoclickRight;
        private System.Windows.Forms.Label lblToggleKeyRight;
        private System.Windows.Forms.TextBox txtToggleKeyRight;
        private System.Windows.Forms.Label lblDelayRight;
        private System.Windows.Forms.NumericUpDown numDelayRight;
        private System.Windows.Forms.Label lblDelayMsRight;
        private System.Windows.Forms.CheckBox chkAudioFeedbackRight;
        private System.Windows.Forms.Label lblStatusRight;
        private System.Windows.Forms.Button btnToggleRight;
    }
}