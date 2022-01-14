using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace RGB_Controller {
    public partial class BreathingForm : Form {
       
        MainForm mainForm;

        public BreathingForm() {
            InitializeComponent();
            mainForm = Application.OpenForms["MainForm"] as MainForm;
        }

        private void UserColor_MouseClick(object sender, MouseEventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                UserColor.BackColor = Color.FromArgb(255, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            }
        }

        private void Apply_Click(object sender, EventArgs e) {
            FileManager.SaveFile("breathing_value=", getRGBValue());
            FileManager.SaveFile("breathing_randomized=", getCheckedValue().ToString());
            SerialDriver.serialPort.Write("breathing=" + getCheckedValue() + "," + getRGBValue());
            Thread.Sleep(5);
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        public string getRGBValue() {
            return UserColor.BackColor.R + "," + UserColor.BackColor.G + "," + UserColor.BackColor.B;
        }

        public void setRGBValue(int r, int g, int b) {
            UserColor.BackColor = Color.FromArgb(255, r, g, b);
        }

        public bool getCheckedValue() {
            return Randomize.Checked;
        }

        public void setCheckedValue(bool checkValue) {
            Randomize.Checked = checkValue;
        }

        private void Randomize_CheckStateChanged(object sender, EventArgs e) {
            if (Randomize.Checked) breathingGroup.Enabled = false;
            else breathingGroup.Enabled = true;
        }

        private void BreathingForm_Load(object sender, EventArgs e) {
            mainForm.Enabled = false;
            FileManager.LoadFile();
        }

        private void BreathingForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainForm.Enabled = true;
        }
    }
}
