﻿//=============================================================================================
//=============================================================================================
//
//  By downloading, copying, installing or using the software you agree to this license.
//  If you do not agree to this license, do not download, install,
//  copy or use the software.
//  
//  
//                            License Agreement
//              For Computer Vision Emergency Response Toolkit
//                         (3-clause BSD License)
//  
//  
//  Copyright (c) 2018 Texas A&M Engineering Experiment Station, All rights reserved.
//  
//  Redistribution and use in source and binary forms, with or without
//  modification, are permitted provided that the following conditions are
//  met:
//  
//      1.	Redistributions of source code must retain the above copyright
//      notice, this list of conditions and the following disclaimer. 
//  
//      2.	Redistributions in binary form must reproduce the above copyright
//      notice, this list of conditions and the following disclaimer in
//      the documentation and/or other materials provided with the
//      distribution.  
//      
//      3.	The name of the author may not be used to
//      endorse or promote products derived from this software without
//      specific prior written permission.
//  
//  THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
//  IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
//  DISCLAIMED. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT,
//  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
//  (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
//  SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
//  HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
//  STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING
//  IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
//  POSSIBILITY OF SUCH DAMAGE. 
//
//=============================================================================================
//=============================================================================================




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Vision_Toolkit
{
    public partial class ParametersForm : Form
    {
        public List<string> paramList = new List<string>();
        public bool saved_changes = true;


        public ParametersForm()
        {
            InitializeComponent();

            //Read the parameters.ini file and load into form
            Read();
            saveStatus.Text = "Saved...";
        }

        //Read the parameters.ini file
        private void Read()
        {
            try
            {

                string[] entries = File.ReadAllLines(@"lib\parameters.ini");
                foreach (string str in entries)
                {
                    //Skip comment lines
                    if (str.StartsWith("#")) continue;

                    //Remove any remaining comment sections
                    string p_str = str.Split('#')[0];

                    string[] opt = p_str.Split('=');      //name=default=value
                    paramData.Rows.Add( opt[0], Convert.ToInt32(opt[1]), Convert.ToDouble(opt[2]), Convert.ToDouble(opt[3]));
                }
            }
            catch
            {

            }

        }

        //Save to the parameters.ini file
        private void Save()
        {
            try
            {

                paramList.Clear();
                if (paramData.Rows.Count > 0)
                {
                    //Create array of strings
                    foreach (DataGridViewRow row in paramData.Rows)
                    {
                        paramList.Add(row.Cells[0].Value + "=" + Convert.ToInt32(row.Cells[1].Value).ToString() + "=" + Convert.ToDouble(row.Cells[2].Value).ToString() + "=" + Convert.ToDouble(row.Cells[3].Value).ToString());
                    }

                    //Write string array to file
                    File.WriteAllLines(@"lib\parameters.ini", paramList.ToArray());
                }

                saved_changes = true;
                saveStatus.Text = "Saved...";
            }
            catch
            {

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void ParametersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Last chance to save
            if (!saved_changes)
            {
                if (MessageBox.Show("Any unsaved changes will be lost. Would you like to save before exitting?", "Save Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save();
            }
        }

        private void paramData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Something was changed
            saved_changes = false;
            saveStatus.Text = "Not Saved...";
            paramData.Rows[e.RowIndex].Cells[1].Value = false;
        }
    }
}
