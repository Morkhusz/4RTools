using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class AutoclickMouseRightForm : Form, IObserver
    {
        private Subject subject;

        public AutoclickMouseRightForm(Subject subject)
        {
            InitializeComponent();
            this.subject = subject;
            subject.Attach(this);
            
            InitializeEvents();
            LoadConfiguration();
        }

        private void InitializeEvents()
        {
            this.txtToggleKey.KeyDown += new KeyEventHandler(FormUtils.OnKeyDown);
            this.txtToggleKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtToggleKey.TextChanged += new EventHandler(this.OnToggleKeyChange);
            this.numDelay.ValueChanged += new EventHandler(this.OnDelayChange);
            this.chkAudioFeedback.CheckedChanged += new EventHandler(this.OnAudioFeedbackChange);
            this.btnToggle.Click += new EventHandler(this.OnToggleClick);
        }

        private void LoadConfiguration()
        {
            var config = ProfileSingleton.GetCurrent().AutoclickMouseRight;
            if (config.ToggleKey != System.Windows.Input.Key.None)
            {
                this.txtToggleKey.Text = config.ToggleKey.ToString();
            }
            this.numDelay.Value = config.ClickDelay;
            this.chkAudioFeedback.Checked = config.AudioFeedback;
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            var config = ProfileSingleton.GetCurrent().AutoclickMouseRight;
            if (config.IsActive)
            {
                this.lblStatus.Text = "Status: ACTIVE";
                this.lblStatus.ForeColor = Color.Green;
                this.btnToggle.Text = "ON";
                this.btnToggle.BackColor = Color.Green;
            }
            else
            {
                this.lblStatus.Text = "Status: INACTIVE";
                this.lblStatus.ForeColor = Color.Red;
                this.btnToggle.Text = "OFF";
                this.btnToggle.BackColor = Color.Red;
            }
        }

        private void OnToggleKeyChange(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                var config = ProfileSingleton.GetCurrent().AutoclickMouseRight;
                
                // Unregister old key if any
                if (config.ToggleKey != System.Windows.Input.Key.None)
                {
                    Keys oldKey = (Keys)Enum.Parse(typeof(Keys), config.ToggleKey.ToString());
                    KeyboardHook.RemoveDown(oldKey);
                }
                
                if (!string.IsNullOrEmpty(textBox.Text))
                {
                    System.Windows.Input.Key key = (System.Windows.Input.Key)new KeyConverter().ConvertFromString(textBox.Text);
                    config.ToggleKey = key;
                    
                    // Register new key
                    Keys newKey = (Keys)Enum.Parse(typeof(Keys), key.ToString());
                    KeyboardHook.AddDown(newKey, new KeyboardHook.KeyPressed(config.ToggleActive));
                }
                else
                {
                    config.ToggleKey = System.Windows.Input.Key.None;
                }
                
                ProfileSingleton.SetConfiguration(config);
            }
            catch { }
        }

        private void OnDelayChange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ProfileSingleton.GetCurrent().AutoclickMouseRight.ClickDelay = (int)numericUpDown.Value;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoclickMouseRight);
        }

        private void OnAudioFeedbackChange(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            ProfileSingleton.GetCurrent().AutoclickMouseRight.AudioFeedback = checkBox.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoclickMouseRight);
        }

        private void OnToggleClick(object sender, EventArgs e)
        {
            var config = ProfileSingleton.GetCurrent().AutoclickMouseRight;
            config.ToggleActive();
            ProfileSingleton.SetConfiguration(config);
            UpdateStatus();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    LoadConfiguration();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AutoclickMouseRight.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AutoclickMouseRight.Stop();
                    break;
            }
        }
    }
}