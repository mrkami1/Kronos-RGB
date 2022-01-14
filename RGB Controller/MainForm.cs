using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using Microsoft.Win32;
using System.Linq;

namespace RGB_Controller {

    public partial class MainForm : Form {
        
        public string[] portNames;

        public MainForm() {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e) {
            //Check if an instance of the application is already running; close it if there is
            if (System.Diagnostics.Process.GetProcessesByName(
                System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)
                ).Count() > 1) System.Diagnostics.Process.GetCurrentProcess().Kill();

            //Disable user input until communication with software and device is successful
            DisableGroups(true);
            
            FileManager.LoadFile();
            FileManager.checkFirstStart();
            
            LightModesPanel.Width = 490;
            LightingOptionsPanel.Width = 0;
            SettingsPanel.Width = 0;
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (StartMinimized.Checked == true) {
                Visible = false;
                ShowInTaskbar = false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        private void SystemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void BringToForeground_Click(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void ExitApplication_Click(object sender, EventArgs e) {
            try {
                SerialDriver.serialPort.Close();
                SerialDriver.serialThread.Abort();
            }
            catch (Exception ex) {
               
            }
            Application.Exit();
        }

        public void DisableGroups(bool value) {
            MainForm MainForm = Application.OpenForms["MainForm"] as MainForm;
            if (value == true) {
                MainForm.Enabled = false;
            }
            else {
                MainForm.Enabled = true;
            }
        } 

        public void SetSliderValue(int type, int value) {
            if (type == 1) {
                speedSlider.Value = value;
                speedLabel.Text = value + "%";
            }
            else if (type == 2){
                brightnessSlider.Value = value;
                brightnessLabel.Text = value + "%";
            }
        }

        public void SetCheckBoxes(int type, bool value) {
            if (type == 1) {
                StartWithWindows.Checked = value;
            }
            else if (type == 2) {
                StartMinimized.Checked = value;
            }
        }

        //Updates the percentage text
        private void SpeedSlider_Scroll(object sender, EventArgs e) {
            speedLabel.Text = speedSlider.Value.ToString() + "%";
        }
        private void BrightnessSlider_Scroll(object sender, EventArgs e) { 
            brightnessLabel.Text = brightnessSlider.Value.ToString() + "%";
        }
        //Change brightness when LMB is released
        private void BrightnessSlider_Scroll_MouseCaptureChanged(object sender, EventArgs e) {
            float value = brightnessSlider.Value;
            value = (value / 100) * 255;
            value = (float)Math.Floor(value);
            SerialDriver.serialPort.Write("bright=" + value.ToString());
            Thread.Sleep(5);
            FileManager.SaveFile("brightness_value=", brightnessSlider.Value.ToString());
        }
        //Change speed when LMB is released
        private void SpeedSlider_Scroll_MouseCaptureChanged(object sender, EventArgs e) {
            float value = speedSlider.Value;
            value = (value / 100) * 255;
            value = (float)Math.Floor(value);
            SerialDriver.serialPort.Write("speed=" + value.ToString());
            Thread.Sleep(5);
            FileManager.SaveFile("speed_value=", speedSlider.Value.ToString());
        }

        //-----------Sidebar button functions---------------//

        private void Sidebar_Button_Click(object sender, EventArgs e) {
            var panelObject = (Panel)sender;
            string buttonName = panelObject.Name;

            switch (buttonName) {
                case "LightModes": LightModes_Clicked(); break;
                case "LightingOptions": LightingOptions_Clicked(); break;
                case "Settings": Settings_Clicked(); break;
            }
        }

        private void ClearSidebarItems() {
            LightModes.BackColor = Color.Transparent;
            LightingOptions.BackColor = Color.Transparent;
            Settings.BackColor = Color.Transparent;

            LightModesPanel.Width = 0;
            LightingOptionsPanel.Width = 0;
            SettingsPanel.Width = 0;
        }

        private string GetSelectedOption() {
            Control.ControlCollection sidebarItems = Sidebar.Controls;
            foreach(Control c in sidebarItems) {
                if (c.BackColor == Color.Silver) {
                    return c.Name;
                }
            }
            return null;
        }

        private void LightModes_Clicked() {
            if (LightModes.BackColor == Color.Transparent) {
                ClearSidebarItems();
                LightModes.BackColor = Color.Silver;
                SlideTimer.Start();
            }
        }
        
        private void LightingOptions_Clicked() {
            if (LightingOptions.BackColor == Color.Transparent) {
                ClearSidebarItems();
                LightingOptions.BackColor = Color.Silver;
                SlideTimer.Start();
            }
        }

        private void Settings_Clicked() {
            if (Settings.BackColor == Color.Transparent) {
                ClearSidebarItems();
                Settings.BackColor = Color.Silver;
                SlideTimer.Start();
            }
        }

        private void SlideTimer_Tick(object sender, EventArgs e) {

            string selectedOption = GetSelectedOption();
            
            if (selectedOption == "LightModes" && LightModesPanel.Width < 490) {
                LightModesPanel.Width += 50;
            }
            else if (LightModesPanel.Width >= 490) {
                SlideTimer.Stop();
            }

            if (selectedOption == "LightingOptions" && LightingOptionsPanel.Width < 490) {
                LightingOptionsPanel.Width += 50;
            }
            else if (LightingOptionsPanel.Width >= 490) {
                SlideTimer.Stop();
            }

            if (selectedOption == "Settings" && SettingsPanel.Width < 490) {
                SettingsPanel.Width += 50;
            }
            else if (SettingsPanel.Width >= 490) {
                SlideTimer.Stop();
            }
        }

        //-----------Settings Panel Funtions----------------//
        private void ApplySettings_Click(object sender, EventArgs e) {

            ApplySettings.Enabled = false;

            var path = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

            if (StartWithWindows.Checked == true) {
                FileManager.SaveFile("auto_startup=", "True");
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                key.SetValue("Kronos RGB", Application.ExecutablePath.ToString());
            }
            else {
                FileManager.SaveFile("auto_startup=", "False");
                RegistryKey key = Registry.CurrentUser.OpenSubKey(path, true);
                key.DeleteValue("Kronos RGB", false);
            }

            if (StartMinimized.Checked == true) {
                FileManager.SaveFile("minimized_startup=", "True");
            }
            else {
                FileManager.SaveFile("minimized_startup=", "False");
            }
        }

        private void StartWithWindows_CheckedChanged(object sender, EventArgs e) {

            ApplySettings.Enabled = true;

            if (StartWithWindows.Checked == true) {
                StartMinimized.Enabled = true;
            }
            else {
                StartMinimized.Checked = false;
                StartMinimized.Enabled = false;
            }
        }

        private void StartMinimized_CheckedChanged(object sender, EventArgs e) {
            ApplySettings.Enabled = true;
        }

        private void ChangeDevice_Click(object sender, EventArgs e) {
            MessageBox.Show("Restart the program after a new device has been selected", "Device Change Info");
            DeviceSelectForm dsf = new DeviceSelectForm();
            dsf.ShowDialog();
        }

        //-----------Light modes Button Functions------------//

        private void Color_spectrum_Click(object sender, EventArgs e) {
            SerialDriver.serialPort.Write("color_spectrum");
            Thread.Sleep(5);
        }

        private void Color_cycle_Click(object sender, EventArgs e) {
            SerialDriver.serialPort.Write("color_cycle");
            Thread.Sleep(5);
        }

        private void Static_color_Click(object sender, EventArgs e) {
            ColorDialog colorPicker = new ColorDialog();
            colorPicker.FullOpen = true;

            if (colorPicker.ShowDialog() == DialogResult.OK) {
                int r = colorPicker.Color.R;
                int g = colorPicker.Color.G;
                int b = colorPicker.Color.B;
                SerialDriver.serialPort.Write("static=" + r + "," + g + "," + b);
                Thread.Sleep(5);
            }
        }

        private void Breathing_Click(object sender, EventArgs e) {
            BreathingForm breathingForm = new BreathingForm();
            breathingForm.Show();
        }

        private void Alternate_Click(object sender, EventArgs e) {
            AlternateForm alternateForm = new AlternateForm();
            alternateForm.Show();
        }

        private void Visor_Click(object sender, EventArgs e) {
            VisorForm visorForm = new VisorForm();
            visorForm.Show();
        }

        private void Fill_Click(object sender, EventArgs e) {

        }

        private void Sparkle_Click(object sender, EventArgs e) {

        }

        
    }
    
}
