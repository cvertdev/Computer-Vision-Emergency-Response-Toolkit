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
using System.IO;
using System.Windows.Forms;

namespace SystemLog
{
    //Errors
    public class ErrorLog
    {
        // code, flag, description
        private Dictionary<string, Tuple<string, string>> codes;
        private string logFile;

        public ErrorLog()
        {
            try
            {
                logFile = Environment.CurrentDirectory + @"\lib\Logs\error.log";
                string[] code_str = File.ReadAllLines(Environment.CurrentDirectory + @"\lib\Logs\codes.ini");
                codes = new Dictionary<string, Tuple<string, string>>();

                //Store codes in dictionary
                foreach (string str in code_str)
                {
                    if (str.StartsWith("#")) continue;

                    string[] entry = str.Split(':');
                    if (entry[0] == "e")
                        codes.Add(entry[1], Tuple.Create(entry[2], entry[3]));
                    else continue;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show( err.Message, "Error occurred when initializing the error reporting system", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        public void Report(string code)
        {
            using (TextWriter w = File.AppendText(logFile)) {
                w.WriteLine("[{0}] || {1} || {2} : {3}", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"), codes[code].Item1, code, codes[code].Item2 );
                w.Close();
            }
        }

        public void Log(string func, string msg)
        {
            using (TextWriter w = File.AppendText(logFile))
            {
                w.WriteLine("[{0}] || {1} || {2} : {3}", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"), "Error", func, msg);
                w.Close();
            }
        }
    }   //Error class




    //General status updates
    public class StatusLog
    {
        // code, flag, description
        private Dictionary<string, Tuple<string, string>> codes;
        private string logFile;

        public StatusLog()
        {
            try
            {
                logFile = Environment.CurrentDirectory + @"\lib\Logs\status.log";
                string[] code_str = File.ReadAllLines(Environment.CurrentDirectory + @"\lib\Logs\codes.ini");
                codes = new Dictionary<string, Tuple<string, string>>();

                //Store codes in dictionary
                foreach (string str in code_str)
                {
                    if (str.StartsWith("#")) continue;

                    string[] entry = str.Split(':');
                    if (entry[0] == "s")
                        codes.Add(entry[1], Tuple.Create(entry[2], entry[3]));
                    else continue;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error occurred when initializing the status reporting system", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Report(string code)
        {
            using (TextWriter w = File.AppendText(logFile))
            {
                w.WriteLine("[{0}] || {1} || {2} : {3}", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"), codes[code].Item1, code, codes[code].Item2);
                w.Close();
            }
        }

        public void Log(string str)
        {
            using (TextWriter w = File.AppendText(logFile))
            {
                w.WriteLine("[{0}] || {1} : {2}", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"), "General", str);
                w.Close();
            }
        }
    }   //Status class

}









