using System;
using System.Collections.Generic;
using System.IO;


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
            logFile = Environment.CurrentDirectory + @"\bin\error.log";
            string[] code_str = File.ReadAllLines(Environment.CurrentDirectory + @"\bin\codes.ini");
            codes = new Dictionary<string, Tuple<string, string>>();

            //Store codes in dictionary
            foreach(string str in code_str)
            {
                if (str.StartsWith("#")) continue;

                string[] entry = str.Split(':');
                if (entry[0] == "e")
                    codes.Add(entry[1], Tuple.Create(entry[2], entry[3]) );
                else continue;
            }
           
        }

        public void Report(string code)
        {
            using (TextWriter w = File.AppendText(logFile)) {
                w.WriteLine("[{0}] || {1} || {2} : {3}", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"), codes[code].Item1, code, codes[code].Item2 );
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
            logFile = Environment.CurrentDirectory + @"\bin\status.log";
            string[] code_str = File.ReadAllLines(Environment.CurrentDirectory + @"\bin\codes.ini");
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

        public void Report(string code)
        {
            using (TextWriter w = File.AppendText(logFile))
            {
                w.WriteLine("[{0}] || {1} || {2} : {3}", DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"), codes[code].Item1, code, codes[code].Item2);
            }
        }

    }   //Status class






}









