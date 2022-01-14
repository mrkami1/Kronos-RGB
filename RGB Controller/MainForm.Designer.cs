namespace RGB_Controller {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.brightnessSlider = new System.Windows.Forms.TrackBar();
            this.brightnessGroup = new System.Windows.Forms.GroupBox();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.Creator = new System.Windows.Forms.Label();
            this.speedGroup = new System.Windows.Forms.GroupBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedSlider = new System.Windows.Forms.TrackBar();
            this.SlideTimer = new System.Windows.Forms.Timer(this.components);
            this.Sidebar = new System.Windows.Forms.Panel();
            this.LightingOptions = new System.Windows.Forms.Panel();
            this.LightModes = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Panel();
            this.LightModesPanel = new System.Windows.Forms.Panel();
            this.Sparkle = new System.Windows.Forms.Button();
            this.color_spectrum = new System.Windows.Forms.Button();
            this.breathing = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.static_color = new System.Windows.Forms.Button();
            this.alternate = new System.Windows.Forms.Button();
            this.visor = new System.Windows.Forms.Button();
            this.color_cycle = new System.Windows.Forms.Button();
            this.LightingOptionsPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ChangeDevice = new System.Windows.Forms.Button();
            this.ApplySettings = new System.Windows.Forms.Button();
            this.StartMinimized = new System.Windows.Forms.CheckBox();
            this.StartWithWindows = new System.Windows.Forms.CheckBox();
            this.SystemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BringToForeground = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).BeginInit();
            this.brightnessGroup.SuspendLayout();
            this.speedGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.LightModesPanel.SuspendLayout();
            this.LightingOptionsPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // brightnessSlider
            // 
            this.brightnessSlider.AutoSize = false;
            this.brightnessSlider.BackColor = System.Drawing.Color.Silver;
            this.brightnessSlider.Location = new System.Drawing.Point(6, 20);
            this.brightnessSlider.Maximum = 100;
            this.brightnessSlider.Name = "brightnessSlider";
            this.brightnessSlider.Size = new System.Drawing.Size(397, 25);
            this.brightnessSlider.TabIndex = 7;
            this.brightnessSlider.TickFrequency = 5;
            this.brightnessSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightnessSlider.Value = 50;
            this.brightnessSlider.Scroll += new System.EventHandler(this.BrightnessSlider_Scroll);
            this.brightnessSlider.MouseCaptureChanged += new System.EventHandler(this.BrightnessSlider_Scroll_MouseCaptureChanged);
            // 
            // brightnessGroup
            // 
            this.brightnessGroup.BackColor = System.Drawing.Color.Transparent;
            this.brightnessGroup.Controls.Add(this.brightnessLabel);
            this.brightnessGroup.Controls.Add(this.brightnessSlider);
            this.brightnessGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brightnessGroup.Location = new System.Drawing.Point(15, 74);
            this.brightnessGroup.Name = "brightnessGroup";
            this.brightnessGroup.Size = new System.Drawing.Size(459, 50);
            this.brightnessGroup.TabIndex = 9;
            this.brightnessGroup.TabStop = false;
            this.brightnessGroup.Text = "Brightness";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.brightnessLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brightnessLabel.Location = new System.Drawing.Point(412, 17);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(44, 25);
            this.brightnessLabel.TabIndex = 8;
            this.brightnessLabel.Text = "50%";
            this.brightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Creator
            // 
            this.Creator.AutoSize = true;
            this.Creator.BackColor = System.Drawing.Color.Transparent;
            this.Creator.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creator.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Creator.Location = new System.Drawing.Point(334, 451);
            this.Creator.Name = "Creator";
            this.Creator.Size = new System.Drawing.Size(156, 20);
            this.Creator.TabIndex = 13;
            this.Creator.Text = "https://github.com/mrkami1 ";
            // 
            // speedGroup
            // 
            this.speedGroup.BackColor = System.Drawing.Color.Transparent;
            this.speedGroup.Controls.Add(this.speedLabel);
            this.speedGroup.Controls.Add(this.speedSlider);
            this.speedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.speedGroup.Location = new System.Drawing.Point(15, 12);
            this.speedGroup.Name = "speedGroup";
            this.speedGroup.Size = new System.Drawing.Size(459, 50);
            this.speedGroup.TabIndex = 18;
            this.speedGroup.TabStop = false;
            this.speedGroup.Text = "Speed";
            // 
            // speedLabel
            // 
            this.speedLabel.BackColor = System.Drawing.Color.Transparent;
            this.speedLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.Location = new System.Drawing.Point(412, 17);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(41, 25);
            this.speedLabel.TabIndex = 9;
            this.speedLabel.Text = "50%";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedSlider
            // 
            this.speedSlider.AutoSize = false;
            this.speedSlider.BackColor = System.Drawing.Color.Silver;
            this.speedSlider.Location = new System.Drawing.Point(6, 19);
            this.speedSlider.Maximum = 100;
            this.speedSlider.Minimum = 1;
            this.speedSlider.Name = "speedSlider";
            this.speedSlider.Size = new System.Drawing.Size(397, 25);
            this.speedSlider.TabIndex = 9;
            this.speedSlider.TickFrequency = 5;
            this.speedSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.speedSlider.Value = 50;
            this.speedSlider.Scroll += new System.EventHandler(this.SpeedSlider_Scroll);
            this.speedSlider.MouseCaptureChanged += new System.EventHandler(this.SpeedSlider_Scroll_MouseCaptureChanged);
            // 
            // SlideTimer
            // 
            this.SlideTimer.Interval = 1;
            this.SlideTimer.Tick += new System.EventHandler(this.SlideTimer_Tick);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.Gray;
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Sidebar.Controls.Add(this.LightingOptions);
            this.Sidebar.Controls.Add(this.LightModes);
            this.Sidebar.Controls.Add(this.Settings);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(40, 471);
            this.Sidebar.TabIndex = 20;
            // 
            // LightingOptions
            // 
            this.LightingOptions.BackColor = System.Drawing.Color.Transparent;
            this.LightingOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LightingOptions.BackgroundImage")));
            this.LightingOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LightingOptions.Location = new System.Drawing.Point(0, 38);
            this.LightingOptions.Name = "LightingOptions";
            this.LightingOptions.Size = new System.Drawing.Size(40, 40);
            this.LightingOptions.TabIndex = 2;
            this.LightingOptions.Click += new System.EventHandler(this.Sidebar_Button_Click);
            // 
            // LightModes
            // 
            this.LightModes.BackColor = System.Drawing.Color.Silver;
            this.LightModes.BackgroundImage = global::RGB_Controller.Properties.Resources.light_modes_icon1;
            this.LightModes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LightModes.Location = new System.Drawing.Point(0, 0);
            this.LightModes.Name = "LightModes";
            this.LightModes.Size = new System.Drawing.Size(40, 40);
            this.LightModes.TabIndex = 1;
            this.LightModes.Click += new System.EventHandler(this.Sidebar_Button_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Settings.BackgroundImage")));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(0, 431);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(40, 40);
            this.Settings.TabIndex = 0;
            this.Settings.Click += new System.EventHandler(this.Sidebar_Button_Click);
            // 
            // LightModesPanel
            // 
            this.LightModesPanel.BackColor = System.Drawing.Color.Silver;
            this.LightModesPanel.Controls.Add(this.Sparkle);
            this.LightModesPanel.Controls.Add(this.color_spectrum);
            this.LightModesPanel.Controls.Add(this.Creator);
            this.LightModesPanel.Controls.Add(this.breathing);
            this.LightModesPanel.Controls.Add(this.fill);
            this.LightModesPanel.Controls.Add(this.static_color);
            this.LightModesPanel.Controls.Add(this.alternate);
            this.LightModesPanel.Controls.Add(this.visor);
            this.LightModesPanel.Controls.Add(this.color_cycle);
            this.LightModesPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightModesPanel.Location = new System.Drawing.Point(40, 0);
            this.LightModesPanel.Name = "LightModesPanel";
            this.LightModesPanel.Size = new System.Drawing.Size(468, 471);
            this.LightModesPanel.TabIndex = 21;
            // 
            // Sparkle
            // 
            this.Sparkle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sparkle.Location = new System.Drawing.Point(124, 64);
            this.Sparkle.Name = "Sparkle";
            this.Sparkle.Size = new System.Drawing.Size(112, 50);
            this.Sparkle.TabIndex = 40;
            this.Sparkle.Text = "Sparkle";
            this.Sparkle.UseVisualStyleBackColor = true;
            this.Sparkle.Click += new System.EventHandler(this.Sparkle_Click);
            // 
            // color_spectrum
            // 
            this.color_spectrum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.color_spectrum.Location = new System.Drawing.Point(6, 8);
            this.color_spectrum.Name = "color_spectrum";
            this.color_spectrum.Size = new System.Drawing.Size(112, 50);
            this.color_spectrum.TabIndex = 33;
            this.color_spectrum.Text = "Color Spectrum";
            this.color_spectrum.UseVisualStyleBackColor = true;
            this.color_spectrum.Click += new System.EventHandler(this.Color_spectrum_Click);
            // 
            // breathing
            // 
            this.breathing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.breathing.Location = new System.Drawing.Point(359, 8);
            this.breathing.Name = "breathing";
            this.breathing.Size = new System.Drawing.Size(112, 50);
            this.breathing.TabIndex = 34;
            this.breathing.Text = "Breathing";
            this.breathing.UseVisualStyleBackColor = true;
            this.breathing.Click += new System.EventHandler(this.Breathing_Click);
            // 
            // fill
            // 
            this.fill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fill.Location = new System.Drawing.Point(359, 64);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(112, 50);
            this.fill.TabIndex = 39;
            this.fill.Text = "Fill";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // static_color
            // 
            this.static_color.ForeColor = System.Drawing.SystemColors.ControlText;
            this.static_color.Location = new System.Drawing.Point(241, 8);
            this.static_color.Name = "static_color";
            this.static_color.Size = new System.Drawing.Size(112, 50);
            this.static_color.TabIndex = 35;
            this.static_color.Text = "Static Color";
            this.static_color.UseVisualStyleBackColor = true;
            this.static_color.Click += new System.EventHandler(this.Static_color_Click);
            // 
            // alternate
            // 
            this.alternate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alternate.Location = new System.Drawing.Point(6, 64);
            this.alternate.Name = "alternate";
            this.alternate.Size = new System.Drawing.Size(112, 50);
            this.alternate.TabIndex = 36;
            this.alternate.Text = "Alternate";
            this.alternate.UseVisualStyleBackColor = true;
            this.alternate.Click += new System.EventHandler(this.Alternate_Click);
            // 
            // visor
            // 
            this.visor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.visor.Location = new System.Drawing.Point(241, 64);
            this.visor.Name = "visor";
            this.visor.Size = new System.Drawing.Size(112, 50);
            this.visor.TabIndex = 37;
            this.visor.Text = "Visor";
            this.visor.UseVisualStyleBackColor = true;
            this.visor.Click += new System.EventHandler(this.Visor_Click);
            // 
            // color_cycle
            // 
            this.color_cycle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.color_cycle.Location = new System.Drawing.Point(124, 8);
            this.color_cycle.Name = "color_cycle";
            this.color_cycle.Size = new System.Drawing.Size(112, 50);
            this.color_cycle.TabIndex = 38;
            this.color_cycle.Text = "Color Cycle";
            this.color_cycle.UseVisualStyleBackColor = true;
            this.color_cycle.Click += new System.EventHandler(this.Color_cycle_Click);
            // 
            // LightingOptionsPanel
            // 
            this.LightingOptionsPanel.BackColor = System.Drawing.Color.Silver;
            this.LightingOptionsPanel.Controls.Add(this.speedGroup);
            this.LightingOptionsPanel.Controls.Add(this.brightnessGroup);
            this.LightingOptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightingOptionsPanel.Location = new System.Drawing.Point(508, 0);
            this.LightingOptionsPanel.Name = "LightingOptionsPanel";
            this.LightingOptionsPanel.Size = new System.Drawing.Size(10, 471);
            this.LightingOptionsPanel.TabIndex = 22;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Silver;
            this.SettingsPanel.Controls.Add(this.ChangeDevice);
            this.SettingsPanel.Controls.Add(this.ApplySettings);
            this.SettingsPanel.Controls.Add(this.StartMinimized);
            this.SettingsPanel.Controls.Add(this.StartWithWindows);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(518, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(10, 471);
            this.SettingsPanel.TabIndex = 23;
            // 
            // ChangeDevice
            // 
            this.ChangeDevice.Location = new System.Drawing.Point(96, 101);
            this.ChangeDevice.Name = "ChangeDevice";
            this.ChangeDevice.Size = new System.Drawing.Size(90, 23);
            this.ChangeDevice.TabIndex = 3;
            this.ChangeDevice.Text = "Change Device";
            this.ChangeDevice.UseVisualStyleBackColor = true;
            this.ChangeDevice.Click += new System.EventHandler(this.ChangeDevice_Click);
            // 
            // ApplySettings
            // 
            this.ApplySettings.Enabled = false;
            this.ApplySettings.Location = new System.Drawing.Point(15, 101);
            this.ApplySettings.Name = "ApplySettings";
            this.ApplySettings.Size = new System.Drawing.Size(75, 23);
            this.ApplySettings.TabIndex = 2;
            this.ApplySettings.Text = "Apply";
            this.ApplySettings.UseVisualStyleBackColor = true;
            this.ApplySettings.Click += new System.EventHandler(this.ApplySettings_Click);
            // 
            // StartMinimized
            // 
            this.StartMinimized.AutoSize = true;
            this.StartMinimized.Enabled = false;
            this.StartMinimized.Location = new System.Drawing.Point(15, 44);
            this.StartMinimized.Name = "StartMinimized";
            this.StartMinimized.Size = new System.Drawing.Size(181, 17);
            this.StartMinimized.TabIndex = 1;
            this.StartMinimized.Text = "Startup minimized to System Tray";
            this.StartMinimized.UseVisualStyleBackColor = true;
            this.StartMinimized.CheckedChanged += new System.EventHandler(this.StartMinimized_CheckedChanged);
            // 
            // StartWithWindows
            // 
            this.StartWithWindows.AutoSize = true;
            this.StartWithWindows.Location = new System.Drawing.Point(15, 13);
            this.StartWithWindows.Name = "StartWithWindows";
            this.StartWithWindows.Size = new System.Drawing.Size(129, 17);
            this.StartWithWindows.TabIndex = 0;
            this.StartWithWindows.Text = "Startup with Windows";
            this.StartWithWindows.UseVisualStyleBackColor = true;
            this.StartWithWindows.CheckedChanged += new System.EventHandler(this.StartWithWindows_CheckedChanged);
            // 
            // SystemTrayIcon
            // 
            this.SystemTrayIcon.ContextMenuStrip = this.contextMenuStrip;
            this.SystemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTrayIcon.Icon")));
            this.SystemTrayIcon.Text = "Kronos RGB";
            this.SystemTrayIcon.Visible = true;
            this.SystemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BringToForeground,
            this.toolStripSeparator1,
            this.ExitApplication});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(126, 54);
            // 
            // BringToForeground
            // 
            this.BringToForeground.BackColor = System.Drawing.SystemColors.Control;
            this.BringToForeground.Name = "BringToForeground";
            this.BringToForeground.Size = new System.Drawing.Size(125, 22);
            this.BringToForeground.Text = "Maximize";
            this.BringToForeground.Click += new System.EventHandler(this.BringToForeground_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // ExitApplication
            // 
            this.ExitApplication.Name = "ExitApplication";
            this.ExitApplication.Size = new System.Drawing.Size(125, 22);
            this.ExitApplication.Text = "Exit";
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(530, 471);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.LightingOptionsPanel);
            this.Controls.Add(this.LightModesPanel);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Kronos";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessSlider)).EndInit();
            this.brightnessGroup.ResumeLayout(false);
            this.speedGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speedSlider)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.LightModesPanel.ResumeLayout(false);
            this.LightModesPanel.PerformLayout();
            this.LightingOptionsPanel.ResumeLayout(false);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Creator;
        public System.Windows.Forms.GroupBox brightnessGroup;
        public System.Windows.Forms.GroupBox speedGroup;
        public System.Windows.Forms.TrackBar brightnessSlider;
        public System.Windows.Forms.TrackBar speedSlider;
        public System.Windows.Forms.Label brightnessLabel;
        public System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Timer SlideTimer;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Panel LightModes;
        private System.Windows.Forms.Panel LightingOptions;
        private System.Windows.Forms.Panel LightModesPanel;
        private System.Windows.Forms.Button Sparkle;
        private System.Windows.Forms.Button color_spectrum;
        private System.Windows.Forms.Button breathing;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button static_color;
        private System.Windows.Forms.Button alternate;
        private System.Windows.Forms.Button visor;
        private System.Windows.Forms.Button color_cycle;
        private System.Windows.Forms.Panel LightingOptionsPanel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.CheckBox StartMinimized;
        private System.Windows.Forms.CheckBox StartWithWindows;
        private System.Windows.Forms.NotifyIcon SystemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BringToForeground;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitApplication;
        private System.Windows.Forms.Button ApplySettings;
        private System.Windows.Forms.Button ChangeDevice;
    }
}

