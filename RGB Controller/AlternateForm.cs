using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB_Controller {
    public partial class AlternateForm : Form {

        MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
        ColorDialog colorDialog1 = new ColorDialog();
        ColorDialog colorDialog2 = new ColorDialog();

        public AlternateForm() {
            InitializeComponent();
            colorDialog1.FullOpen = true;
            colorDialog2.FullOpen = true;
        }

        private void UserColor1_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                UserColor1.BackColor = colorDialog1.Color;
            }
        }

        private void UserColor2_Click(object sender, EventArgs e) {
            if (colorDialog2.ShowDialog() == DialogResult.OK) {
                UserColor2.BackColor = colorDialog2.Color;
            }
        }

        public void setUserColor(int usercolor, int r, int g, int b) {
            if (usercolor == 1) {
                UserColor1.BackColor = Color.FromArgb(255, r, g, b);
            }
            else UserColor2.BackColor = Color.FromArgb(255, r, g, b);
        } 

        private void Apply_Click(object sender, EventArgs e) {
            FileManager.SaveFile("alternate1_value=", getRGBValues(1));
            FileManager.SaveFile("alternate2_value=", getRGBValues(2));
            SerialDriver.serialPort.Write("alternate=" + getRGBValues(1) + "," + getRGBValues(2));
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e) {
            Close();
        }

        public string getRGBValues(int userColor) {
            if (userColor == 1) {
                int r = UserColor1.BackColor.R;
                int g = UserColor1.BackColor.G;
                int b = UserColor1.BackColor.B;
                return r + "," + g + "," + b;
            }
            else if (userColor == 2) {
                int r = UserColor2.BackColor.R;
                int g = UserColor2.BackColor.G;
                int b = UserColor2.BackColor.B;
                return r + "," + g + "," + b;
            }
            else throw new Exception("invalid user color");
        }

        private void AlternateForm_Load(object sender, EventArgs e) {
            FileManager.LoadFile();
            mainForm.Enabled = false;
        }

        private void AlternateForm_FormClosed(object sender, FormClosedEventArgs e) {
            mainForm.Enabled = true;
        }
    }
}
