using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RGB_Controller {
    public partial class DeviceSelectForm : Form {

        List<Tuple<string, string>> devices;

        public DeviceSelectForm() {
            InitializeComponent();
        }

        private void DeviceSelectForm_Load(object sender, EventArgs e) {
            deviceList.Items.Clear();
            
            devices = SerialDriver.GetDevices();
            for (int i = 0; i < devices.Count; i++) {
                deviceList.Items.Add(devices[i].Item1 + " (" + devices[i].Item2 + ")");
            }
        }

        private void Select_Click(object sender, EventArgs e) {
            if (deviceList.SelectedItem == null) {
                MessageBox.Show("No device was selected!", "Error");
            }
            else {
                int attempt = 0;
                while (attempt < 20) {
                    SerialDriver.selectedDevice = devices[deviceList.SelectedIndex].Item1 + " (" + devices[deviceList.SelectedIndex].Item2 + ")";
                    if (SerialDriver.OpenPort(devices[deviceList.SelectedIndex].Item2) == true) {
                        Close();
                        
                        break;
                    }
                    else attempt++;
                }
                if (attempt >= 20) {
                    MessageBox.Show("Failed to open port", "Error");
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e) {
            Close();
        }

    }
}
