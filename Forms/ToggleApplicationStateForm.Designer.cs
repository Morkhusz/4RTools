using System.Windows.Forms;

namespace _4RTools.Forms
{
    partial class ToggleApplicationStateForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToggleApplicationStateForm));
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbAudio = new System.Windows.Forms.CheckBox();
            this.txtStatusToggleKey = new System.Windows.Forms.TextBox();
            this.btnStatusToggle = new System.Windows.Forms.Button();
            this.lblStatusToggle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "4ROTools";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDoubleClick);
            // 
            // cbAudio
            // 
            this.cbAudio.AutoSize = true;
            this.cbAudio.Checked = true;
            this.cbAudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAudio.Location = new System.Drawing.Point(66, 3);
            this.cbAudio.Name = "cbAudio";
            this.cbAudio.Size = new System.Drawing.Size(57, 17);
            this.cbAudio.TabIndex = 28;
            this.cbAudio.Text = "Sound";
            this.cbAudio.UseVisualStyleBackColor = true;
            // 
            // txtStatusToggleKey
            // 
            this.txtStatusToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStatusToggleKey.Location = new System.Drawing.Point(64, 39);
            this.txtStatusToggleKey.Name = "txtStatusToggleKey";
            this.txtStatusToggleKey.Size = new System.Drawing.Size(61, 23);
            this.txtStatusToggleKey.TabIndex = 27;
            this.txtStatusToggleKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStatusToggle
            // 
            this.btnStatusToggle.BackColor = System.Drawing.Color.Brown;
            this.btnStatusToggle.FlatAppearance.BorderSize = 0;
            this.btnStatusToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusToggle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStatusToggle.Location = new System.Drawing.Point(128, 0);
            this.btnStatusToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatusToggle.Name = "btnStatusToggle";
            this.btnStatusToggle.Size = new System.Drawing.Size(98, 65);
            this.btnStatusToggle.TabIndex = 25;
            this.btnStatusToggle.Text = "OFF";
            this.btnStatusToggle.UseVisualStyleBackColor = false;
            // 
            // lblStatusToggle
            // 
            this.lblStatusToggle.AllowDrop = true;
            this.lblStatusToggle.AutoSize = true;
            this.lblStatusToggle.Location = new System.Drawing.Point(77, 23);
            this.lblStatusToggle.MaximumSize = new System.Drawing.Size(109, 30);
            this.lblStatusToggle.Name = "lblStatusToggle";
            this.lblStatusToggle.Size = new System.Drawing.Size(34, 13);
            this.lblStatusToggle.TabIndex = 26;
            this.lblStatusToggle.Text = "Tecla";
            this.lblStatusToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToggleApplicationStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(226, 114);
            this.Controls.Add(this.cbAudio);
            this.Controls.Add(this.txtStatusToggleKey);
            this.Controls.Add(this.btnStatusToggle);
            this.Controls.Add(this.lblStatusToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToggleApplicationStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToggleApplicationStateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private CheckBox cbAudio;
        private TextBox txtStatusToggleKey;
        private Button btnStatusToggle;
        private Label lblStatusToggle;
    }
}