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









