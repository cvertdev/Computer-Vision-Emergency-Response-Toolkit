//=============================================================================================
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Vision_Toolkit
{
    public partial class batchName : Form
    {
        private string batch_name;
        private string invalid_msg = "Invalid character";
        private string valid_msg = "Please name this batch";
        private string approved_characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789()_- ";

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        public batchName(string default_batch_name)
        {
            InitializeComponent();

            batch_name = default_batch_name;

        }

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        private void batchName_Load(object sender, EventArgs e)
        {
            textBox1.Text = batch_name;
            batchLabel.Text = valid_msg;
            button1.Enabled = true;
        }

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        private void button1_Click(object sender, EventArgs e)
        {
            batch_name = textBox1.Text;
            this.Close();
        }

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        public String getText()
        {
            return batch_name;
        }

        //===================================================================================================================
        //-------------------------------------------------------------------------------------------------------------------
        //===================================================================================================================

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Check user input
            if(textBox1.Text.All(approved_characters.Contains))
            {
                batchLabel.Text = valid_msg;
                button1.Enabled = true;
            }
            else
            {
                batchLabel.Text = invalid_msg;
                button1.Enabled = false;
            }
            
            
        }
    }
}
