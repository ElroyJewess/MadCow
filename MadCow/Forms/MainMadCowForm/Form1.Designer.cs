﻿namespace MadCow
{
    partial class Form1
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
                this.MadCowTrayIcon.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayDiabloButton = new System.Windows.Forms.Button();
            this.LaunchServerButton = new System.Windows.Forms.Button();
            this.RemoteServerLaunchButton = new System.Windows.Forms.Button();
            this.RemoteServerTab = new System.Windows.Forms.TabPage();
            this.RemoteServerTip = new System.Windows.Forms.Label();
            this.RemoteServerGrpBox = new System.Windows.Forms.GroupBox();
            this.RemoteServerTip2 = new System.Windows.Forms.Label();
            this.RemotePort = new System.Windows.Forms.Label();
            this.RemoteHost = new System.Windows.Forms.Label();
            this.remotePortTxtBox = new System.Windows.Forms.TextBox();
            this.remoteHostTxtBox = new System.Windows.Forms.TextBox();
            this.ServerControlTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TickGameServerPort = new System.Windows.Forms.PictureBox();
            this.TickBnetServerPort = new System.Windows.Forms.PictureBox();
            this.TickPublicServerIp = new System.Windows.Forms.PictureBox();
            this.TickGameServerIp = new System.Windows.Forms.PictureBox();
            this.TickBnetServerIP = new System.Windows.Forms.PictureBox();
            this.ErrorGameServerPort = new System.Windows.Forms.PictureBox();
            this.ErrorBnetServerPort = new System.Windows.Forms.PictureBox();
            this.ErrorPublicServerIp = new System.Windows.Forms.PictureBox();
            this.ErrorGameServerIp = new System.Windows.Forms.PictureBox();
            this.ErrorBnetServerIp = new System.Windows.Forms.PictureBox();
            this.loadProfileButton = new System.Windows.Forms.Button();
            this.saveProfileButton = new System.Windows.Forms.Button();
            this.MotdTxtBox = new System.Windows.Forms.TextBox();
            this.MotdLabel = new System.Windows.Forms.Label();
            this.RestoreDefaultsLabel = new System.Windows.Forms.LinkLabel();
            this.NATcheckBox = new System.Windows.Forms.CheckBox();
            this.PublicServerIpLabel = new System.Windows.Forms.Label();
            this.PublicServerIp = new System.Windows.Forms.TextBox();
            this.GameServerPortLabel = new System.Windows.Forms.Label();
            this.GameServerIpLabel = new System.Windows.Forms.Label();
            this.GameServerPort = new System.Windows.Forms.TextBox();
            this.GameServerIp = new System.Windows.Forms.TextBox();
            this.BnetServerPortLabel = new System.Windows.Forms.Label();
            this.BnetServerIpLabel = new System.Windows.Forms.Label();
            this.BnetServerPort = new System.Windows.Forms.TextBox();
            this.BnetServerIp = new System.Windows.Forms.TextBox();
            this.UpdatesTab = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.BrowseMPQPathButton = new System.Windows.Forms.Button();
            this.MPQDestTextBox = new System.Windows.Forms.TextBox();
            this.AutoUpdateTimerLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repoComboBox = new System.Windows.Forms.ComboBox();
            this.RepositoryHintLabel = new System.Windows.Forms.Label();
            this.FindDiabloButton = new System.Windows.Forms.Button();
            this.UpdateMooegeButton = new System.Windows.Forms.Button();
            this.CopyMPQButton = new System.Windows.Forms.Button();
            this.Diablo3UserPathSelection = new System.Windows.Forms.TextBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.HelpTab = new System.Windows.Forms.TabPage();
            this.DownloadNetLabel = new System.Windows.Forms.LinkLabel();
            this.ProblemsCompilingLabel = new System.Windows.Forms.Label();
            this.AutoUpdateMadcowLabel = new System.Windows.Forms.Label();
            this.UpdateMadcowButton = new System.Windows.Forms.Button();
            this.DownloadSpeedLabel = new System.Windows.Forms.Label();
            this.DownloadFileNameLabel = new System.Windows.Forms.Label();
            this.DownloadMPQSprogressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadMpqLabel = new System.Windows.Forms.Label();
            this.DownloadMPQSButton = new System.Windows.Forms.Button();
            this.ResetMooegeReposLabel = new System.Windows.Forms.Label();
            this.ResetRepoFolder = new System.Windows.Forms.Button();
            this.DownloadSpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.DiabloPathFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.ConsoleOutputTxtBox = new System.Windows.Forms.TextBox();
            this.VerifyDiablo3Version = new System.ComponentModel.BackgroundWorker();
            this.DownloadSelectedMpqs = new System.ComponentModel.BackgroundWorker();
            this.ErrorFilesDownloaders = new System.ComponentModel.BackgroundWorker();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.OutPutTab = new System.Windows.Forms.TabPage();
            this.ChaneglogTab = new System.Windows.Forms.TabPage();
            this.changeLogTreeView = new System.Windows.Forms.TreeView();
            this.SelectRepositoryChngLogLabel = new System.Windows.Forms.Label();
            this.SelectRepoChngLogComboBox = new System.Windows.Forms.ComboBox();
            this.LiveHelpTab = new System.Windows.Forms.TabPage();
            this.ircRulesLabel = new System.Windows.Forms.Label();
            this.ircNicknameLabel = new System.Windows.Forms.Label();
            this.ircNicknameTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ircIntroLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TypeHereLabel = new System.Windows.Forms.Label();
            this.ChatMessageBox = new System.Windows.Forms.TextBox();
            this.ChatUsersBox = new System.Windows.Forms.TextBox();
            this.ChatDisplayBox = new System.Windows.Forms.TextBox();
            this.MadCowTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MpqPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madCowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableTrayNotificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileAsDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mooegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableFileLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enablePacketLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableLazyLoadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableNoPasswordCheckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.RemoteServerTab.SuspendLayout();
            this.RemoteServerGrpBox.SuspendLayout();
            this.ServerControlTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TickGameServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickBnetServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickPublicServerIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickGameServerIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickBnetServerIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGameServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBnetServerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPublicServerIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGameServerIp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBnetServerIp)).BeginInit();
            this.UpdatesTab.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.HelpTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.OutPutTab.SuspendLayout();
            this.ChaneglogTab.SuspendLayout();
            this.LiveHelpTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayDiabloButton
            // 
            this.PlayDiabloButton.BackColor = System.Drawing.Color.Transparent;
            this.PlayDiabloButton.Enabled = false;
            this.PlayDiabloButton.Location = new System.Drawing.Point(9, 286);
            this.PlayDiabloButton.Name = "PlayDiabloButton";
            this.PlayDiabloButton.Size = new System.Drawing.Size(327, 42);
            this.PlayDiabloButton.TabIndex = 7;
            this.PlayDiabloButton.Text = "Play Diablo (Local)";
            this.PlayDiabloButton.UseVisualStyleBackColor = false;
            this.PlayDiabloButton.Click += new System.EventHandler(this.PlayDiablo_Click);
            // 
            // LaunchServerButton
            // 
            this.LaunchServerButton.Location = new System.Drawing.Point(6, 279);
            this.LaunchServerButton.Name = "LaunchServerButton";
            this.LaunchServerButton.Size = new System.Drawing.Size(327, 43);
            this.LaunchServerButton.TabIndex = 9;
            this.LaunchServerButton.Text = "Launch Server Only";
            this.LaunchServerButton.UseVisualStyleBackColor = true;
            this.LaunchServerButton.Click += new System.EventHandler(this.LaunchServer_Click);
            // 
            // RemoteServerLaunchButton
            // 
            this.RemoteServerLaunchButton.BackColor = System.Drawing.Color.White;
            this.RemoteServerLaunchButton.Enabled = false;
            this.RemoteServerLaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RemoteServerLaunchButton.Location = new System.Drawing.Point(101, 95);
            this.RemoteServerLaunchButton.Name = "RemoteServerLaunchButton";
            this.RemoteServerLaunchButton.Size = new System.Drawing.Size(141, 46);
            this.RemoteServerLaunchButton.TabIndex = 14;
            this.RemoteServerLaunchButton.Text = "Play on Remote Server";
            this.ToolTips.SetToolTip(this.RemoteServerLaunchButton, "Play on a server hosted elsewhere.");
            this.RemoteServerLaunchButton.UseVisualStyleBackColor = false;
            this.RemoteServerLaunchButton.Click += new System.EventHandler(this.RemoteServer_Click);
            // 
            // RemoteServerTab
            // 
            this.RemoteServerTab.BackColor = System.Drawing.Color.White;
            this.RemoteServerTab.Controls.Add(this.RemoteServerTip);
            this.RemoteServerTab.Controls.Add(this.RemoteServerGrpBox);
            this.RemoteServerTab.Controls.Add(this.RemoteServerLaunchButton);
            this.RemoteServerTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoteServerTab.Location = new System.Drawing.Point(4, 22);
            this.RemoteServerTab.Name = "RemoteServerTab";
            this.RemoteServerTab.Padding = new System.Windows.Forms.Padding(3);
            this.RemoteServerTab.Size = new System.Drawing.Size(345, 334);
            this.RemoteServerTab.TabIndex = 3;
            this.RemoteServerTab.Text = "Remote Server";
            // 
            // RemoteServerTip
            // 
            this.RemoteServerTip.AutoSize = true;
            this.RemoteServerTip.Location = new System.Drawing.Point(54, 153);
            this.RemoteServerTip.Name = "RemoteServerTip";
            this.RemoteServerTip.Size = new System.Drawing.Size(225, 13);
            this.RemoteServerTip.TabIndex = 15;
            this.RemoteServerTip.Text = "To Activate, Add Diablo Path on Updates Tab";
            // 
            // RemoteServerGrpBox
            // 
            this.RemoteServerGrpBox.Controls.Add(this.RemoteServerTip2);
            this.RemoteServerGrpBox.Controls.Add(this.RemotePort);
            this.RemoteServerGrpBox.Controls.Add(this.RemoteHost);
            this.RemoteServerGrpBox.Controls.Add(this.remotePortTxtBox);
            this.RemoteServerGrpBox.Controls.Add(this.remoteHostTxtBox);
            this.RemoteServerGrpBox.Location = new System.Drawing.Point(5, 6);
            this.RemoteServerGrpBox.Name = "RemoteServerGrpBox";
            this.RemoteServerGrpBox.Size = new System.Drawing.Size(332, 83);
            this.RemoteServerGrpBox.TabIndex = 1;
            this.RemoteServerGrpBox.TabStop = false;
            this.RemoteServerGrpBox.Text = "Remote Server";
            // 
            // RemoteServerTip2
            // 
            this.RemoteServerTip2.AutoSize = true;
            this.RemoteServerTip2.Location = new System.Drawing.Point(6, 16);
            this.RemoteServerTip2.Name = "RemoteServerTip2";
            this.RemoteServerTip2.Size = new System.Drawing.Size(239, 13);
            this.RemoteServerTip2.TabIndex = 15;
            this.RemoteServerTip2.Text = "This is to connect to server on another computer.";
            // 
            // RemotePort
            // 
            this.RemotePort.AutoSize = true;
            this.RemotePort.Location = new System.Drawing.Point(220, 41);
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(69, 13);
            this.RemotePort.TabIndex = 3;
            this.RemotePort.Text = "Remote Port:";
            // 
            // RemoteHost
            // 
            this.RemoteHost.AutoSize = true;
            this.RemoteHost.Location = new System.Drawing.Point(1, 41);
            this.RemoteHost.Name = "RemoteHost";
            this.RemoteHost.Size = new System.Drawing.Size(72, 13);
            this.RemoteHost.TabIndex = 2;
            this.RemoteHost.Text = "Remote Host:";
            // 
            // remotePortTxtBox
            // 
            this.remotePortTxtBox.Enabled = false;
            this.remotePortTxtBox.Location = new System.Drawing.Point(223, 57);
            this.remotePortTxtBox.Name = "remotePortTxtBox";
            this.remotePortTxtBox.Size = new System.Drawing.Size(100, 20);
            this.remotePortTxtBox.TabIndex = 1;
            this.remotePortTxtBox.Text = "1345";
            // 
            // remoteHostTxtBox
            // 
            this.remoteHostTxtBox.Enabled = false;
            this.remoteHostTxtBox.Location = new System.Drawing.Point(3, 57);
            this.remoteHostTxtBox.Name = "remoteHostTxtBox";
            this.remoteHostTxtBox.Size = new System.Drawing.Size(197, 20);
            this.remoteHostTxtBox.TabIndex = 0;
            this.remoteHostTxtBox.Text = "0.0.0.0";
            // 
            // ServerControlTab
            // 
            this.ServerControlTab.BackColor = System.Drawing.Color.White;
            this.ServerControlTab.Controls.Add(this.groupBox5);
            this.ServerControlTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerControlTab.Location = new System.Drawing.Point(4, 22);
            this.ServerControlTab.Name = "ServerControlTab";
            this.ServerControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.ServerControlTab.Size = new System.Drawing.Size(345, 334);
            this.ServerControlTab.TabIndex = 2;
            this.ServerControlTab.Text = "Server Control";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TickGameServerPort);
            this.groupBox5.Controls.Add(this.TickBnetServerPort);
            this.groupBox5.Controls.Add(this.TickPublicServerIp);
            this.groupBox5.Controls.Add(this.TickGameServerIp);
            this.groupBox5.Controls.Add(this.TickBnetServerIP);
            this.groupBox5.Controls.Add(this.ErrorGameServerPort);
            this.groupBox5.Controls.Add(this.ErrorBnetServerPort);
            this.groupBox5.Controls.Add(this.ErrorPublicServerIp);
            this.groupBox5.Controls.Add(this.ErrorGameServerIp);
            this.groupBox5.Controls.Add(this.ErrorBnetServerIp);
            this.groupBox5.Controls.Add(this.loadProfileButton);
            this.groupBox5.Controls.Add(this.saveProfileButton);
            this.groupBox5.Controls.Add(this.MotdTxtBox);
            this.groupBox5.Controls.Add(this.MotdLabel);
            this.groupBox5.Controls.Add(this.RestoreDefaultsLabel);
            this.groupBox5.Controls.Add(this.LaunchServerButton);
            this.groupBox5.Controls.Add(this.NATcheckBox);
            this.groupBox5.Controls.Add(this.PublicServerIpLabel);
            this.groupBox5.Controls.Add(this.PublicServerIp);
            this.groupBox5.Controls.Add(this.GameServerPortLabel);
            this.groupBox5.Controls.Add(this.GameServerIpLabel);
            this.groupBox5.Controls.Add(this.GameServerPort);
            this.groupBox5.Controls.Add(this.GameServerIp);
            this.groupBox5.Controls.Add(this.BnetServerPortLabel);
            this.groupBox5.Controls.Add(this.BnetServerIpLabel);
            this.groupBox5.Controls.Add(this.BnetServerPort);
            this.groupBox5.Controls.Add(this.BnetServerIp);
            this.groupBox5.Location = new System.Drawing.Point(3, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(339, 325);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Server Configuration";
            // 
            // TickGameServerPort
            // 
            this.TickGameServerPort.Image = global::MadCow.Properties.Resources.green_tick;
            this.TickGameServerPort.Location = new System.Drawing.Point(318, 80);
            this.TickGameServerPort.Name = "TickGameServerPort";
            this.TickGameServerPort.Size = new System.Drawing.Size(15, 16);
            this.TickGameServerPort.TabIndex = 25;
            this.TickGameServerPort.TabStop = false;
            this.TickGameServerPort.Visible = false;
            // 
            // TickBnetServerPort
            // 
            this.TickBnetServerPort.Image = global::MadCow.Properties.Resources.green_tick;
            this.TickBnetServerPort.Location = new System.Drawing.Point(318, 31);
            this.TickBnetServerPort.Name = "TickBnetServerPort";
            this.TickBnetServerPort.Size = new System.Drawing.Size(15, 16);
            this.TickBnetServerPort.TabIndex = 24;
            this.TickBnetServerPort.TabStop = false;
            this.TickBnetServerPort.Visible = false;
            // 
            // TickPublicServerIp
            // 
            this.TickPublicServerIp.Image = global::MadCow.Properties.Resources.green_tick;
            this.TickPublicServerIp.Location = new System.Drawing.Point(207, 132);
            this.TickPublicServerIp.Name = "TickPublicServerIp";
            this.TickPublicServerIp.Size = new System.Drawing.Size(15, 16);
            this.TickPublicServerIp.TabIndex = 23;
            this.TickPublicServerIp.TabStop = false;
            this.TickPublicServerIp.Visible = false;
            // 
            // TickGameServerIp
            // 
            this.TickGameServerIp.Image = global::MadCow.Properties.Resources.green_tick;
            this.TickGameServerIp.Location = new System.Drawing.Point(207, 81);
            this.TickGameServerIp.Name = "TickGameServerIp";
            this.TickGameServerIp.Size = new System.Drawing.Size(15, 16);
            this.TickGameServerIp.TabIndex = 22;
            this.TickGameServerIp.TabStop = false;
            this.TickGameServerIp.Visible = false;
            // 
            // TickBnetServerIP
            // 
            this.TickBnetServerIP.Image = global::MadCow.Properties.Resources.green_tick;
            this.TickBnetServerIP.Location = new System.Drawing.Point(207, 30);
            this.TickBnetServerIP.Name = "TickBnetServerIP";
            this.TickBnetServerIP.Size = new System.Drawing.Size(15, 16);
            this.TickBnetServerIP.TabIndex = 21;
            this.TickBnetServerIP.TabStop = false;
            this.TickBnetServerIP.Visible = false;
            // 
            // ErrorGameServerPort
            // 
            this.ErrorGameServerPort.Image = global::MadCow.Properties.Resources.error_cross;
            this.ErrorGameServerPort.Location = new System.Drawing.Point(318, 81);
            this.ErrorGameServerPort.Name = "ErrorGameServerPort";
            this.ErrorGameServerPort.Size = new System.Drawing.Size(15, 15);
            this.ErrorGameServerPort.TabIndex = 20;
            this.ErrorGameServerPort.TabStop = false;
            this.ErrorGameServerPort.Visible = false;
            // 
            // ErrorBnetServerPort
            // 
            this.ErrorBnetServerPort.Image = global::MadCow.Properties.Resources.error_cross;
            this.ErrorBnetServerPort.Location = new System.Drawing.Point(318, 31);
            this.ErrorBnetServerPort.Name = "ErrorBnetServerPort";
            this.ErrorBnetServerPort.Size = new System.Drawing.Size(15, 15);
            this.ErrorBnetServerPort.TabIndex = 19;
            this.ErrorBnetServerPort.TabStop = false;
            this.ErrorBnetServerPort.Visible = false;
            // 
            // ErrorPublicServerIp
            // 
            this.ErrorPublicServerIp.Image = global::MadCow.Properties.Resources.error_cross;
            this.ErrorPublicServerIp.Location = new System.Drawing.Point(207, 133);
            this.ErrorPublicServerIp.Name = "ErrorPublicServerIp";
            this.ErrorPublicServerIp.Size = new System.Drawing.Size(15, 15);
            this.ErrorPublicServerIp.TabIndex = 18;
            this.ErrorPublicServerIp.TabStop = false;
            this.ErrorPublicServerIp.Visible = false;
            // 
            // ErrorGameServerIp
            // 
            this.ErrorGameServerIp.Image = global::MadCow.Properties.Resources.error_cross;
            this.ErrorGameServerIp.Location = new System.Drawing.Point(207, 82);
            this.ErrorGameServerIp.Name = "ErrorGameServerIp";
            this.ErrorGameServerIp.Size = new System.Drawing.Size(15, 15);
            this.ErrorGameServerIp.TabIndex = 17;
            this.ErrorGameServerIp.TabStop = false;
            this.ErrorGameServerIp.Visible = false;
            // 
            // ErrorBnetServerIp
            // 
            this.ErrorBnetServerIp.Image = global::MadCow.Properties.Resources.error_cross;
            this.ErrorBnetServerIp.Location = new System.Drawing.Point(207, 31);
            this.ErrorBnetServerIp.Name = "ErrorBnetServerIp";
            this.ErrorBnetServerIp.Size = new System.Drawing.Size(15, 15);
            this.ErrorBnetServerIp.TabIndex = 16;
            this.ErrorBnetServerIp.TabStop = false;
            this.ErrorBnetServerIp.Visible = false;
            // 
            // loadProfileButton
            // 
            this.loadProfileButton.Location = new System.Drawing.Point(109, 220);
            this.loadProfileButton.Name = "loadProfileButton";
            this.loadProfileButton.Size = new System.Drawing.Size(75, 42);
            this.loadProfileButton.TabIndex = 15;
            this.loadProfileButton.Text = "Load Profile";
            this.loadProfileButton.UseVisualStyleBackColor = true;
            this.loadProfileButton.Click += new System.EventHandler(this.LoadProfile_Click);
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.Location = new System.Drawing.Point(11, 220);
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(75, 42);
            this.saveProfileButton.TabIndex = 14;
            this.saveProfileButton.Text = "Save Profile";
            this.saveProfileButton.UseVisualStyleBackColor = true;
            this.saveProfileButton.Click += new System.EventHandler(this.SaveProfile_Click);
            // 
            // MotdTxtBox
            // 
            this.MotdTxtBox.Location = new System.Drawing.Point(11, 183);
            this.MotdTxtBox.Name = "MotdTxtBox";
            this.MotdTxtBox.Size = new System.Drawing.Size(322, 20);
            this.MotdTxtBox.TabIndex = 12;
            this.MotdTxtBox.Text = "Welcome to mooege development server!";
            // 
            // MotdLabel
            // 
            this.MotdLabel.AutoSize = true;
            this.MotdLabel.Location = new System.Drawing.Point(8, 167);
            this.MotdLabel.Name = "MotdLabel";
            this.MotdLabel.Size = new System.Drawing.Size(39, 13);
            this.MotdLabel.TabIndex = 13;
            this.MotdLabel.Text = "MOTD";
            // 
            // RestoreDefaultsLabel
            // 
            this.RestoreDefaultsLabel.AutoSize = true;
            this.RestoreDefaultsLabel.LinkColor = System.Drawing.Color.DimGray;
            this.RestoreDefaultsLabel.Location = new System.Drawing.Point(247, 206);
            this.RestoreDefaultsLabel.Name = "RestoreDefaultsLabel";
            this.RestoreDefaultsLabel.Size = new System.Drawing.Size(86, 13);
            this.RestoreDefaultsLabel.TabIndex = 11;
            this.RestoreDefaultsLabel.TabStop = true;
            this.RestoreDefaultsLabel.Text = "Restore Defaults";
            this.RestoreDefaultsLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RestoreDefault_LinkClicked);
            // 
            // NATcheckBox
            // 
            this.NATcheckBox.AutoSize = true;
            this.NATcheckBox.Location = new System.Drawing.Point(230, 133);
            this.NATcheckBox.Name = "NATcheckBox";
            this.NATcheckBox.Size = new System.Drawing.Size(90, 17);
            this.NATcheckBox.TabIndex = 10;
            this.NATcheckBox.Text = "NAT Enabled";
            this.NATcheckBox.UseVisualStyleBackColor = true;
            // 
            // PublicServerIpLabel
            // 
            this.PublicServerIpLabel.AutoSize = true;
            this.PublicServerIpLabel.Location = new System.Drawing.Point(6, 117);
            this.PublicServerIpLabel.Name = "PublicServerIpLabel";
            this.PublicServerIpLabel.Size = new System.Drawing.Size(86, 13);
            this.PublicServerIpLabel.TabIndex = 9;
            this.PublicServerIpLabel.Text = "Public Server IP:";
            // 
            // PublicServerIp
            // 
            this.PublicServerIp.Location = new System.Drawing.Point(11, 133);
            this.PublicServerIp.Name = "PublicServerIp";
            this.PublicServerIp.Size = new System.Drawing.Size(196, 20);
            this.PublicServerIp.TabIndex = 8;
            this.PublicServerIp.Text = "0.0.0.0";
            this.PublicServerIp.TextChanged += new System.EventHandler(this.PublicServerIp_TextChanged);
            // 
            // GameServerPortLabel
            // 
            this.GameServerPortLabel.AutoSize = true;
            this.GameServerPortLabel.Location = new System.Drawing.Point(227, 66);
            this.GameServerPortLabel.Name = "GameServerPortLabel";
            this.GameServerPortLabel.Size = new System.Drawing.Size(94, 13);
            this.GameServerPortLabel.TabIndex = 7;
            this.GameServerPortLabel.Text = "Game Server Port:";
            // 
            // GameServerIpLabel
            // 
            this.GameServerIpLabel.AutoSize = true;
            this.GameServerIpLabel.Location = new System.Drawing.Point(8, 66);
            this.GameServerIpLabel.Name = "GameServerIpLabel";
            this.GameServerIpLabel.Size = new System.Drawing.Size(85, 13);
            this.GameServerIpLabel.TabIndex = 6;
            this.GameServerIpLabel.Text = "Game Server IP:";
            // 
            // GameServerPort
            // 
            this.GameServerPort.Location = new System.Drawing.Point(230, 81);
            this.GameServerPort.Name = "GameServerPort";
            this.GameServerPort.Size = new System.Drawing.Size(83, 20);
            this.GameServerPort.TabIndex = 5;
            this.GameServerPort.Text = "1999";
            this.GameServerPort.TextChanged += new System.EventHandler(this.GameServerPort_TextChanged);
            // 
            // GameServerIp
            // 
            this.GameServerIp.Location = new System.Drawing.Point(11, 82);
            this.GameServerIp.Name = "GameServerIp";
            this.GameServerIp.Size = new System.Drawing.Size(196, 20);
            this.GameServerIp.TabIndex = 4;
            this.GameServerIp.Text = "0.0.0.0";
            this.GameServerIp.TextChanged += new System.EventHandler(this.GameServerIp_TextChanged);
            // 
            // BnetServerPortLabel
            // 
            this.BnetServerPortLabel.AutoSize = true;
            this.BnetServerPortLabel.Location = new System.Drawing.Point(225, 16);
            this.BnetServerPortLabel.Name = "BnetServerPortLabel";
            this.BnetServerPortLabel.Size = new System.Drawing.Size(88, 13);
            this.BnetServerPortLabel.TabIndex = 3;
            this.BnetServerPortLabel.Text = "Bnet Server Port:";
            // 
            // BnetServerIpLabel
            // 
            this.BnetServerIpLabel.AutoSize = true;
            this.BnetServerIpLabel.Location = new System.Drawing.Point(8, 15);
            this.BnetServerIpLabel.Name = "BnetServerIpLabel";
            this.BnetServerIpLabel.Size = new System.Drawing.Size(79, 13);
            this.BnetServerIpLabel.TabIndex = 2;
            this.BnetServerIpLabel.Text = "Bnet Server IP:";
            // 
            // BnetServerPort
            // 
            this.BnetServerPort.Location = new System.Drawing.Point(228, 31);
            this.BnetServerPort.Name = "BnetServerPort";
            this.BnetServerPort.Size = new System.Drawing.Size(85, 20);
            this.BnetServerPort.TabIndex = 1;
            this.BnetServerPort.Text = "1345";
            this.BnetServerPort.TextChanged += new System.EventHandler(this.BnetServerPort_TextChanged);
            // 
            // BnetServerIp
            // 
            this.BnetServerIp.Location = new System.Drawing.Point(11, 31);
            this.BnetServerIp.Name = "BnetServerIp";
            this.BnetServerIp.Size = new System.Drawing.Size(196, 20);
            this.BnetServerIp.TabIndex = 0;
            this.BnetServerIp.Text = "0.0.0.0";
            this.BnetServerIp.TextChanged += new System.EventHandler(this.BnetServerIp_TextChanged);
            // 
            // UpdatesTab
            // 
            this.UpdatesTab.BackColor = System.Drawing.Color.White;
            this.UpdatesTab.Controls.Add(this.groupBox8);
            this.UpdatesTab.Controls.Add(this.AutoUpdateTimerLabel);
            this.UpdatesTab.Controls.Add(this.groupBox1);
            this.UpdatesTab.Controls.Add(this.FindDiabloButton);
            this.UpdatesTab.Controls.Add(this.PlayDiabloButton);
            this.UpdatesTab.Controls.Add(this.UpdateMooegeButton);
            this.UpdatesTab.Controls.Add(this.CopyMPQButton);
            this.UpdatesTab.Controls.Add(this.Diablo3UserPathSelection);
            this.UpdatesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdatesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatesTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdatesTab.Location = new System.Drawing.Point(4, 22);
            this.UpdatesTab.Name = "UpdatesTab";
            this.UpdatesTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdatesTab.Size = new System.Drawing.Size(345, 334);
            this.UpdatesTab.TabIndex = 1;
            this.UpdatesTab.Text = "Updates";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.BrowseMPQPathButton);
            this.groupBox8.Controls.Add(this.MPQDestTextBox);
            this.groupBox8.Location = new System.Drawing.Point(6, 80);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(333, 54);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "MPQ Destination";
            // 
            // BrowseMPQPathButton
            // 
            this.BrowseMPQPathButton.Location = new System.Drawing.Point(303, 17);
            this.BrowseMPQPathButton.Name = "BrowseMPQPathButton";
            this.BrowseMPQPathButton.Size = new System.Drawing.Size(24, 23);
            this.BrowseMPQPathButton.TabIndex = 1;
            this.BrowseMPQPathButton.Text = "...";
            this.BrowseMPQPathButton.UseVisualStyleBackColor = true;
            this.BrowseMPQPathButton.Click += new System.EventHandler(this.BrowseMPQPathButton_Click);
            // 
            // MPQDestTextBox
            // 
            this.MPQDestTextBox.Location = new System.Drawing.Point(6, 19);
            this.MPQDestTextBox.Name = "MPQDestTextBox";
            this.MPQDestTextBox.ReadOnly = true;
            this.MPQDestTextBox.Size = new System.Drawing.Size(291, 20);
            this.MPQDestTextBox.TabIndex = 0;
            // 
            // AutoUpdateTimerLabel
            // 
            this.AutoUpdateTimerLabel.AutoSize = true;
            this.AutoUpdateTimerLabel.Location = new System.Drawing.Point(120, 237);
            this.AutoUpdateTimerLabel.Name = "AutoUpdateTimerLabel";
            this.AutoUpdateTimerLabel.Size = new System.Drawing.Size(0, 13);
            this.AutoUpdateTimerLabel.TabIndex = 14;
            this.AutoUpdateTimerLabel.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repoComboBox);
            this.groupBox1.Controls.Add(this.RepositoryHintLabel);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Repository";
            // 
            // repoComboBox
            // 
            this.repoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repoComboBox.Location = new System.Drawing.Point(6, 18);
            this.repoComboBox.Name = "repoComboBox";
            this.repoComboBox.Size = new System.Drawing.Size(201, 21);
            this.repoComboBox.TabIndex = 17;
            this.repoComboBox.DropDown += new System.EventHandler(this.repoComboBox_DropDown);
            this.repoComboBox.SelectedIndexChanged += new System.EventHandler(this.repoComboBox_SelectedIndexChanged);
            // 
            // RepositoryHintLabel
            // 
            this.RepositoryHintLabel.AutoSize = true;
            this.RepositoryHintLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RepositoryHintLabel.Location = new System.Drawing.Point(5, 42);
            this.RepositoryHintLabel.Name = "RepositoryHintLabel";
            this.RepositoryHintLabel.Size = new System.Drawing.Size(205, 13);
            this.RepositoryHintLabel.TabIndex = 13;
            this.RepositoryHintLabel.Text = "Download more with the button at the top.";
            this.RepositoryHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FindDiabloButton
            // 
            this.FindDiabloButton.Location = new System.Drawing.Point(263, 184);
            this.FindDiabloButton.Name = "FindDiabloButton";
            this.FindDiabloButton.Size = new System.Drawing.Size(75, 20);
            this.FindDiabloButton.TabIndex = 4;
            this.FindDiabloButton.Text = "Find Diablo3";
            this.FindDiabloButton.UseVisualStyleBackColor = true;
            this.FindDiabloButton.Click += new System.EventHandler(this.FindDiablo_Click);
            // 
            // UpdateMooegeButton
            // 
            this.UpdateMooegeButton.Enabled = false;
            this.UpdateMooegeButton.Location = new System.Drawing.Point(42, 221);
            this.UpdateMooegeButton.Name = "UpdateMooegeButton";
            this.UpdateMooegeButton.Size = new System.Drawing.Size(100, 44);
            this.UpdateMooegeButton.TabIndex = 17;
            this.UpdateMooegeButton.Text = "Update Mooege";
            this.UpdateMooegeButton.UseVisualStyleBackColor = true;
            this.UpdateMooegeButton.Click += new System.EventHandler(this.Update_Mooege_Click);
            // 
            // CopyMPQButton
            // 
            this.CopyMPQButton.Enabled = false;
            this.CopyMPQButton.Location = new System.Drawing.Point(191, 221);
            this.CopyMPQButton.Name = "CopyMPQButton";
            this.CopyMPQButton.Size = new System.Drawing.Size(100, 44);
            this.CopyMPQButton.TabIndex = 18;
            this.CopyMPQButton.Text = "Copy MPQ\'s";
            this.CopyMPQButton.UseVisualStyleBackColor = true;
            this.CopyMPQButton.Click += new System.EventHandler(this.CopyMPQs_Click);
            // 
            // Diablo3UserPathSelection
            // 
            this.Diablo3UserPathSelection.Location = new System.Drawing.Point(9, 184);
            this.Diablo3UserPathSelection.Name = "Diablo3UserPathSelection";
            this.Diablo3UserPathSelection.ReadOnly = true;
            this.Diablo3UserPathSelection.Size = new System.Drawing.Size(248, 20);
            this.Diablo3UserPathSelection.TabIndex = 3;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.UpdatesTab);
            this.Tabs.Controls.Add(this.ServerControlTab);
            this.Tabs.Controls.Add(this.RemoteServerTab);
            this.Tabs.Controls.Add(this.HelpTab);
            this.Tabs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tabs.HotTrack = true;
            this.Tabs.Location = new System.Drawing.Point(3, 3);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(353, 360);
            this.Tabs.TabIndex = 13;
            // 
            // HelpTab
            // 
            this.HelpTab.BackColor = System.Drawing.Color.White;
            this.HelpTab.Controls.Add(this.DownloadNetLabel);
            this.HelpTab.Controls.Add(this.ProblemsCompilingLabel);
            this.HelpTab.Controls.Add(this.AutoUpdateMadcowLabel);
            this.HelpTab.Controls.Add(this.UpdateMadcowButton);
            this.HelpTab.Controls.Add(this.DownloadSpeedLabel);
            this.HelpTab.Controls.Add(this.DownloadFileNameLabel);
            this.HelpTab.Controls.Add(this.DownloadMPQSprogressBar);
            this.HelpTab.Controls.Add(this.DownloadMpqLabel);
            this.HelpTab.Controls.Add(this.DownloadMPQSButton);
            this.HelpTab.Controls.Add(this.ResetMooegeReposLabel);
            this.HelpTab.Controls.Add(this.ResetRepoFolder);
            this.HelpTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpTab.Location = new System.Drawing.Point(4, 22);
            this.HelpTab.Name = "HelpTab";
            this.HelpTab.Padding = new System.Windows.Forms.Padding(3);
            this.HelpTab.Size = new System.Drawing.Size(345, 334);
            this.HelpTab.TabIndex = 4;
            this.HelpTab.Text = "Help";
            // 
            // DownloadNetLabel
            // 
            this.DownloadNetLabel.AutoSize = true;
            this.DownloadNetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadNetLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.DownloadNetLabel.Location = new System.Drawing.Point(218, 17);
            this.DownloadNetLabel.Name = "DownloadNetLabel";
            this.DownloadNetLabel.Size = new System.Drawing.Size(103, 15);
            this.DownloadNetLabel.TabIndex = 28;
            this.DownloadNetLabel.TabStop = true;
            this.DownloadNetLabel.Text = "Download .NET 4";
            this.DownloadNetLabel.VisitedLinkColor = System.Drawing.Color.Silver;
            this.DownloadNetLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DownloadNetLabel_LinkClicked);
            // 
            // ProblemsCompilingLabel
            // 
            this.ProblemsCompilingLabel.AutoSize = true;
            this.ProblemsCompilingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProblemsCompilingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProblemsCompilingLabel.Location = new System.Drawing.Point(18, 19);
            this.ProblemsCompilingLabel.Name = "ProblemsCompilingLabel";
            this.ProblemsCompilingLabel.Size = new System.Drawing.Size(137, 13);
            this.ProblemsCompilingLabel.TabIndex = 27;
            this.ProblemsCompilingLabel.Text = "Mooege wont compile?";
            // 
            // AutoUpdateMadcowLabel
            // 
            this.AutoUpdateMadcowLabel.AutoSize = true;
            this.AutoUpdateMadcowLabel.Location = new System.Drawing.Point(18, 109);
            this.AutoUpdateMadcowLabel.Name = "AutoUpdateMadcowLabel";
            this.AutoUpdateMadcowLabel.Size = new System.Drawing.Size(112, 13);
            this.AutoUpdateMadcowLabel.TabIndex = 26;
            this.AutoUpdateMadcowLabel.Text = "Auto Update MadCow";
            // 
            // UpdateMadcowButton
            // 
            this.UpdateMadcowButton.Location = new System.Drawing.Point(218, 103);
            this.UpdateMadcowButton.Name = "UpdateMadcowButton";
            this.UpdateMadcowButton.Size = new System.Drawing.Size(108, 24);
            this.UpdateMadcowButton.TabIndex = 25;
            this.UpdateMadcowButton.Text = "Update MadCow";
            this.ToolTips.SetToolTip(this.UpdateMadcowButton, "Searchs and Autoupdate MadCow");
            this.UpdateMadcowButton.UseVisualStyleBackColor = true;
            this.UpdateMadcowButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // DownloadSpeedLabel
            // 
            this.DownloadSpeedLabel.AutoSize = true;
            this.DownloadSpeedLabel.Location = new System.Drawing.Point(23, 189);
            this.DownloadSpeedLabel.Name = "DownloadSpeedLabel";
            this.DownloadSpeedLabel.Size = new System.Drawing.Size(95, 13);
            this.DownloadSpeedLabel.TabIndex = 10;
            this.DownloadSpeedLabel.Text = "Download Speed: ";
            this.DownloadSpeedLabel.Visible = false;
            // 
            // DownloadFileNameLabel
            // 
            this.DownloadFileNameLabel.AutoSize = true;
            this.DownloadFileNameLabel.Location = new System.Drawing.Point(23, 176);
            this.DownloadFileNameLabel.Name = "DownloadFileNameLabel";
            this.DownloadFileNameLabel.Size = new System.Drawing.Size(94, 13);
            this.DownloadFileNameLabel.TabIndex = 9;
            this.DownloadFileNameLabel.Text = "Downloading File: ";
            this.DownloadFileNameLabel.Visible = false;
            // 
            // DownloadMPQSprogressBar
            // 
            this.DownloadMPQSprogressBar.Location = new System.Drawing.Point(25, 143);
            this.DownloadMPQSprogressBar.Name = "DownloadMPQSprogressBar";
            this.DownloadMPQSprogressBar.Size = new System.Drawing.Size(301, 30);
            this.DownloadMPQSprogressBar.TabIndex = 8;
            // 
            // DownloadMpqLabel
            // 
            this.DownloadMpqLabel.AutoSize = true;
            this.DownloadMpqLabel.Location = new System.Drawing.Point(18, 78);
            this.DownloadMpqLabel.Name = "DownloadMpqLabel";
            this.DownloadMpqLabel.Size = new System.Drawing.Size(190, 13);
            this.DownloadMpqLabel.TabIndex = 7;
            this.DownloadMpqLabel.Text = "Download all MPQ needed by Mooege";
            // 
            // DownloadMPQSButton
            // 
            this.DownloadMPQSButton.Location = new System.Drawing.Point(218, 72);
            this.DownloadMPQSButton.Name = "DownloadMPQSButton";
            this.DownloadMPQSButton.Size = new System.Drawing.Size(108, 25);
            this.DownloadMPQSButton.TabIndex = 6;
            this.DownloadMPQSButton.Text = "Download MPQ\'s";
            this.DownloadMPQSButton.UseVisualStyleBackColor = true;
            this.DownloadMPQSButton.Click += new System.EventHandler(this.DownloadMPQSButton_Click);
            // 
            // ResetMooegeReposLabel
            // 
            this.ResetMooegeReposLabel.AutoSize = true;
            this.ResetMooegeReposLabel.Location = new System.Drawing.Point(18, 47);
            this.ResetMooegeReposLabel.Name = "ResetMooegeReposLabel";
            this.ResetMooegeReposLabel.Size = new System.Drawing.Size(162, 13);
            this.ResetMooegeReposLabel.TabIndex = 5;
            this.ResetMooegeReposLabel.Text = "Reset Mooege Repository Folder";
            // 
            // ResetRepoFolder
            // 
            this.ResetRepoFolder.Location = new System.Drawing.Point(218, 41);
            this.ResetRepoFolder.Name = "ResetRepoFolder";
            this.ResetRepoFolder.Size = new System.Drawing.Size(108, 25);
            this.ResetRepoFolder.TabIndex = 2;
            this.ResetRepoFolder.Text = "Reset Folder";
            this.ResetRepoFolder.UseVisualStyleBackColor = true;
            this.ResetRepoFolder.Click += new System.EventHandler(this.ResetRepoFolder_Click);
            // 
            // DownloadSpeedTimer
            // 
            this.DownloadSpeedTimer.Interval = 60000;
            // 
            // DiabloPathFileDialog
            // 
            this.DiabloPathFileDialog.DefaultExt = "exe";
            this.DiabloPathFileDialog.FileName = "openFileDialog1";
            // 
            // ConsoleOutputTxtBox
            // 
            this.ConsoleOutputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConsoleOutputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsoleOutputTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConsoleOutputTxtBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleOutputTxtBox.ForeColor = System.Drawing.Color.White;
            this.ConsoleOutputTxtBox.Location = new System.Drawing.Point(6, 6);
            this.ConsoleOutputTxtBox.Multiline = true;
            this.ConsoleOutputTxtBox.Name = "ConsoleOutputTxtBox";
            this.ConsoleOutputTxtBox.ReadOnly = true;
            this.ConsoleOutputTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleOutputTxtBox.Size = new System.Drawing.Size(353, 322);
            this.ConsoleOutputTxtBox.TabIndex = 16;
            // 
            // VerifyDiablo3Version
            // 
            this.VerifyDiablo3Version.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // DownloadSelectedMpqs
            // 
            this.DownloadSelectedMpqs.WorkerReportsProgress = true;
            this.DownloadSelectedMpqs.WorkerSupportsCancellation = true;
            this.DownloadSelectedMpqs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadMPQS);
            this.DownloadSelectedMpqs.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.downloader_ProgressChanged);
            this.DownloadSelectedMpqs.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.downloader_DownloadedComplete);
            // 
            // ErrorFilesDownloaders
            // 
            this.ErrorFilesDownloaders.WorkerReportsProgress = true;
            this.ErrorFilesDownloaders.WorkerSupportsCancellation = true;
            this.ErrorFilesDownloaders.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadSpecificMPQS);
            this.ErrorFilesDownloaders.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.downloader_ProgressChanged2);
            this.ErrorFilesDownloaders.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.downloader_DownloadedComplete2);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.OutPutTab);
            this.tabControl2.Controls.Add(this.ChaneglogTab);
            this.tabControl2.Controls.Add(this.LiveHelpTab);
            this.tabControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl2.HotTrack = true;
            this.tabControl2.ItemSize = new System.Drawing.Size(96, 18);
            this.tabControl2.Location = new System.Drawing.Point(362, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(373, 360);
            this.tabControl2.TabIndex = 17;
            // 
            // OutPutTab
            // 
            this.OutPutTab.Controls.Add(this.ConsoleOutputTxtBox);
            this.OutPutTab.Location = new System.Drawing.Point(4, 22);
            this.OutPutTab.Name = "OutPutTab";
            this.OutPutTab.Padding = new System.Windows.Forms.Padding(3);
            this.OutPutTab.Size = new System.Drawing.Size(365, 334);
            this.OutPutTab.TabIndex = 0;
            this.OutPutTab.Text = "Output";
            this.OutPutTab.UseVisualStyleBackColor = true;
            // 
            // ChaneglogTab
            // 
            this.ChaneglogTab.BackColor = System.Drawing.Color.Transparent;
            this.ChaneglogTab.Controls.Add(this.changeLogTreeView);
            this.ChaneglogTab.Controls.Add(this.SelectRepositoryChngLogLabel);
            this.ChaneglogTab.Controls.Add(this.SelectRepoChngLogComboBox);
            this.ChaneglogTab.Location = new System.Drawing.Point(4, 22);
            this.ChaneglogTab.Name = "ChaneglogTab";
            this.ChaneglogTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChaneglogTab.Size = new System.Drawing.Size(365, 334);
            this.ChaneglogTab.TabIndex = 1;
            this.ChaneglogTab.Text = "Changelog";
            // 
            // changeLogTreeView
            // 
            this.changeLogTreeView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.changeLogTreeView.Location = new System.Drawing.Point(3, 37);
            this.changeLogTreeView.Name = "changeLogTreeView";
            this.changeLogTreeView.ShowNodeToolTips = true;
            this.changeLogTreeView.Size = new System.Drawing.Size(359, 294);
            this.changeLogTreeView.TabIndex = 2;
            // 
            // SelectRepositoryChngLogLabel
            // 
            this.SelectRepositoryChngLogLabel.AutoSize = true;
            this.SelectRepositoryChngLogLabel.Location = new System.Drawing.Point(66, 13);
            this.SelectRepositoryChngLogLabel.Name = "SelectRepositoryChngLogLabel";
            this.SelectRepositoryChngLogLabel.Size = new System.Drawing.Size(100, 13);
            this.SelectRepositoryChngLogLabel.TabIndex = 1;
            this.SelectRepositoryChngLogLabel.Text = "Select A Repository";
            // 
            // SelectRepoChngLogComboBox
            // 
            this.SelectRepoChngLogComboBox.FormattingEnabled = true;
            this.SelectRepoChngLogComboBox.Location = new System.Drawing.Point(172, 10);
            this.SelectRepoChngLogComboBox.Name = "SelectRepoChngLogComboBox";
            this.SelectRepoChngLogComboBox.Size = new System.Drawing.Size(121, 21);
            this.SelectRepoChngLogComboBox.TabIndex = 0;
            this.SelectRepoChngLogComboBox.DropDown += new System.EventHandler(this.SelectRepoChngLogComboBox_DropDown);
            this.SelectRepoChngLogComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // LiveHelpTab
            // 
            this.LiveHelpTab.Controls.Add(this.ircRulesLabel);
            this.LiveHelpTab.Controls.Add(this.ircNicknameLabel);
            this.LiveHelpTab.Controls.Add(this.ircNicknameTextBox);
            this.LiveHelpTab.Controls.Add(this.DisconnectButton);
            this.LiveHelpTab.Controls.Add(this.ircIntroLabel);
            this.LiveHelpTab.Controls.Add(this.ConnectButton);
            this.LiveHelpTab.Controls.Add(this.TypeHereLabel);
            this.LiveHelpTab.Controls.Add(this.ChatMessageBox);
            this.LiveHelpTab.Controls.Add(this.ChatUsersBox);
            this.LiveHelpTab.Controls.Add(this.ChatDisplayBox);
            this.LiveHelpTab.Location = new System.Drawing.Point(4, 22);
            this.LiveHelpTab.Name = "LiveHelpTab";
            this.LiveHelpTab.Size = new System.Drawing.Size(365, 334);
            this.LiveHelpTab.TabIndex = 2;
            this.LiveHelpTab.Text = "Live Help";
            this.LiveHelpTab.UseVisualStyleBackColor = true;
            // 
            // ircRulesLabel
            // 
            this.ircRulesLabel.AutoSize = true;
            this.ircRulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ircRulesLabel.ForeColor = System.Drawing.Color.Red;
            this.ircRulesLabel.Location = new System.Drawing.Point(66, 100);
            this.ircRulesLabel.Name = "ircRulesLabel";
            this.ircRulesLabel.Size = new System.Drawing.Size(236, 104);
            this.ircRulesLabel.TabIndex = 20;
            this.ircRulesLabel.Text = "Rules:\r\nRead before asking; http://goo.gl/zyIKu\r\nFAQ/wiki: http://goo.gl/K5tDU\r\nN" +
    "o Spam\r\nNo Racism\r\nNo Stupid questions\r\nNo  Public servers posting\r\nAsking for a" +
    " \'crack\' == BAN.";
            this.ircRulesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ircNicknameLabel
            // 
            this.ircNicknameLabel.AutoSize = true;
            this.ircNicknameLabel.Location = new System.Drawing.Point(23, 263);
            this.ircNicknameLabel.Name = "ircNicknameLabel";
            this.ircNicknameLabel.Size = new System.Drawing.Size(58, 13);
            this.ircNicknameLabel.TabIndex = 19;
            this.ircNicknameLabel.Text = "Nickname:";
            // 
            // ircNicknameTextBox
            // 
            this.ircNicknameTextBox.Location = new System.Drawing.Point(87, 260);
            this.ircNicknameTextBox.Name = "ircNicknameTextBox";
            this.ircNicknameTextBox.Size = new System.Drawing.Size(175, 20);
            this.ircNicknameTextBox.TabIndex = 18;
            this.ircNicknameTextBox.TextChanged += new System.EventHandler(this.ircNicknameTextBox_TextChanged);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButton.ForeColor = System.Drawing.Color.Maroon;
            this.DisconnectButton.Location = new System.Drawing.Point(248, 270);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(105, 58);
            this.DisconnectButton.TabIndex = 17;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Visible = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ircIntroLabel
            // 
            this.ircIntroLabel.AutoSize = true;
            this.ircIntroLabel.Location = new System.Drawing.Point(57, 22);
            this.ircIntroLabel.Name = "ircIntroLabel";
            this.ircIntroLabel.Size = new System.Drawing.Size(245, 52);
            this.ircIntroLabel.TabIndex = 11;
            this.ircIntroLabel.Text = "If you still haven\'t figured out how MadCow works\r\nor your getting errors in Mooe" +
    "ge or Madcow,\r\nclick Connect to proceed to IRC Mooege channel.\r\nSomeone might be" +
    " able to resolve your questions.";
            this.ircIntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(14, 286);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(339, 42);
            this.ConnectButton.TabIndex = 9;
            this.ConnectButton.Text = "Connect (DISABLED TILL BUG FIXING)";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TypeHereLabel
            // 
            this.TypeHereLabel.AutoSize = true;
            this.TypeHereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeHereLabel.ForeColor = System.Drawing.Color.DimGray;
            this.TypeHereLabel.Location = new System.Drawing.Point(11, 252);
            this.TypeHereLabel.Name = "TypeHereLabel";
            this.TypeHereLabel.Size = new System.Drawing.Size(161, 13);
            this.TypeHereLabel.TabIndex = 8;
            this.TypeHereLabel.Text = "Type here and press Enter:";
            this.TypeHereLabel.Visible = false;
            // 
            // ChatMessageBox
            // 
            this.ChatMessageBox.AcceptsTab = true;
            this.ChatMessageBox.BackColor = System.Drawing.Color.White;
            this.ChatMessageBox.Location = new System.Drawing.Point(14, 270);
            this.ChatMessageBox.Multiline = true;
            this.ChatMessageBox.Name = "ChatMessageBox";
            this.ChatMessageBox.Size = new System.Drawing.Size(228, 58);
            this.ChatMessageBox.TabIndex = 6;
            this.ChatMessageBox.Visible = false;
            this.ChatMessageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.ChatMessageBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // ChatUsersBox
            // 
            this.ChatUsersBox.BackColor = System.Drawing.Color.White;
            this.ChatUsersBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChatUsersBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatUsersBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ChatUsersBox.HideSelection = false;
            this.ChatUsersBox.Location = new System.Drawing.Point(248, 15);
            this.ChatUsersBox.Multiline = true;
            this.ChatUsersBox.Name = "ChatUsersBox";
            this.ChatUsersBox.ReadOnly = true;
            this.ChatUsersBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatUsersBox.Size = new System.Drawing.Size(105, 219);
            this.ChatUsersBox.TabIndex = 5;
            this.ChatUsersBox.Visible = false;
            this.ChatUsersBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseMove);
            // 
            // ChatDisplayBox
            // 
            this.ChatDisplayBox.BackColor = System.Drawing.Color.White;
            this.ChatDisplayBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ChatDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatDisplayBox.ForeColor = System.Drawing.Color.Black;
            this.ChatDisplayBox.HideSelection = false;
            this.ChatDisplayBox.Location = new System.Drawing.Point(14, 15);
            this.ChatDisplayBox.MaxLength = 250;
            this.ChatDisplayBox.Multiline = true;
            this.ChatDisplayBox.Name = "ChatDisplayBox";
            this.ChatDisplayBox.ReadOnly = true;
            this.ChatDisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatDisplayBox.Size = new System.Drawing.Size(228, 219);
            this.ChatDisplayBox.TabIndex = 1;
            this.ChatDisplayBox.Visible = false;
            // 
            // MadCowTrayIcon
            // 
            this.MadCowTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MadCowTrayIcon.Icon")));
            this.MadCowTrayIcon.Text = "MadCow";
            this.MadCowTrayIcon.Visible = true;
            this.MadCowTrayIcon.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // MpqPathBrowserDialog
            // 
            this.MpqPathBrowserDialog.Description = "Select the MPQ destination.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.repositoriesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madCowToolStripMenuItem,
            this.mooegeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // madCowToolStripMenuItem
            // 
            this.madCowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableTrayToolStripMenuItem,
            this.enableTrayNotificationsToolStripMenuItem,
            this.desktopShortcutToolStripMenuItem,
            this.compileAsDebugToolStripMenuItem,
            this.checkUpdatesToolStripMenuItem});
            this.madCowToolStripMenuItem.Name = "madCowToolStripMenuItem";
            this.madCowToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.madCowToolStripMenuItem.Text = "Mad&Cow";
            // 
            // enableTrayToolStripMenuItem
            // 
            this.enableTrayToolStripMenuItem.CheckOnClick = true;
            this.enableTrayToolStripMenuItem.Name = "enableTrayToolStripMenuItem";
            this.enableTrayToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.enableTrayToolStripMenuItem.Text = "Enable Tray";
            this.enableTrayToolStripMenuItem.CheckedChanged += new System.EventHandler(this.enableTrayToolStripMenuItem_CheckedChanged);
            // 
            // enableTrayNotificationsToolStripMenuItem
            // 
            this.enableTrayNotificationsToolStripMenuItem.CheckOnClick = true;
            this.enableTrayNotificationsToolStripMenuItem.Name = "enableTrayNotificationsToolStripMenuItem";
            this.enableTrayNotificationsToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.enableTrayNotificationsToolStripMenuItem.Text = "Enable Tray Notifications";
            this.enableTrayNotificationsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.enableTrayNotificationsToolStripMenuItem_CheckedChanged);
            // 
            // desktopShortcutToolStripMenuItem
            // 
            this.desktopShortcutToolStripMenuItem.CheckOnClick = true;
            this.desktopShortcutToolStripMenuItem.Name = "desktopShortcutToolStripMenuItem";
            this.desktopShortcutToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.desktopShortcutToolStripMenuItem.Text = "Desktop Shortcut";
            this.desktopShortcutToolStripMenuItem.CheckedChanged += new System.EventHandler(this.desktopShortcutToolStripMenuItem_CheckedChanged);
            // 
            // compileAsDebugToolStripMenuItem
            // 
            this.compileAsDebugToolStripMenuItem.CheckOnClick = true;
            this.compileAsDebugToolStripMenuItem.Name = "compileAsDebugToolStripMenuItem";
            this.compileAsDebugToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.compileAsDebugToolStripMenuItem.Text = "Compile Mooege as Debug";
            this.compileAsDebugToolStripMenuItem.Click += new System.EventHandler(this.compileAsDebugToolStripMenuItem_Click);
            // 
            // checkUpdatesToolStripMenuItem
            // 
            this.checkUpdatesToolStripMenuItem.CheckOnClick = true;
            this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
            this.checkUpdatesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.checkUpdatesToolStripMenuItem.Text = "Check for Mooege Updates";
            this.checkUpdatesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.checkUpdatesToolStripMenuItem_CheckedChanged);
            // 
            // mooegeToolStripMenuItem
            // 
            this.mooegeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableFileLoggingToolStripMenuItem,
            this.enablePacketLoggingToolStripMenuItem,
            this.enableTasksToolStripMenuItem,
            this.enableLazyLoadingToolStripMenuItem,
            this.enableNoPasswordCheckToolStripMenuItem});
            this.mooegeToolStripMenuItem.Name = "mooegeToolStripMenuItem";
            this.mooegeToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mooegeToolStripMenuItem.Text = "&Mooege";
            // 
            // enableFileLoggingToolStripMenuItem
            // 
            this.enableFileLoggingToolStripMenuItem.CheckOnClick = true;
            this.enableFileLoggingToolStripMenuItem.Name = "enableFileLoggingToolStripMenuItem";
            this.enableFileLoggingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.enableFileLoggingToolStripMenuItem.Text = "Enable File Logging";
            this.enableFileLoggingToolStripMenuItem.Click += new System.EventHandler(this.enableFileLoggingToolStripMenuItem_Click);
            // 
            // enablePacketLoggingToolStripMenuItem
            // 
            this.enablePacketLoggingToolStripMenuItem.CheckOnClick = true;
            this.enablePacketLoggingToolStripMenuItem.Name = "enablePacketLoggingToolStripMenuItem";
            this.enablePacketLoggingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.enablePacketLoggingToolStripMenuItem.Text = "Enable Packet Logging";
            this.enablePacketLoggingToolStripMenuItem.Click += new System.EventHandler(this.enablePacketLoggingToolStripMenuItem_Click);
            // 
            // enableTasksToolStripMenuItem
            // 
            this.enableTasksToolStripMenuItem.CheckOnClick = true;
            this.enableTasksToolStripMenuItem.Name = "enableTasksToolStripMenuItem";
            this.enableTasksToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.enableTasksToolStripMenuItem.Text = "Enable Tasks";
            this.enableTasksToolStripMenuItem.Click += new System.EventHandler(this.enableTasksToolStripMenuItem_Click);
            // 
            // enableLazyLoadingToolStripMenuItem
            // 
            this.enableLazyLoadingToolStripMenuItem.CheckOnClick = true;
            this.enableLazyLoadingToolStripMenuItem.Name = "enableLazyLoadingToolStripMenuItem";
            this.enableLazyLoadingToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.enableLazyLoadingToolStripMenuItem.Text = "Enable Lazy Loading";
            this.enableLazyLoadingToolStripMenuItem.Click += new System.EventHandler(this.enableLazyLoadingToolStripMenuItem_Click);
            // 
            // enableNoPasswordCheckToolStripMenuItem
            // 
            this.enableNoPasswordCheckToolStripMenuItem.CheckOnClick = true;
            this.enableNoPasswordCheckToolStripMenuItem.Name = "enableNoPasswordCheckToolStripMenuItem";
            this.enableNoPasswordCheckToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.enableNoPasswordCheckToolStripMenuItem.Text = "Enable No Password Check";
            this.enableNoPasswordCheckToolStripMenuItem.Click += new System.EventHandler(this.enableNoPasswordCheckToolStripMenuItem_Click);
            // 
            // repositoriesToolStripMenuItem
            // 
            this.repositoriesToolStripMenuItem.Name = "repositoriesToolStripMenuItem";
            this.repositoriesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.repositoriesToolStripMenuItem.Text = "Repositories...";
            this.repositoriesToolStripMenuItem.Click += new System.EventHandler(this.repositoriesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.Tabs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(736, 367);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripStatusLabel,
            this.statusStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusStripStatusLabel
            // 
            this.statusStripStatusLabel.Name = "statusStripStatusLabel";
            this.statusStripStatusLabel.Size = new System.Drawing.Size(721, 17);
            this.statusStripStatusLabel.Spring = true;
            this.statusStripStatusLabel.Text = "Ready";
            this.statusStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStripProgressBar
            // 
            this.statusStripProgressBar.Name = "statusStripProgressBar";
            this.statusStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.statusStripProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 415);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MadCow By Wesko";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.RemoteServerTab.ResumeLayout(false);
            this.RemoteServerTab.PerformLayout();
            this.RemoteServerGrpBox.ResumeLayout(false);
            this.RemoteServerGrpBox.PerformLayout();
            this.ServerControlTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TickGameServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickBnetServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickPublicServerIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickGameServerIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickBnetServerIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGameServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBnetServerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPublicServerIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGameServerIp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorBnetServerIp)).EndInit();
            this.UpdatesTab.ResumeLayout(false);
            this.UpdatesTab.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.HelpTab.ResumeLayout(false);
            this.HelpTab.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.OutPutTab.ResumeLayout(false);
            this.OutPutTab.PerformLayout();
            this.ChaneglogTab.ResumeLayout(false);
            this.ChaneglogTab.PerformLayout();
            this.LiveHelpTab.ResumeLayout(false);
            this.LiveHelpTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchServerButton;
        private System.Windows.Forms.Button RemoteServerLaunchButton;
        private System.Windows.Forms.TabPage RemoteServerTab;
        private System.Windows.Forms.TabPage ServerControlTab;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel RestoreDefaultsLabel;
        private System.Windows.Forms.CheckBox NATcheckBox;
        private System.Windows.Forms.Label PublicServerIpLabel;
        private System.Windows.Forms.TextBox PublicServerIp;
        private System.Windows.Forms.Label GameServerPortLabel;
        private System.Windows.Forms.Label GameServerIpLabel;
        private System.Windows.Forms.TextBox GameServerPort;
        private System.Windows.Forms.TextBox GameServerIp;
        private System.Windows.Forms.Label BnetServerPortLabel;
        private System.Windows.Forms.Label BnetServerIpLabel;
        private System.Windows.Forms.TextBox BnetServerPort;
        private System.Windows.Forms.TextBox BnetServerIp;
        private System.Windows.Forms.GroupBox RemoteServerGrpBox;
        private System.Windows.Forms.Label RemotePort;
        private System.Windows.Forms.Label RemoteHost;
        private System.Windows.Forms.TextBox remotePortTxtBox;
        private System.Windows.Forms.TextBox remoteHostTxtBox;
        private System.Windows.Forms.Timer DownloadSpeedTimer;
        private System.Windows.Forms.Label RemoteServerTip2;
        private System.Windows.Forms.TabPage HelpTab;
        private System.Windows.Forms.Button FindDiabloButton;
        private System.Windows.Forms.TextBox Diablo3UserPathSelection;
        private System.Windows.Forms.OpenFileDialog DiabloPathFileDialog;
        private System.Windows.Forms.Label RepositoryHintLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button UpdateMooegeButton;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.Label AutoUpdateTimerLabel;
        private System.Windows.Forms.Button ResetRepoFolder;
        private System.Windows.Forms.Label ResetMooegeReposLabel;
        private System.Windows.Forms.Label RemoteServerTip;
        private System.Windows.Forms.Label MotdLabel;
        private System.Windows.Forms.TextBox MotdTxtBox;
        private System.ComponentModel.BackgroundWorker VerifyDiablo3Version;
        private System.Windows.Forms.Button loadProfileButton;
        private System.Windows.Forms.Button saveProfileButton;
        private System.Windows.Forms.PictureBox ErrorGameServerPort;
        private System.Windows.Forms.PictureBox ErrorBnetServerPort;
        private System.Windows.Forms.PictureBox ErrorPublicServerIp;
        private System.Windows.Forms.PictureBox ErrorGameServerIp;
        private System.Windows.Forms.PictureBox ErrorBnetServerIp;
        private System.Windows.Forms.PictureBox TickBnetServerIP;
        private System.Windows.Forms.PictureBox TickGameServerPort;
        private System.Windows.Forms.PictureBox TickBnetServerPort;
        private System.Windows.Forms.PictureBox TickPublicServerIp;
        private System.Windows.Forms.PictureBox TickGameServerIp;
        private System.Windows.Forms.Label DownloadMpqLabel;
        private System.Windows.Forms.Button DownloadMPQSButton;
        internal System.Windows.Forms.ProgressBar DownloadMPQSprogressBar;
        private System.Windows.Forms.Label DownloadFileNameLabel;
        private System.Windows.Forms.Label DownloadSpeedLabel;
        private System.ComponentModel.BackgroundWorker ErrorFilesDownloaders;
        internal System.Windows.Forms.TextBox ConsoleOutputTxtBox;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage OutPutTab;
        private System.Windows.Forms.TabPage ChaneglogTab;
        private System.Windows.Forms.Label SelectRepositoryChngLogLabel;
        private System.Windows.Forms.ComboBox SelectRepoChngLogComboBox;
        internal System.Windows.Forms.NotifyIcon MadCowTrayIcon;
        internal System.Windows.Forms.Button PlayDiabloButton;
        internal System.Windows.Forms.Button CopyMPQButton;
        internal System.ComponentModel.BackgroundWorker DownloadSelectedMpqs;
        internal System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage UpdatesTab;
        private System.Windows.Forms.Button UpdateMadcowButton;
        private System.Windows.Forms.Label AutoUpdateMadcowLabel;
        private System.Windows.Forms.FolderBrowserDialog MpqPathBrowserDialog;
        private System.Windows.Forms.LinkLabel DownloadNetLabel;
        private System.Windows.Forms.Label ProblemsCompilingLabel;
        private System.Windows.Forms.TabPage LiveHelpTab;
        internal System.Windows.Forms.TextBox ChatDisplayBox;
        internal System.Windows.Forms.TextBox ChatUsersBox;
        internal System.Windows.Forms.TextBox ChatMessageBox;
        internal System.Windows.Forms.Label TypeHereLabel;
        internal System.Windows.Forms.Button ConnectButton;
        internal System.Windows.Forms.Label ircIntroLabel;
        internal System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madCowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableTrayNotificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desktopShortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mooegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileAsDebugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoriesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel statusStripStatusLabel;
        internal System.Windows.Forms.ToolStripProgressBar statusStripProgressBar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button BrowseMPQPathButton;
        internal System.Windows.Forms.TextBox MPQDestTextBox;
        private System.Windows.Forms.ToolStripMenuItem enableFileLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enablePacketLoggingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableLazyLoadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableNoPasswordCheckToolStripMenuItem;
        internal System.Windows.Forms.ComboBox repoComboBox;
        private System.Windows.Forms.TreeView changeLogTreeView;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesToolStripMenuItem;
        internal System.Windows.Forms.TextBox ircNicknameTextBox;
        internal System.Windows.Forms.Label ircNicknameLabel;
        internal System.Windows.Forms.Label ircRulesLabel;

    }
}