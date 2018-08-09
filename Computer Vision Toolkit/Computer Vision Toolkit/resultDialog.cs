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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Vision_Toolkit
{
    public partial class resultDialog : Form
    {
        public string Selection;
        private Settings settings;

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        public resultDialog(Settings _settings)
        {
            InitializeComponent();

            settings = _settings;

            LoadBatches();
        }

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        public void LoadBatches()
        {
            try
            {

                //String Path = System.IO.Path.Combine(Environment.CurrentDirectory, "Batches");
                string Path = settings.BatchesPath;
                string[] directories = System.IO.Directory.GetDirectories(Path);

                for (int i = 0; i < directories.Length; i++)
                {
                    int num_checked = System.IO.File.ReadAllLines(directories[i] + @"\checkbox.ini").Count<string>();
                    int num_total = System.IO.Directory.GetFiles(directories[i] + @"\Detected").Count<string>();

                    //listBox1.Items.Add( num_checked.ToString() + "/" + num_total.ToString() + "\t" + System.IO.Path.GetFileName(directories[i]));

                    dataGridView1.Rows.Add( System.IO.Path.GetFileName(directories[i]), num_checked, num_total );

                }
            }
            catch
            {

            }

        }

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if(dataGridView1.SelectedRows.Count > 0)
                {
                    string temp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Selection = System.IO.Path.Combine(settings.BatchesPath, temp);
                }
                this.Close();
            }
            catch
            {

            }
        }

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        public string getSelected()
        {
            return Selection;
        }

       
    }
}
