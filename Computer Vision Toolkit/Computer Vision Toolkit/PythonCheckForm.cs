//=============================================================================================
//=============================================================================================
/*
                                License Agreement
                  For Computer Vision Emergency Response Toolkit
                              (BSD 3-Clause License)
    
    Copyright(c) 2018, Texas A&M Engineering Experiment Station
    All rights reserved.
    
    Redistribution and use in source and binary forms, with or without
    modification, are permitted provided that the following conditions are met:
    
    * Redistributions of source code must retain the above copyright notice, this
      list of conditions and the following disclaimer.
    
    * Redistributions in binary form must reproduce the above copyright notice,
      this list of conditions and the following disclaimer in the documentation
      and/or other materials provided with the distribution.
    
    * Neither the name of the copyright holder nor the names of its
      contributors may be used to endorse or promote products derived from
      this software without specific prior written permission.
    
    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
    AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
    IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
    DISCLAIMED.IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
    FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
    DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
    SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
    CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
    OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
    OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

*/
//=============================================================================================
//=============================================================================================




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using SystemLog;

namespace Computer_Vision_Toolkit
{
    public partial class PythonCheckForm : Form
    {
        //Logging System
        public ErrorLog elog = new ErrorLog();
        public StatusLog slog = new StatusLog();

        private Settings settings;
        private bool is_python_installed = false;
        private string[] default_python_path = { "%windir%\\py.exe", "%LocalAppData%\\Programs\\Python\\Python36\\python.exe", "%LocalAppData%\\Programs\\Python\\Python36-32\\python.exe", "%ProgramFiles%\\Python 3.6\\python.exe", "%ProgramFiles(x86)%\\Python 3.6\\python.exe" };

        public PythonCheckForm(Settings set)
        {
            InitializeComponent();
            settings = set;     
        }

        private void PythonCheckForm_Load(object sender, EventArgs e)
        {
            try
            {
                //Create a background thread for the progress bar 
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += new DoWorkEventHandler(checkForPython);
                worker.RunWorkerAsync(this);
            }
            catch (Exception err)
            {
                elog.Log(err.TargetSite.ToString(), err.Message);
                //MessageBox.Show(err.Message);
            }
        }

        private delegate void Bool(bool state);
        private void SetEnabled(bool state)
        {
            try
            {
                btnClose.Enabled = state;
            }
            catch (Exception err)
            {
                elog.Log(err.TargetSite.ToString(), err.Message);
                //MessageBox.Show(err.Message);
            }
        }

        private void SetWaitCursor(bool state)
        {
            try
            {
                this.UseWaitCursor = state;
            }
            catch (Exception err)
            {
                elog.Log(err.TargetSite.ToString(), err.Message);
                //MessageBox.Show(err.Message);
            }
        }

        private delegate void Info(string str);
        private void UpdateInfo(string str)
        {
            try
            {
                infoLabel.Text = str;
            }
            catch (Exception err)
            {
                elog.Log(err.TargetSite.ToString(), err.Message);
                //MessageBox.Show(err.Message);
            }
        }

        private void checkForPython(object sender, DoWorkEventArgs e)       //NOTE: LOOK INTO A BETTER METHOD OF CHECKING FOR VALID PYTHON INSTALLATIONS
        {
           try
            {
                //Check for Python
                if (string.IsNullOrEmpty(settings.PythonPath) || !File.Exists(settings.PythonPath))
                {
                    //Check/Install required packages
                    Invoke(new Info(UpdateInfo), "Checking Python version...");
                    string python_version = Process.Start(new ProcessStartInfo { FileName = Path.Combine(Environment.CurrentDirectory, "lib\\Setup\\checkPythonVersion.bat"), CreateNoWindow = true, UseShellExecute = false, RedirectStandardOutput = true }).StandardOutput.ReadToEnd();
                    if (python_version.Contains("Python 3.6")) // || python_version.Contains("Python 3.7")
                    {
                        Invoke(new Info(UpdateInfo), "Checking Python version......OK");

                        //Console.WriteLine("...Checking Python Packages...");
                        Invoke(new Info(UpdateInfo), "Checking Python packages...");
                        string pip_list = Process.Start(new ProcessStartInfo { FileName = Path.Combine(Environment.CurrentDirectory, "lib\\Setup\\checkPythonPackages.bat"), CreateNoWindow = true, UseShellExecute = false, RedirectStandardOutput = true }).StandardOutput.ReadToEnd();

                        //string[] required_pkgs = { "opencv-python", "numpy", "scipy", "scikit-learn", "spectral", "pyparsing", "matplotlib" };
                        List<string> required_pkgs = new List<string>();

                        string[] entries = File.ReadAllLines(@"lib\Setup\installPythonPackages.bat");
                        foreach (string str in entries)
                        {
                            //Skip comment lines
                            if (str.StartsWith("::")) continue;

                            //Remove any remaining comment sections
                            string pip_str = str.Split(':')[0];
                            string[] pkg_str = pip_str.Split(' ');

                            //Get a list of all packages that need to be installed
                            foreach( string s in pkg_str)
                            {
                                if (!s.Equals("pip3") && !s.Equals("install") && !string.IsNullOrEmpty(s) )
                                {
                                    required_pkgs.Add(s);
                                }
                            }
                        }
                       

                        foreach (string str in required_pkgs)
                        {
                            Invoke(new Info(UpdateInfo), "Checking for " + str + "...");

                            if (!pip_list.Contains(str))
                            {
                                Invoke(new Info(UpdateInfo), "Installing " + str + "...");
                                Invoke(new Bool(SetWaitCursor), true);
                                Process.Start(new ProcessStartInfo { FileName = Path.Combine(Environment.CurrentDirectory, "lib\\Setup\\installPythonPackages.bat"), CreateNoWindow = true, UseShellExecute = false }).WaitForExit();
                                break;
                            }
                        }

                        //Search for python path in the default install locations
                        foreach (string path in default_python_path)
                        {
                            if (File.Exists(Environment.ExpandEnvironmentVariables(path)))
                            {
                                settings.PythonPath = Environment.ExpandEnvironmentVariables(path);
                                break;
                            }
                        }

                        Invoke(new Info(UpdateInfo), "Python Setup Complete...");
                        settings.FirstRun = false;
                        is_python_installed = true;
                        //this.Close();
                    }
                    else
                    {
                        Invoke(new Info(UpdateInfo), "Python 3.6.4 or greater is required to analyze images.\nYou may still view results without Python installed.");
                        is_python_installed = false;
                    }      
                }
                else
                {
                    Invoke(new Info(UpdateInfo), "Finished...");
                    Invoke(new Bool(SetWaitCursor), false);
                    is_python_installed = true;
                    //this.Close();
                }

                //Re-enabled the close button
                Invoke(new Bool(SetEnabled), true);
                Invoke(new Bool(SetWaitCursor), false);
            }
            catch (Exception err)
            {
                elog.Log(err.TargetSite.ToString(), err.Message);
                //MessageBox.Show(err.Message);
            }
        }

        private void pythonLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                pythonLink.LinkVisited = true; 
                System.Diagnostics.Process.Start("https://www.python.org/downloads/release/python-364/");
            }
            catch (Exception err)
            {
                elog.Log(err.TargetSite.ToString(), err.Message);
                //MessageBox.Show(err.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = (is_python_installed) ? DialogResult.Yes : DialogResult.No;
                this.Close();
            }
            catch (Exception err)
            {
                elog.Log(err.TargetSite.ToString(), err.Message);
                //MessageBox.Show(err.Message);
            }
        }

        public Settings GetSettings()
        {
            return settings;
        }

    }
}
