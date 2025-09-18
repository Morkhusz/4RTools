using System;
using System.Drawing;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Media;
using _4RTools.Properties;

namespace _4RTools.Forms
{
    public partial class ToggleApplicationStateForm : Form, IObserver
    {
        private Subject subject;
        private ContextMenu contextMenu;
        private MenuItem menuItem;

        //Store key used for last profile - necessarly to clean when change profile
        private Keys lastKey;

        public ToggleApplicationStateForm(Subject subject)
        {
            InitializeComponent();

            subject.Attach(this);
            this.subject = subject;
            KeyboardHook.Enable();
            this.txtStatusToggleKey.Text = ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey;
            this.txtStatusToggleKey.KeyDown += new KeyEventHandler(FormUtils.OnKeyDown);
            this.txtStatusToggleKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtStatusToggleKey.TextChanged += new EventHandler(this.onStatusToggleKeyChange);

            // Initialize auto control checkboxes
            InitializeAutoControlCheckboxes();

            InitializeContextualMenu();
        }

        private void InitializeAutoControlCheckboxes()
        {
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            
            // Set initial checkbox states from preferences
            this.cbCidade.Checked = preferences.AutoDisableOnCityEnter;
            this.cbChat.Checked = preferences.AutoDisableOnChatMessage;
            
            // Wire up event handlers
            this.cbCidade.CheckedChanged += new EventHandler(this.onCidadeCheckboxChange);
            this.cbChat.CheckedChanged += new EventHandler(this.onChatCheckboxChange);
        }

        private void InitializeContextualMenu()
        {
            this.contextMenu = new ContextMenu();
            this.menuItem = new MenuItem();

            this.contextMenu.MenuItems.AddRange(
                    new MenuItem[] { this.menuItem });

            this.menuItem.Index = 0;
            this.menuItem.Text = "Close";
            this.menuItem.Click += new EventHandler(this.notifyShutdownApplication);

            this.notifyIconTray.ContextMenu = this.contextMenu;
        }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).Message.code == MessageCode.PROFILE_CHANGED)
            {
                Keys currentToggleKey = (Keys)Enum.Parse(typeof(Keys), ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey);
                KeyboardHook.Remove(lastKey); //Remove last key hook to prevent toggle with last profile key used.

                this.txtStatusToggleKey.Text = currentToggleKey.ToString();
                KeyboardHook.Add(currentToggleKey, new KeyboardHook.KeyPressed(this.toggleStatus));
                lastKey = currentToggleKey;
                
                // Update checkbox states when profile changes
                UpdateCheckboxStates();
            }
        }
        
        private void UpdateCheckboxStates()
        {
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            this.cbCidade.Checked = preferences.AutoDisableOnCityEnter;
            this.cbChat.Checked = preferences.AutoDisableOnChatMessage;
        }

        private void btnToggleStatusHandler(object sender, EventArgs e) { this.toggleStatus(); }

        private void onStatusToggleKeyChange(object sender, EventArgs e)
        {
            //Get last key from profile before update it in json
            Keys currentToggleKey = (Keys)Enum.Parse(typeof(Keys), this.txtStatusToggleKey.Text);
            KeyboardHook.Remove(lastKey);
            KeyboardHook.Add(currentToggleKey, new KeyboardHook.KeyPressed(this.toggleStatus));
            ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey = currentToggleKey.ToString(); //Update profile key
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);

            lastKey = currentToggleKey; //Refresh lastKey to update 
        }

        private bool toggleStatus()
        {
            bool isOn = this.btnStatusToggle.Text == "ON";
            if (isOn)
            {
                this.btnStatusToggle.BackColor = Color.Red;
                this.btnStatusToggle.Text = "OFF";
                this.notifyIconTray.Icon = Resources._4RTools.ETCResource.logo_4rtools_off;
                this.subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
                this.lblStatusToggle.Text = "Press the key to start!";

                if (this.cbAudio.Checked) { new SoundPlayer(Resources._4RTools.ETCResource.Speech_Off).Play(); }
            }
            else
            {
                Client client = ClientSingleton.GetClient();
                if (client != null)
                {
                    this.btnStatusToggle.BackColor = Color.Green;
                    this.btnStatusToggle.Text = "ON";
                    this.notifyIconTray.Icon = Resources._4RTools.ETCResource.logo_4rtools_on;
                    this.subject.Notify(new Utils.Message(MessageCode.TURN_ON, null));
                    this.lblStatusToggle.Text = "Press the key to stop!";
                    this.lblStatusToggle.ForeColor = Color.Black;

                    if (this.cbAudio.Checked) { new SoundPlayer(Resources._4RTools.ETCResource.Speech_On).Play(); }
                }
                else
                {
                    this.lblStatusToggle.Text = "Please select the Ragnarok Client!!";
                    this.lblStatusToggle.ForeColor = Color.Red;
                }
            }

            return true;
        }

        private void notifyIconDoubleClick(object sender, MouseEventArgs e)
        {
            this.subject.Notify(new Utils.Message(MessageCode.CLICK_ICON_TRAY, null));
        }

        private void notifyShutdownApplication(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.subject.Notify(new Utils.Message(MessageCode.SHUTDOWN_APPLICATION, null));
        }

        private void onCidadeCheckboxChange(object sender, EventArgs e)
        {
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            var controller = MacroAutoControllerSingleton.GetInstance();
            
            if (preferences != null && controller != null)
            {
                preferences.AutoDisableOnCityEnter = this.cbCidade.Checked;
                preferences.AutoEnableOnCityExit = this.cbCidade.Checked; // Same setting for enter/exit
                controller.AutoDisableOnCityEnter = this.cbCidade.Checked;
                controller.AutoEnableOnCityExit = this.cbCidade.Checked;
                ProfileSingleton.SetConfiguration(preferences);
            }
        }

        private void onChatCheckboxChange(object sender, EventArgs e)
        {
            var preferences = ProfileSingleton.GetCurrent().UserPreferences;
            var controller = MacroAutoControllerSingleton.GetInstance();
            
            if (preferences != null && controller != null)
            {
                preferences.AutoDisableOnChatMessage = this.cbChat.Checked;
                controller.AutoDisableOnChatMessage = this.cbChat.Checked;
                ProfileSingleton.SetConfiguration(preferences);
            }
        }
    }
}