using System;
using System.Windows.Forms;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class MacroAutoSettingsForm : Form, IObserver
    {
        public MacroAutoSettingsForm(Subject subject)
        {
            subject.Attach(this);
            InitializeComponent();
            LoadSettings();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    LoadSettings();
                    break;
            }
        }

        private void LoadSettings()
        {
            var controller = MacroAutoControllerSingleton.GetInstance();
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            
            if (controller != null && preferences != null)
            {
                // Load from user preferences
                controller.AutoDisableOnCityEnter = preferences.AutoDisableOnCityEnter;
                controller.AutoEnableOnCityExit = preferences.AutoEnableOnCityExit;
                controller.AutoDisableOnChatMessage = preferences.AutoDisableOnChatMessage;
                
                // Update UI
                cbAutoDisableOnCityEnter.Checked = preferences.AutoDisableOnCityEnter;
                cbAutoEnableOnCityExit.Checked = preferences.AutoEnableOnCityExit;
                cbAutoDisableOnChatMessage.Checked = preferences.AutoDisableOnChatMessage;
            }
        }

        private void cbAutoDisableOnCityEnter_CheckedChanged(object sender, EventArgs e)
        {
            var controller = MacroAutoControllerSingleton.GetInstance();
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            
            if (controller != null && preferences != null)
            {
                controller.AutoDisableOnCityEnter = cbAutoDisableOnCityEnter.Checked;
                preferences.AutoDisableOnCityEnter = cbAutoDisableOnCityEnter.Checked;
                ProfileSingleton.SetConfiguration(preferences);
            }
        }

        private void cbAutoEnableOnCityExit_CheckedChanged(object sender, EventArgs e)
        {
            var controller = MacroAutoControllerSingleton.GetInstance();
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            
            if (controller != null && preferences != null)
            {
                controller.AutoEnableOnCityExit = cbAutoEnableOnCityExit.Checked;
                preferences.AutoEnableOnCityExit = cbAutoEnableOnCityExit.Checked;
                ProfileSingleton.SetConfiguration(preferences);
            }
        }

        private void cbAutoDisableOnChatMessage_CheckedChanged(object sender, EventArgs e)
        {
            var controller = MacroAutoControllerSingleton.GetInstance();
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            
            if (controller != null && preferences != null)
            {
                controller.AutoDisableOnChatMessage = cbAutoDisableOnChatMessage.Checked;
                preferences.AutoDisableOnChatMessage = cbAutoDisableOnChatMessage.Checked;
                ProfileSingleton.SetConfiguration(preferences);
            }
        }

        private void InitializeComponent()
        {
            this.cbAutoDisableOnCityEnter = new CheckBox();
            this.cbAutoEnableOnCityExit = new CheckBox();
            this.cbAutoDisableOnChatMessage = new CheckBox();
            this.lblTitle = new Label();
            this.SuspendLayout();
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Configurações Automáticas";
            
            // 
            // cbAutoDisableOnCityEnter
            // 
            this.cbAutoDisableOnCityEnter.AutoSize = true;
            this.cbAutoDisableOnCityEnter.Location = new System.Drawing.Point(15, 35);
            this.cbAutoDisableOnCityEnter.Name = "cbAutoDisableOnCityEnter";
            this.cbAutoDisableOnCityEnter.Size = new System.Drawing.Size(240, 17);
            this.cbAutoDisableOnCityEnter.TabIndex = 1;
            this.cbAutoDisableOnCityEnter.Text = "Desligar macros ao entrar numa cidade";
            this.cbAutoDisableOnCityEnter.UseVisualStyleBackColor = true;
            this.cbAutoDisableOnCityEnter.CheckedChanged += new EventHandler(this.cbAutoDisableOnCityEnter_CheckedChanged);
            
            // 
            // cbAutoEnableOnCityExit
            // 
            this.cbAutoEnableOnCityExit.AutoSize = true;
            this.cbAutoEnableOnCityExit.Location = new System.Drawing.Point(15, 58);
            this.cbAutoEnableOnCityExit.Name = "cbAutoEnableOnCityExit";
            this.cbAutoEnableOnCityExit.Size = new System.Drawing.Size(225, 17);
            this.cbAutoEnableOnCityExit.TabIndex = 2;
            this.cbAutoEnableOnCityExit.Text = "Ligar macros ao sair de uma cidade";
            this.cbAutoEnableOnCityExit.UseVisualStyleBackColor = true;
            this.cbAutoEnableOnCityExit.CheckedChanged += new EventHandler(this.cbAutoEnableOnCityExit_CheckedChanged);
            
            // 
            // cbAutoDisableOnChatMessage
            // 
            this.cbAutoDisableOnChatMessage.AutoSize = true;
            this.cbAutoDisableOnChatMessage.Location = new System.Drawing.Point(15, 81);
            this.cbAutoDisableOnChatMessage.Name = "cbAutoDisableOnChatMessage";
            this.cbAutoDisableOnChatMessage.Size = new System.Drawing.Size(260, 17);
            this.cbAutoDisableOnChatMessage.TabIndex = 3;
            this.cbAutoDisableOnChatMessage.Text = "Desligar macros ao receber mensagens (PM)";
            this.cbAutoDisableOnChatMessage.UseVisualStyleBackColor = true;
            this.cbAutoDisableOnChatMessage.CheckedChanged += new EventHandler(this.cbAutoDisableOnChatMessage_CheckedChanged);
            
            // 
            // MacroAutoSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 120);
            this.Controls.Add(this.cbAutoDisableOnChatMessage);
            this.Controls.Add(this.cbAutoEnableOnCityExit);
            this.Controls.Add(this.cbAutoDisableOnCityEnter);
            this.Controls.Add(this.lblTitle);
            this.Name = "MacroAutoSettingsForm";
            this.Text = "Configurações Automáticas dos Macros";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private CheckBox cbAutoDisableOnCityEnter;
        private CheckBox cbAutoEnableOnCityExit;
        private CheckBox cbAutoDisableOnChatMessage;
        private Label lblTitle;
    }
}