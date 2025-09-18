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
            this.SuspendLayout();
            // 
            // lblCustomPlaceholder
            // 
            this.lblCustomPlaceholder.AutoSize = true;
            this.lblCustomPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomPlaceholder.Location = new System.Drawing.Point(50, 50);
            this.lblCustomPlaceholder.Name = "lblCustomPlaceholder";
            this.lblCustomPlaceholder.Size = new System.Drawing.Size(400, 20);
            this.lblCustomPlaceholder.TabIndex = 0;
            this.lblCustomPlaceholder.Text = "Custom Tab - New features will be added here";
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 274);
            this.Controls.Add(this.lblCustomPlaceholder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomForm";
            this.Text = "Custom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomPlaceholder;
    }
}