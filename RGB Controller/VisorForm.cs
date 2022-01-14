using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB_Controller {
    public partial class VisorForm : Form {

        MainForm mainForm;

        public VisorForm() {
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
            FileManager.SaveFile("visor_value=", getRGBValue());
            FileManager.SaveFile("visor_randomized=", getCheckedValue().ToString());
            SerialDriver.serialPort.Write("visor=" + getCheckedValue() + "," + getRGBValue());
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
            if (Randomize.Checked) visorGroup.Enabled = false;
            else visorGroup.Enabled = true;
        }

        private void VisorForm_Load(object sender, EventArgs e) {
            mainForm.Enabled = false;
            FileManager.LoadFile();
        }

        private void VisorForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainForm.Enabled = true;
        }
    }
}
