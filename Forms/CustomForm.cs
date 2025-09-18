using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class CustomForm : Form, IObserver
    {
        private Subject subject;

        public CustomForm(Subject subject)
        {
            InitializeComponent();
            this.subject = subject;
            this.subject.Attach(this);
            
            InitializeEvents();
            LoadConfiguration();
        }

        private void InitializeEvents()
        {
            // Left click events
            this.txtToggleKeyLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtToggleKeyLeft.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtToggleKeyLeft.TextChanged += new EventHandler(this.OnToggleKeyLeftChange);
            this.numDelayLeft.ValueChanged += new EventHandler(this.OnDelayLeftChange);
            this.chkAudioFeedbackLeft.CheckedChanged += new EventHandler(this.OnAudioFeedbackLeftChange);
            this.btnToggleLeft.Click += new EventHandler(this.OnToggleLeftClick);
            
            // Right click events
            this.txtToggleKeyRight.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtToggleKeyRight.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtToggleKeyRight.TextChanged += new EventHandler(this.OnToggleKeyRightChange);
            this.numDelayRight.ValueChanged += new EventHandler(this.OnDelayRightChange);
            this.chkAudioFeedbackRight.CheckedChanged += new EventHandler(this.OnAudioFeedbackRightChange);
            this.btnToggleRight.Click += new EventHandler(this.OnToggleRightClick);
        }

        private void LoadConfiguration()
        {
            // Load left click configuration
            var configLeft = ProfileSingleton.GetCurrent().AutoclickMouseLeft;
            if (configLeft.ToggleKey != System.Windows.Input.Key.None)
            {
                this.txtToggleKeyLeft.Text = configLeft.ToggleKey.ToString();
            }
            this.numDelayLeft.Value = configLeft.ClickDelay;
            this.chkAudioFeedbackLeft.Checked = configLeft.AudioFeedback;
            
            // Load right click configuration
            var configRight = ProfileSingleton.GetCurrent().AutoclickMouseRight;
            if (configRight.ToggleKey != System.Windows.Input.Key.None)
            {
                this.txtToggleKeyRight.Text = configRight.ToggleKey.ToString();
            }
            this.numDelayRight.Value = configRight.ClickDelay;
            this.chkAudioFeedbackRight.Checked = configRight.AudioFeedback;
            
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            // Update left click status
            var configLeft = ProfileSingleton.GetCurrent().AutoclickMouseLeft;
            if (configLeft.IsActive)
            {
                this.lblStatusLeft.Text = "Status: ACTIVE";
                this.lblStatusLeft.ForeColor = Color.Green;
                this.btnToggleLeft.Text = "ON";
                this.btnToggleLeft.BackColor = Color.Green;
            }
            else
            {
                this.lblStatusLeft.Text = "Status: INACTIVE";
                this.lblStatusLeft.ForeColor = Color.FromArgb(52, 73, 94);
                this.btnToggleLeft.Text = "OFF";
                this.btnToggleLeft.BackColor = Color.FromArgb(52, 73, 94);
            }
            
            // Update right click status
            var configRight = ProfileSingleton.GetCurrent().AutoclickMouseRight;
            if (configRight.IsActive)
            {
                this.lblStatusRight.Text = "Status: ACTIVE";
                this.lblStatusRight.ForeColor = Color.Green;
                this.btnToggleRight.Text = "ON";
                this.btnToggleRight.BackColor = Color.Green;
            }
            else
            {
                this.lblStatusRight.Text = "Status: INACTIVE";
                this.lblStatusRight.ForeColor = Color.FromArgb(52, 73, 94);
                this.btnToggleRight.Text = "OFF";
                this.btnToggleRight.BackColor = Color.FromArgb(52, 73, 94);
            }
        }

        // Left click event handlers
        private void OnToggleKeyLeftChange(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                var config = ProfileSingleton.GetCurrent().AutoclickMouseLeft;
                
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
                    KeyboardHook.AddKeyDown(newKey, () => { config.ToggleActive(); UpdateStatus(); return true; });
                }
                else
                {
                    config.ToggleKey = System.Windows.Input.Key.None;
                }
                
                ProfileSingleton.SetConfiguration(config);
            }
            catch { }
        }

        private void OnDelayLeftChange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ProfileSingleton.GetCurrent().AutoclickMouseLeft.ClickDelay = (int)numericUpDown.Value;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoclickMouseLeft);
        }

        private void OnAudioFeedbackLeftChange(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            ProfileSingleton.GetCurrent().AutoclickMouseLeft.AudioFeedback = checkBox.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoclickMouseLeft);
        }

        private void OnToggleLeftClick(object sender, EventArgs e)
        {
            var config = ProfileSingleton.GetCurrent().AutoclickMouseLeft;
            config.ToggleActive();
            ProfileSingleton.SetConfiguration(config);
            UpdateStatus();
        }

        // Right click event handlers
        private void OnToggleKeyRightChange(object sender, EventArgs e)
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
                    KeyboardHook.AddKeyDown(newKey, () => { config.ToggleActive(); UpdateStatus(); return true; });
                }
                else
                {
                    config.ToggleKey = System.Windows.Input.Key.None;
                }
                
                ProfileSingleton.SetConfiguration(config);
            }
            catch { }
        }

        private void OnDelayRightChange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ProfileSingleton.GetCurrent().AutoclickMouseRight.ClickDelay = (int)numericUpDown.Value;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoclickMouseRight);
        }

        private void OnAudioFeedbackRightChange(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            ProfileSingleton.GetCurrent().AutoclickMouseRight.AudioFeedback = checkBox.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoclickMouseRight);
        }

        private void OnToggleRightClick(object sender, EventArgs e)
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
                case MessageCode.PROCESS_CHANGED:
                case MessageCode.PROFILE_CHANGED:
                    LoadConfiguration();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AutoclickMouseRight.Start();
                    ProfileSingleton.GetCurrent().AutoclickMouseLeft.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AutoclickMouseRight.Stop();
                    ProfileSingleton.GetCurrent().AutoclickMouseLeft.Stop();
                    break;
            }
        }
    }
}