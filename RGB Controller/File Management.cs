using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace RGB_Controller {
    public static class FileManager {

        public static string dirPath = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Kronos RGB");
        public static string filePath = dirPath + @"\data.sv";
        static readonly MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
        static SortedDictionary<string, string> lineMap = new SortedDictionary<string, string>();
        static List<string> lineList = new List<string>();

        public static void SaveFile(string name, string value) {
            try {
                //Make sure the name includes an equal sign to prevent parsing issues
                if (!name.Contains("=")) throw new Exception("You must include an equal sign in the name when using SaveFile");

                //Create a new directory if it doesn't already exist in the users system
                if (!Directory.Exists(dirPath) || !File.Exists(filePath)) {
                    Console.WriteLine("Can't find directory or save file, created missing dir or file");
                    
                    Directory.CreateDirectory(dirPath);
                    var file = File.CreateText(filePath);
                    file.Close();
                }

                //Check if the directory and save file exists then read the file
                if (Directory.Exists(dirPath) && File.Exists(filePath)) {
                    lineList = File.ReadAllLines(filePath).ToList();
                }

                //Add all the items in lineList to lineMap if the save file and lineMap is empty
                if (lineMap.Keys.Count == 0 && lineList.Count > 0) {
                    string[] data;
                    for (int i = 0; i < lineList.Count; i++) {
                        if (lineList[i] != string.Empty) {
                            data = lineList[i].Split('=');
                            lineMap.Add(data[0] + "=", data[1]);
                        }
                    }
                }

                //If the name is already in the lineMap update its value, otherwise add the new save data to the map
                if (lineMap.Keys.Contains(name)) {
                    lineMap[name] = value;
                }
                else lineMap.Add(name, value);

                //Write everything in lineMap to the save file. If the map is empty, write to the save file directly
                using (StreamWriter sw = new StreamWriter(filePath)) {

                    if (lineMap.Keys.Count > 0) {
                        foreach (string key in lineMap.Keys) {
                            sw.WriteLine(key + lineMap[key]);
                        }
                    }
                    else sw.WriteLine(name + value);

                    sw.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        public static void LoadFile() {
          
            try {
                string text = "";
              
                if (File.Exists(filePath)) {
                    using (StreamReader sr = new StreamReader(filePath)) {
                        while (sr.Peek() > 0) {
                            text = sr.ReadLine();
                            if (text.Contains("brightness_value")) SetValue(text, 0);
                            else if (text.Contains("speed_value")) SetValue(text, 1);
                            else if (text.Contains("alternate1_value") && Application.OpenForms["AlternateForm"] != null) SetValue(text, 2);
                            else if (text.Contains("alternate2_value") && Application.OpenForms["AlternateForm"] != null) SetValue(text, 2);
                            else if (text.Contains("visor_value") && Application.OpenForms["VisorForm"] != null) SetValue(text, 3);
                            else if (text.Contains("visor_randomized") && Application.OpenForms["VisorForm"] != null) SetValue(text, 3);
                            else if (text.Contains("breathing_value") && Application.OpenForms["BreathingForm"] != null) SetValue(text, 4);
                            else if (text.Contains("breathing_randomized") && Application.OpenForms["BreathingForm"] != null) SetValue(text, 4);
                            else if (text.Contains("auto_startup")) SetValue(text, 5);
                            else if (text.Contains("minimized_startup")) SetValue(text, 5);
                            
                        }
                    }
                    Console.WriteLine("Loaded settings");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public static void checkFirstStart() {
            try {
                if (File.Exists(filePath)) {

                    string allLines;

                    using (StreamReader sr = new StreamReader(filePath)) {
                        allLines = sr.ReadToEnd();
                        sr.Close();
                    }

                    using (StreamReader sr = new StreamReader(filePath)) {

                        string line = "";

                        while (sr.Peek() > 0) {

                            line = sr.ReadLine();
                          
                            if (line.Contains("device_info=")) {

                                Console.WriteLine("Connecting to previous saved device...");
                                int b1Index = line.IndexOf('(');
                                int b2Index = line.IndexOf(')');

                                string portName = line.Substring(b1Index + 1, b2Index - b1Index - 1);
                                SerialDriver.selectedDevice = line;

                                int attempt = 0;

                                while (attempt < 20 && SerialDriver.OpenPort(portName) == false) {
                                    attempt--;
                                }
                            }
                            
                        }
                        sr.Close();
                    }

                    if (!allLines.Contains("device_info=")) {
                        Console.WriteLine("Saved device not found, prompting user for device connection...");
                        DeviceSelectForm deviceSelectForm = new DeviceSelectForm();
                        deviceSelectForm.ShowDialog();
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            
        }

        private static void SetValue(string text, int type) {
            
            int posOfEqual = text.IndexOf('=');
            string value = text.Substring(posOfEqual + 1, text.Length - posOfEqual - 1);
            AlternateForm alternateForm = Application.OpenForms["AlternateForm"] as AlternateForm;
            VisorForm visorForm = Application.OpenForms["VisorForm"] as VisorForm;
            BreathingForm breathingForm = Application.OpenForms["BreathingForm"] as BreathingForm;

            if (type == 1) {
                mainForm.SetSliderValue(1, int.Parse(value));
        
            }
            else if (type == 0) {
                mainForm.SetSliderValue(2, int.Parse(value));
            }
            else if (type == 2) {
                string[] rgbValues = value.Split(',');
                if (text.Contains("alternate1")) {
                    alternateForm.setUserColor(1, int.Parse(rgbValues[0]), int.Parse(rgbValues[1]), int.Parse(rgbValues[2]));
                }
                else {
                    alternateForm.setUserColor(2, int.Parse(rgbValues[0]), int.Parse(rgbValues[1]), int.Parse(rgbValues[2]));
                }
            }
            else if (type == 3) {
                if (text.Contains("visor_value")) {
                    string[] rgbValues = value.Split(',');
                    visorForm.setRGBValue(int.Parse(rgbValues[0]), int.Parse(rgbValues[1]), int.Parse(rgbValues[2]));
                }
                else if (text.Contains("True")){
                    visorForm.setCheckedValue(true);
                }
                else visorForm.setCheckedValue(false);
            }
            else if (type == 4) {
                if (text.Contains("breathing_value")) {
                    string[] rgbValues = value.Split(',');
                    breathingForm.setRGBValue(int.Parse(rgbValues[0]), int.Parse(rgbValues[1]), int.Parse(rgbValues[2]));
                }
                else if (text.Contains("True")) {
                    breathingForm.setCheckedValue(true);
                }
                else breathingForm.setCheckedValue(false);

            }
            else if (type == 5) {
                if (text.Contains("auto")) {
                    if (value.Equals("True")) {
                        mainForm.SetCheckBoxes(1, true);
                    }
                    else mainForm.SetCheckBoxes(1, false);
                }
                else if (text.Contains("minimized")) {
                    if (value.Equals("True")) {
                        mainForm.SetCheckBoxes(2, true);
                    }
                    else mainForm.SetCheckBoxes(2, false);
                }
            }

            else throw new Exception("Invalid value type");
            
        }

    }
}
