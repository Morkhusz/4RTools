using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class Container : Form, IObserver
    {

        private Subject subject = new Subject();
        private string currentProfile;
        public Container()
        {
            this.subject.Attach(this);

            InitializeComponent();
            this.Text = AppConfig.Name + " - " + AppConfig.Version; // Window title

            //Container Configuration
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();

            //Paint Children Forms
            SetToggleApplicationStateWindow();
            SetAutopotWindow();
            SetAutopotYggWindow();
            SetSkillTimerWindow();
            SetProfileWindow();
            SetAHKWindow();
            SetCustomWindow();
            SetAutobuffSkillWindow();
            SetAutobuffStuffWindow();
            SetDebuffRecoveryWindow();
            SetSongMacroWindow();
            SetATKDEFWindow();
            SetMacroSwitchWindow();
            SetServerWindow();

            // Initialize the right panel with the first option (AutoClick)
            this.btnAutoClick_Click(this.btnAutoClick, EventArgs.Empty);

            TrackerSingleton.Instance().SendEvent("desktop_login", "page_view", "desktop_container_load");
        }

        public void addform(TabPage tp, Form f)
        {

            if (!tp.Controls.Contains(f))
            {
                tp.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();
                Refresh();
            }
            Refresh();
        }

        // New method for adding forms to Panel containers
        public void addformToPanel(Panel panel, Form f)
        {
            if (!panel.Controls.Contains(f))
            {
                f.TopLevel = false;
                panel.Controls.Add(f);
                // Position the form below the label
                f.Location = new Point(0, 20);
                f.Size = new Size(panel.Width - 2, panel.Height - 22);
                f.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                f.Show();
                panel.Refresh();
            }
            panel.Refresh();
        }

        // New method for adding forms to the right content panel
        public void addformToPanel(Form f)
        {
            // Clear the existing content
            this.rightContentPanel.Controls.Clear();
            
            // Add the new form
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.rightContentPanel.Controls.Add(f);
            f.Show();
            
            // Reset all button styles
            ResetButtonStyles();
        }

        private void ResetButtonStyles()
        {
            foreach (Control control in this.leftSidebarPanel.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = Color.Gray;
                }
            }
        }

        private void SetActiveButton(Button activeButton)
        {
            ResetButtonStyles();
            activeButton.BackColor = Color.DarkBlue;
        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)
                {
                    ctl.BackColor = Color.White;
                }

            }
        }

        private void processCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client client = new Client(this.processCB.SelectedItem.ToString());
            ClientSingleton.Instance(client);
            subject.Notify(new Utils.Message(Utils.MessageCode.PROCESS_CHANGED, null));
        }

        private void Container_Load(object sender, EventArgs e)
        {
            ProfileSingleton.Create("Default");
            this.refreshProcessList();
            this.refreshProfileList();
            this.profileCB.SelectedItem = "Default";
        }

        public void refreshProfileList()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.profileCB.Items.Clear();
            });
            foreach (string p in Profile.ListAll())
            {
                this.profileCB.Items.Add(p);
            }
        }

        private void refreshProcessList()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.processCB.Items.Clear();
            });
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle != "" && ClientListSingleton.ExistsByProcessName(p.ProcessName))
                {
                    this.processCB.Items.Add(string.Format("{0}.exe - {1}", p.ProcessName, p.Id));
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshProcessList();
        }

        protected override void OnClosed(EventArgs e)
        {
            ShutdownApplication();
            base.OnClosed(e);
        }

        private void ShutdownApplication()
        {
            KeyboardHook.Disable();
            subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
            Environment.Exit(0);
        }

        private void lblLinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConfig.GithubLink);
        }

        private void lblLinkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConfig.DiscordLink);
        }

        private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConfig.Website);
        }

        private void profileCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.profileCB.Text != currentProfile)
            {
                try
                {
                    ProfileSingleton.Load(this.profileCB.Text); //LOAD PROFILE
                    subject.Notify(new Utils.Message(MessageCode.PROFILE_CHANGED, null));
                    currentProfile = this.profileCB.Text.ToString();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"[ProfileSingleton.Load] Error Message: {ex.Message}");
                    MessageBox.Show($"Error while loading the new profile. \nPlease get in touch via Discord. \nPlease send this error message to the admin: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROCESS_CHANGED:
                case MessageCode.PROFILE_CHANGED:
                    Client client = ClientSingleton.GetClient();
                    if (client != null)
                        this.characterName.Text = client.ReadCharacterName();
                    break;
                case MessageCode.TURN_OFF:
                    this.profileCB.Enabled = true;
                    this.processCB.Enabled = true;

                    break;
                case MessageCode.TURN_ON:
                    this.profileCB.Enabled = false;
                    this.processCB.Enabled = false;
                    this.characterName.Text = ClientSingleton.GetClient().ReadCharacterName();
                    break;
                case MessageCode.SERVER_LIST_CHANGED:
                    this.refreshProcessList();
                    break;
                case MessageCode.CLICK_ICON_TRAY:
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    break;
                case MessageCode.SHUTDOWN_APPLICATION:
                    this.ShutdownApplication();
                    break;
            }
        }

        private void containerResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) { this.Hide(); }
        }

        #region Frames

        public void SetToggleApplicationStateWindow()
        {
            ToggleApplicationStateForm frm = new ToggleApplicationStateForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            this.OnOffPanel.Controls.Add(frm);
            frm.Show();
        }

        public void SetAutopotWindow()
        {
            AutopotForm frm = new AutopotForm(subject, false);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addformToPanel(this.panelAutopotContainer, frm);
        }
        public void SetAutopotYggWindow()
        {
            AutopotForm frm = new AutopotForm(subject, true);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addformToPanel(this.panelYggdrasilContainer, frm);
        }

        public void SetSkillTimerWindow()
        {
            SkillTimerForm frm = new SkillTimerForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabSkillTimer, frm);
        }

        public void SetProfileWindow()
        {
            ProfileForm frm = new ProfileForm(this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageProfiles, frm);
        }

        public void SetServerWindow()
        {
            ServersForm frm = new ServersForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageServer, frm);
        }

        public void SetAHKWindow()
        {
            AHKForm frm = new AHKForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageSpammer, frm);
        }

        public void SetCustomWindow()
        {
            CustomForm frm = new CustomForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageCustom, frm);
        }

        public void SetAutobuffSkillWindow()
        {
            SkillAutoBuffForm frm = new SkillAutoBuffForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabPageAutobuffSkill, frm);
            frm.Show();
        }

        public void SetAutobuffStuffWindow()
        {
            StuffAutoBuffForm frm = new StuffAutoBuffForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageAutobuffStuff, frm);
        }

        public void SetDebuffRecoveryWindow()
        {
            DebuffRecoveryForm frm = new DebuffRecoveryForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabDebuffRecovery, frm);
        }

        public void SetSongMacroWindow()
        {
            MacroSongForm frm = new MacroSongForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabPageMacroSongs, frm);
            frm.Show();
        }

        public void SetATKDEFWindow()
        {
            ATKDEFForm frm = new ATKDEFForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.atkDef, frm);
            frm.Show();
        }

        public void SetMacroSwitchWindow()
        {
            MacroSwitchForm frm = new MacroSwitchForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabMacroSwitch, frm);
            frm.Show();
        }

        #region Button Click Events
        
        private void btnAutoClick_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnAutoClick);
            CustomForm frm = new CustomForm(subject);
            addformToPanel(frm);
        }

        private void btnSkillSpammer_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnSkillSpammer);
            AHKForm frm = new AHKForm(subject);
            addformToPanel(frm);
        }

        private void btnDebuff_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnDebuff);
            DebuffRecoveryForm frm = new DebuffRecoveryForm(subject);
            addformToPanel(frm);
        }

        private void btnAutobuffSkill_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnAutobuffSkill);
            SkillAutoBuffForm frm = new SkillAutoBuffForm(subject);
            addformToPanel(frm);
        }

        private void btnAutobuffStuff_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnAutobuffStuff);
            StuffAutoBuffForm frm = new StuffAutoBuffForm(subject);
            addformToPanel(frm);
        }

        private void btnSkillTimer_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnSkillTimer);
            SkillTimerForm frm = new SkillTimerForm(subject);
            addformToPanel(frm);
        }

        private void btnMacroSwitch_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnMacroSwitch);
            MacroSwitchForm frm = new MacroSwitchForm(subject);
            addformToPanel(frm);
        }

        private void btnMacroSongs_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnMacroSongs);
            MacroSongForm frm = new MacroSongForm(subject);
            addformToPanel(frm);
        }

        private void btnATKDEF_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnATKDEF);
            ATKDEFForm frm = new ATKDEFForm(subject);
            addformToPanel(frm);
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnProfiles);
            ProfileForm frm = new ProfileForm(this);
            addformToPanel(frm);
        }

        private void btnServers_Click(object sender, EventArgs e)
        {
            SetActiveButton(this.btnServers);
            ServersForm frm = new ServersForm(subject);
            addformToPanel(frm);
        }

        #endregion

        #endregion

        private void leftSidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbPowered_Click(object sender, EventArgs e)
        {

        }

        private void lblProcessName_Click(object sender, EventArgs e)
        {

        }

        private void OnOffPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void characterName_Click(object sender, EventArgs e)
        {

        }

        private void panelAutopotContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}