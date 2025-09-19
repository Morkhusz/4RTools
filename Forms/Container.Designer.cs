using System.Windows.Forms;

namespace _4RTools.Forms
{
    partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.lblProcessName = new System.Windows.Forms.Label();
            this.processCB = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.TabControlImageList = new System.Windows.Forms.ImageList(this.components);
            this.lblLinkDiscord = new System.Windows.Forms.LinkLabel();
            this.panelDiscImage = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.profileCB = new System.Windows.Forms.ComboBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lbPowered = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControlAutopot = new System.Windows.Forms.TabControl();
            this.tabPageAutopot = new System.Windows.Forms.TabPage();
            this.tabPageYggAutopot = new System.Windows.Forms.TabPage();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.tabPageProfiles = new System.Windows.Forms.TabPage();
            this.tabMacroSwitch = new System.Windows.Forms.TabPage();
            this.atkDef = new System.Windows.Forms.TabPage();
            this.tabPageMacroSongs = new System.Windows.Forms.TabPage();
            this.tabPageCustom = new System.Windows.Forms.TabPage();
            this.tabPageSpammer = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffStuff = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffSkill = new System.Windows.Forms.TabPage();
            this.tabSkillTimer = new System.Windows.Forms.TabPage();
            this.tabDebuffRecovery = new System.Windows.Forms.TabPage();
            this.leftSidebarPanel = new System.Windows.Forms.Panel();
            this.rightContentPanel = new System.Windows.Forms.Panel();
            this.btnAutoClick = new System.Windows.Forms.Button();
            this.btnSkillSpammer = new System.Windows.Forms.Button();
            this.btnDebuff = new System.Windows.Forms.Button();
            this.btnAutobuffSkill = new System.Windows.Forms.Button();
            this.btnAutobuffStuff = new System.Windows.Forms.Button();
            this.btnSkillTimer = new System.Windows.Forms.Button();
            this.btnMacroSwitch = new System.Windows.Forms.Button();
            this.btnMacroSongs = new System.Windows.Forms.Button();
            this.btnATKDEF = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.btnServers = new System.Windows.Forms.Button();
            this.characterName = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.OnOffPanel = new System.Windows.Forms.Panel();
            this.panelFooter.SuspendLayout();
            this.tabControlAutopot.SuspendLayout();
            this.leftSidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProcessName.Location = new System.Drawing.Point(12, 9);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(109, 17);
            this.lblProcessName.TabIndex = 3;
            this.lblProcessName.Text = "Ragnarok Client";
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(17, 29);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(184, 21);
            this.processCB.TabIndex = 2;
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(201, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(19, 22);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TabControlImageList
            // 
            this.TabControlImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TabControlImageList.ImageStream")));
            this.TabControlImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.TabControlImageList.Images.SetKeyName(0, "new.png");
            // 
            // lblLinkDiscord
            // 
            this.lblLinkDiscord.AutoSize = true;
            this.lblLinkDiscord.Location = new System.Drawing.Point(795, 16);
            this.lblLinkDiscord.Name = "lblLinkDiscord";
            this.lblLinkDiscord.Size = new System.Drawing.Size(92, 13);
            this.lblLinkDiscord.TabIndex = 8;
            this.lblLinkDiscord.TabStop = true;
            this.lblLinkDiscord.Text = "Join in our discord";
            this.lblLinkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkDiscord_LinkClicked);
            // 
            // panelDiscImage
            // 
            this.panelDiscImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDiscImage.BackgroundImage")));
            this.panelDiscImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelDiscImage.Location = new System.Drawing.Point(756, 6);
            this.panelDiscImage.Name = "panelDiscImage";
            this.panelDiscImage.Size = new System.Drawing.Size(32, 33);
            this.panelDiscImage.TabIndex = 10;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProfile.Location = new System.Drawing.Point(401, 10);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(48, 17);
            this.labelProfile.TabIndex = 15;
            this.labelProfile.Text = "Profile";
            // 
            // profileCB
            // 
            this.profileCB.FormattingEnabled = true;
            this.profileCB.Location = new System.Drawing.Point(405, 30);
            this.profileCB.Name = "profileCB";
            this.profileCB.Size = new System.Drawing.Size(181, 21);
            this.profileCB.TabIndex = 14;
            this.profileCB.SelectedIndexChanged += new System.EventHandler(this.profileCB_SelectedIndexChanged);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.Controls.Add(this.lbPowered);
            this.panelFooter.Controls.Add(this.lblLinkDiscord);
            this.panelFooter.Controls.Add(this.panelDiscImage);
            this.panelFooter.Location = new System.Drawing.Point(-3, 580);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(903, 43);
            this.panelFooter.TabIndex = 16;
            // 
            // lbPowered
            // 
            this.lbPowered.AutoSize = true;
            this.lbPowered.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPowered.Location = new System.Drawing.Point(16, 16);
            this.lbPowered.Name = "lbPowered";
            this.lbPowered.Size = new System.Drawing.Size(181, 13);
            this.lbPowered.TabIndex = 0;
            this.lbPowered.Text = "Powered by AuTHEntiC and MarkiinG";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(16, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 1);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(330, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 165);
            this.panel5.TabIndex = 18;
            // 
            // tabControlAutopot
            // 
            this.tabControlAutopot.Controls.Add(this.tabPageAutopot);
            this.tabControlAutopot.Controls.Add(this.tabPageYggAutopot);
            this.tabControlAutopot.ImageList = this.TabControlImageList;
            this.tabControlAutopot.Location = new System.Drawing.Point(175, 83);
            this.tabControlAutopot.Name = "tabControlAutopot";
            this.tabControlAutopot.SelectedIndex = 0;
            this.tabControlAutopot.Size = new System.Drawing.Size(148, 165);
            this.tabControlAutopot.TabIndex = 25;
            // 
            // tabPageAutopot
            // 
            this.tabPageAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutopot.Name = "tabPageAutopot";
            this.tabPageAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutopot.Size = new System.Drawing.Size(140, 139);
            this.tabPageAutopot.TabIndex = 0;
            this.tabPageAutopot.Text = "Autopot";
            this.tabPageAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageYggAutopot
            // 
            this.tabPageYggAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageYggAutopot.Name = "tabPageYggAutopot";
            this.tabPageYggAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYggAutopot.Size = new System.Drawing.Size(140, 139);
            this.tabPageYggAutopot.TabIndex = 3;
            this.tabPageYggAutopot.Text = "Yggdrasil";
            this.tabPageYggAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageServer
            // 
            this.tabPageServer.Location = new System.Drawing.Point(4, 22);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServer.Size = new System.Drawing.Size(865, 274);
            this.tabPageServer.TabIndex = 9;
            this.tabPageServer.Text = "Servers";
            this.tabPageServer.UseVisualStyleBackColor = true;
            // 
            // tabPageProfiles
            // 
            this.tabPageProfiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfiles.Name = "tabPageProfiles";
            this.tabPageProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfiles.Size = new System.Drawing.Size(865, 274);
            this.tabPageProfiles.TabIndex = 7;
            this.tabPageProfiles.Text = "Profiles";
            this.tabPageProfiles.UseVisualStyleBackColor = true;
            // 
            // tabMacroSwitch
            // 
            this.tabMacroSwitch.Location = new System.Drawing.Point(4, 22);
            this.tabMacroSwitch.Name = "tabMacroSwitch";
            this.tabMacroSwitch.Padding = new System.Windows.Forms.Padding(3);
            this.tabMacroSwitch.Size = new System.Drawing.Size(865, 274);
            this.tabMacroSwitch.TabIndex = 8;
            this.tabMacroSwitch.Text = "Macro Switch";
            this.tabMacroSwitch.UseVisualStyleBackColor = true;
            // 
            // atkDef
            // 
            this.atkDef.Location = new System.Drawing.Point(4, 22);
            this.atkDef.Name = "atkDef";
            this.atkDef.Padding = new System.Windows.Forms.Padding(3);
            this.atkDef.Size = new System.Drawing.Size(865, 274);
            this.atkDef.TabIndex = 5;
            this.atkDef.Text = "ATK x DEF Mode";
            this.atkDef.UseVisualStyleBackColor = true;
            // 
            // tabPageMacroSongs
            // 
            this.tabPageMacroSongs.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacroSongs.Name = "tabPageMacroSongs";
            this.tabPageMacroSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacroSongs.Size = new System.Drawing.Size(865, 274);
            this.tabPageMacroSongs.TabIndex = 6;
            this.tabPageMacroSongs.Text = "Macro Songs";
            this.tabPageMacroSongs.UseVisualStyleBackColor = true;
            // 
            // tabPageCustom
            // 
            this.tabPageCustom.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustom.Name = "tabPageCustom";
            this.tabPageCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustom.Size = new System.Drawing.Size(563, 274);
            this.tabPageCustom.TabIndex = 10;
            this.tabPageCustom.Text = "AutoClick";
            this.tabPageCustom.UseVisualStyleBackColor = true;
            // 
            // tabPageSpammer
            // 
            this.tabPageSpammer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpammer.Name = "tabPageSpammer";
            this.tabPageSpammer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpammer.Size = new System.Drawing.Size(563, 274);
            this.tabPageSpammer.TabIndex = 1;
            this.tabPageSpammer.Text = "Skill Spammer";
            this.tabPageSpammer.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffStuff
            // 
            this.tabPageAutobuffStuff.ImageIndex = 0;
            this.tabPageAutobuffStuff.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffStuff.Name = "tabPageAutobuffStuff";
            this.tabPageAutobuffStuff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffStuff.Size = new System.Drawing.Size(865, 274);
            this.tabPageAutobuffStuff.TabIndex = 4;
            this.tabPageAutobuffStuff.Text = "Autobuff - Stuffs";
            this.tabPageAutobuffStuff.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffSkill
            // 
            this.tabPageAutobuffSkill.ImageIndex = 0;
            this.tabPageAutobuffSkill.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffSkill.Name = "tabPageAutobuffSkill";
            this.tabPageAutobuffSkill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffSkill.Size = new System.Drawing.Size(865, 274);
            this.tabPageAutobuffSkill.TabIndex = 3;
            this.tabPageAutobuffSkill.Text = "Autobuff - Skills";
            this.tabPageAutobuffSkill.UseVisualStyleBackColor = true;
            // 
            // tabSkillTimer
            // 
            this.tabSkillTimer.ImageIndex = 0;
            this.tabSkillTimer.Location = new System.Drawing.Point(4, 22);
            this.tabSkillTimer.Name = "tabSkillTimer";
            this.tabSkillTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkillTimer.Size = new System.Drawing.Size(865, 274);
            this.tabSkillTimer.TabIndex = 5;
            this.tabSkillTimer.Text = "Skill timers";
            this.tabSkillTimer.UseVisualStyleBackColor = true;
            // 
            // leftSidebarPanel
            // 
            this.leftSidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leftSidebarPanel.Controls.Add(this.btnServers);
            this.leftSidebarPanel.Controls.Add(this.btnProfiles);
            this.leftSidebarPanel.Controls.Add(this.btnATKDEF);
            this.leftSidebarPanel.Controls.Add(this.btnMacroSongs);
            this.leftSidebarPanel.Controls.Add(this.btnMacroSwitch);
            this.leftSidebarPanel.Controls.Add(this.btnSkillTimer);
            this.leftSidebarPanel.Controls.Add(this.btnAutobuffStuff);
            this.leftSidebarPanel.Controls.Add(this.btnAutobuffSkill);
            this.leftSidebarPanel.Controls.Add(this.btnDebuff);
            this.leftSidebarPanel.Controls.Add(this.btnSkillSpammer);
            this.leftSidebarPanel.Controls.Add(this.btnAutoClick);
            this.leftSidebarPanel.Location = new System.Drawing.Point(15, 83);
            this.leftSidebarPanel.Name = "leftSidebarPanel";
            this.leftSidebarPanel.Size = new System.Drawing.Size(150, 491);
            this.leftSidebarPanel.TabIndex = 30;
            // 
            // rightContentPanel
            // 
            this.rightContentPanel.BackColor = System.Drawing.Color.White;
            this.rightContentPanel.Location = new System.Drawing.Point(175, 274);
            this.rightContentPanel.Name = "rightContentPanel";
            this.rightContentPanel.Size = new System.Drawing.Size(411, 300);
            this.rightContentPanel.TabIndex = 31;
            // 
            // btnAutoClick
            // 
            this.btnAutoClick.BackColor = System.Drawing.Color.Gray;
            this.btnAutoClick.FlatAppearance.BorderSize = 0;
            this.btnAutoClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoClick.ForeColor = System.Drawing.Color.White;
            this.btnAutoClick.Location = new System.Drawing.Point(5, 5);
            this.btnAutoClick.Name = "btnAutoClick";
            this.btnAutoClick.Size = new System.Drawing.Size(140, 25);
            this.btnAutoClick.TabIndex = 0;
            this.btnAutoClick.Text = "AutoClick";
            this.btnAutoClick.UseVisualStyleBackColor = false;
            this.btnAutoClick.Click += new System.EventHandler(this.btnAutoClick_Click);
            // 
            // btnSkillSpammer
            // 
            this.btnSkillSpammer.BackColor = System.Drawing.Color.Gray;
            this.btnSkillSpammer.FlatAppearance.BorderSize = 0;
            this.btnSkillSpammer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkillSpammer.ForeColor = System.Drawing.Color.White;
            this.btnSkillSpammer.Location = new System.Drawing.Point(5, 30);
            this.btnSkillSpammer.Name = "btnSkillSpammer";
            this.btnSkillSpammer.Size = new System.Drawing.Size(140, 25);
            this.btnSkillSpammer.TabIndex = 1;
            this.btnSkillSpammer.Text = "Skill Spammer";
            this.btnSkillSpammer.UseVisualStyleBackColor = false;
            this.btnSkillSpammer.Click += new System.EventHandler(this.btnSkillSpammer_Click);
            // 
            // btnDebuff
            // 
            this.btnDebuff.BackColor = System.Drawing.Color.Gray;
            this.btnDebuff.FlatAppearance.BorderSize = 0;
            this.btnDebuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebuff.ForeColor = System.Drawing.Color.White;
            this.btnDebuff.Location = new System.Drawing.Point(5, 55);
            this.btnDebuff.Name = "btnDebuff";
            this.btnDebuff.Size = new System.Drawing.Size(140, 25);
            this.btnDebuff.TabIndex = 2;
            this.btnDebuff.Text = "Debuff";
            this.btnDebuff.UseVisualStyleBackColor = false;
            this.btnDebuff.Click += new System.EventHandler(this.btnDebuff_Click);
            // 
            // btnAutobuffSkill
            // 
            this.btnAutobuffSkill.BackColor = System.Drawing.Color.Gray;
            this.btnAutobuffSkill.FlatAppearance.BorderSize = 0;
            this.btnAutobuffSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutobuffSkill.ForeColor = System.Drawing.Color.White;
            this.btnAutobuffSkill.Location = new System.Drawing.Point(5, 80);
            this.btnAutobuffSkill.Name = "btnAutobuffSkill";
            this.btnAutobuffSkill.Size = new System.Drawing.Size(140, 25);
            this.btnAutobuffSkill.TabIndex = 3;
            this.btnAutobuffSkill.Text = "Autobuff - Skills";
            this.btnAutobuffSkill.UseVisualStyleBackColor = false;
            this.btnAutobuffSkill.Click += new System.EventHandler(this.btnAutobuffSkill_Click);
            // 
            // btnAutobuffStuff
            // 
            this.btnAutobuffStuff.BackColor = System.Drawing.Color.Gray;
            this.btnAutobuffStuff.FlatAppearance.BorderSize = 0;
            this.btnAutobuffStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutobuffStuff.ForeColor = System.Drawing.Color.White;
            this.btnAutobuffStuff.Location = new System.Drawing.Point(5, 105);
            this.btnAutobuffStuff.Name = "btnAutobuffStuff";
            this.btnAutobuffStuff.Size = new System.Drawing.Size(140, 25);
            this.btnAutobuffStuff.TabIndex = 4;
            this.btnAutobuffStuff.Text = "Autobuff - Stuffs";
            this.btnAutobuffStuff.UseVisualStyleBackColor = false;
            this.btnAutobuffStuff.Click += new System.EventHandler(this.btnAutobuffStuff_Click);
            // 
            // btnSkillTimer
            // 
            this.btnSkillTimer.BackColor = System.Drawing.Color.Gray;
            this.btnSkillTimer.FlatAppearance.BorderSize = 0;
            this.btnSkillTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkillTimer.ForeColor = System.Drawing.Color.White;
            this.btnSkillTimer.Location = new System.Drawing.Point(5, 130);
            this.btnSkillTimer.Name = "btnSkillTimer";
            this.btnSkillTimer.Size = new System.Drawing.Size(140, 25);
            this.btnSkillTimer.TabIndex = 5;
            this.btnSkillTimer.Text = "Skill timers";
            this.btnSkillTimer.UseVisualStyleBackColor = false;
            this.btnSkillTimer.Click += new System.EventHandler(this.btnSkillTimer_Click);
            // 
            // btnMacroSwitch
            // 
            this.btnMacroSwitch.BackColor = System.Drawing.Color.Gray;
            this.btnMacroSwitch.FlatAppearance.BorderSize = 0;
            this.btnMacroSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacroSwitch.ForeColor = System.Drawing.Color.White;
            this.btnMacroSwitch.Location = new System.Drawing.Point(5, 155);
            this.btnMacroSwitch.Name = "btnMacroSwitch";
            this.btnMacroSwitch.Size = new System.Drawing.Size(140, 25);
            this.btnMacroSwitch.TabIndex = 6;
            this.btnMacroSwitch.Text = "Macro Switch";
            this.btnMacroSwitch.UseVisualStyleBackColor = false;
            this.btnMacroSwitch.Click += new System.EventHandler(this.btnMacroSwitch_Click);
            // 
            // btnMacroSongs
            // 
            this.btnMacroSongs.BackColor = System.Drawing.Color.Gray;
            this.btnMacroSongs.FlatAppearance.BorderSize = 0;
            this.btnMacroSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacroSongs.ForeColor = System.Drawing.Color.White;
            this.btnMacroSongs.Location = new System.Drawing.Point(5, 180);
            this.btnMacroSongs.Name = "btnMacroSongs";
            this.btnMacroSongs.Size = new System.Drawing.Size(140, 25);
            this.btnMacroSongs.TabIndex = 7;
            this.btnMacroSongs.Text = "Macro Songs";
            this.btnMacroSongs.UseVisualStyleBackColor = false;
            this.btnMacroSongs.Click += new System.EventHandler(this.btnMacroSongs_Click);
            // 
            // btnATKDEF
            // 
            this.btnATKDEF.BackColor = System.Drawing.Color.Gray;
            this.btnATKDEF.FlatAppearance.BorderSize = 0;
            this.btnATKDEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnATKDEF.ForeColor = System.Drawing.Color.White;
            this.btnATKDEF.Location = new System.Drawing.Point(5, 205);
            this.btnATKDEF.Name = "btnATKDEF";
            this.btnATKDEF.Size = new System.Drawing.Size(140, 25);
            this.btnATKDEF.TabIndex = 8;
            this.btnATKDEF.Text = "ATK x DEF Mode";
            this.btnATKDEF.UseVisualStyleBackColor = false;
            this.btnATKDEF.Click += new System.EventHandler(this.btnATKDEF_Click);
            // 
            // btnProfiles
            // 
            this.btnProfiles.BackColor = System.Drawing.Color.Gray;
            this.btnProfiles.FlatAppearance.BorderSize = 0;
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.ForeColor = System.Drawing.Color.White;
            this.btnProfiles.Location = new System.Drawing.Point(5, 230);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(140, 25);
            this.btnProfiles.TabIndex = 9;
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.UseVisualStyleBackColor = false;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // btnServers
            // 
            this.btnServers.BackColor = System.Drawing.Color.Gray;
            this.btnServers.FlatAppearance.BorderSize = 0;
            this.btnServers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServers.ForeColor = System.Drawing.Color.White;
            this.btnServers.Location = new System.Drawing.Point(5, 255);
            this.btnServers.Name = "btnServers";
            this.btnServers.Size = new System.Drawing.Size(140, 25);
            this.btnServers.TabIndex = 10;
            this.btnServers.Text = "Servers";
            this.btnServers.UseVisualStyleBackColor = false;
            this.btnServers.Click += new System.EventHandler(this.btnServers_Click);
            // 
            // tabDebuffRecovery
            // 
            this.tabDebuffRecovery.ImageIndex = 0;
            this.tabDebuffRecovery.Location = new System.Drawing.Point(4, 22);
            this.tabDebuffRecovery.Name = "tabDebuffRecovery";
            this.tabDebuffRecovery.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebuffRecovery.Size = new System.Drawing.Size(865, 274);
            this.tabDebuffRecovery.TabIndex = 2;
            this.tabDebuffRecovery.Text = "Debuff";
            this.tabDebuffRecovery.UseVisualStyleBackColor = true;
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.ForeColor = System.Drawing.Color.DarkGreen;
            this.characterName.Location = new System.Drawing.Point(335, 215);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(25, 17);
            this.characterName.TabIndex = 28;
            this.characterName.Text = "- -";
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterName.Location = new System.Drawing.Point(335, 198);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(115, 17);
            this.lblCharacterName.TabIndex = 27;
            this.lblCharacterName.Text = "Character Name:";
            // 
            // OnOffPanel
            // 
            this.OnOffPanel.Location = new System.Drawing.Point(335, 83);
            this.OnOffPanel.Name = "OnOffPanel";
            this.OnOffPanel.Size = new System.Drawing.Size(223, 112);
            this.OnOffPanel.TabIndex = 29;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 624);
            this.Controls.Add(this.rightContentPanel);
            this.Controls.Add(this.leftSidebarPanel);
            this.Controls.Add(this.OnOffPanel);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.tabControlAutopot);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.profileCB);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.processCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4ROTools - Versão Beta";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Container_Load);
            this.Resize += new System.EventHandler(this.containerResize);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.tabControlAutopot.ResumeLayout(false);
            this.leftSidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.LinkLabel lblLinkDiscord;
        private System.Windows.Forms.Panel panelDiscImage;
        private System.Windows.Forms.Label labelProfile;
        public System.Windows.Forms.ComboBox profileCB;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Panel panel5;
        private TabControl tabControlAutopot;
        private TabPage tabPageAutopot;
        private TabPage tabPageYggAutopot;
        private ImageList TabControlImageList;
        private TabPage tabPageServer;
        private TabPage tabPageProfiles;
        private TabPage tabMacroSwitch;
        private TabPage atkDef;
        private TabPage tabPageMacroSongs;
        private TabPage tabPageCustom;
        private TabPage tabPageAutobuffStuff;
        private TabPage tabPageAutobuffSkill;
        private TabPage tabPageSpammer;
        private TabControl atkDefMode;
        private Label characterName;
        private Label lblCharacterName;
        private TabPage tabDebuffRecovery;
        private Panel OnOffPanel;
        private TabPage tabSkillTimer;
        private Label lbPowered;
        private Panel leftSidebarPanel;
        private Panel rightContentPanel;
        private Button btnAutoClick;
        private Button btnSkillSpammer;
        private Button btnDebuff;
        private Button btnAutobuffSkill;
        private Button btnAutobuffStuff;
        private Button btnSkillTimer;
        private Button btnMacroSwitch;
        private Button btnMacroSongs;
        private Button btnATKDEF;
        private Button btnProfiles;
        private Button btnServers;
    }
}