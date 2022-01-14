using System;
using System.Windows.Forms;
using System.Management;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace RGB_Controller {
    public static class SerialDriver {

        public static List<Tuple<string, string>> deviceManagerList = new List<Tuple<string, string>>();
        public static SerialPort serialPort;
        public static string selectedDevice;
        public static Thread serialThread;
        static readonly MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
                
         /* For the deviceName, use the name of the microcontroller in Device Manager not including the com port name.
            For example, use 'Arduino Uno' and NOT 'Arduino Uno (COM13)'. */
          
        //static string deviceName = "Maple Serial";

        public static List<Tuple<string, string>> GetDevices() {
            ManagementObjectCollection mocList;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * From Win32_SerialPort");
            mocList = mos.Get();

            if (deviceManagerList.Count > 0) deviceManagerList.Clear();

            foreach (ManagementObject obj in mocList) {
                string comName = obj["Name"].ToString();
                comName = comName.Substring(comName.IndexOf("(") + 1, comName.IndexOf(")") - comName.IndexOf("(") - 1);

                try {
                    deviceManagerList.Add(Tuple.Create(obj["Description"].ToString(), comName));
                }
                catch (ArgumentException e) {
                    Console.WriteLine(e.Message.ToString());
                }
            }

            return deviceManagerList;
        }

        public static bool OpenPort(string portNumber) {
            Console.WriteLine(portNumber);
            
            if (serialThread != null) {
                serialThread.Abort();
                serialPort.Close();
            }

            try {
                serialPort = new SerialPort(portNumber, 115200) {
                    RtsEnable = true,
                    DtrEnable = true,
                    WriteTimeout = 30,
                    ReadTimeout = 30
                };
                serialPort.Open();

                //Try connecting to the arduino 20 times, and show the missing device dialog if it fails

                int attempt = 0;
                while (CheckConnection() == false) {
                    Thread.Sleep(1000);
                    attempt++;
                    if (attempt >= 20) {
                        attempt = 0;
                        MessageBox.Show("Connection request failed", "Error");
                        break;
                    }
                }

            }

            catch (Exception e) {
                Console.WriteLine(e.Message.ToString());
                return false;
            }
            return true;
        }

        private static bool CheckConnection() {
            Console.WriteLine("Requesting connection to device...");
            serialPort.Write("req_con");
            Thread.Sleep(5);

            string reply = "";
            
            Console.WriteLine("Bytes received: " + serialPort.BytesToRead + "\n");

            while (serialPort.BytesToRead > 0) {
                reply += (char)serialPort.ReadByte();
            }

            if (reply.Contains("req_rec")) {
                Console.WriteLine("Received reply from device. Starting Kronos RGB...");

                //Enable user input and start reading any data from the device in a seperate thread
                Console.WriteLine("Connected to " + selectedDevice);
                FileManager.SaveFile("device_info=", selectedDevice);
                serialThread = new Thread(ReadSerial);
                serialThread.Start();

                //Set the animation speed
                float value = mainForm.speedSlider.Value;
                value = (value / 100) * 255;
                value = (float)Math.Floor(value);
                serialPort.Write("speed=" + value.ToString());
                Thread.Sleep(100);

                //Set the brightness
                float brightValue = mainForm.brightnessSlider.Value;
                brightValue = (brightValue / 100) * 255;
                brightValue = (float)Math.Floor(brightValue);
                serialPort.Write("bright=" + brightValue.ToString());
                Thread.Sleep(100);

                mainForm.DisableGroups(false);

                return true;
            }

            return false;
        }

        private static void ReadSerial() {
            Console.WriteLine("Waiting for messages from device... \n");
            string data = "";
            while (true) {
                Thread.Sleep(50);
                try {
                    if (serialPort.BytesToRead > 0) {
                        data += (char)serialPort.ReadByte();
                        if (serialPort.BytesToRead == 0 && data != "") {
                            Console.WriteLine("RECEIVED: " + data);
                            data = "";
                        }
                    }
                }
                catch (System.InvalidOperationException e) {

                }
            }
        }


    }
}