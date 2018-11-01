namespace Computer_Vision_Toolkit
{
    partial class ProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessForm));
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPercent = new System.Windows.Forms.Label();
            this.filesSelected = new System.Windows.Forms.Label();
            this.infoLog = new System.Windows.Forms.TextBox();
            this.btnBatchName = new System.Windows.Forms.Button();
            this.checkBoxIncludeVideo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAnalyze.BackColor = System.Drawing.Color.LightGray;
            this.btnAnalyze.Enabled = false;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAnalyze.Location = new System.Drawing.Point(496, 191);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(114, 33);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.LightGray;
            this.btnSelectFile.Enabled = false;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSelectFile.Location = new System.Drawing.Point(146, 19);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(114, 33);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.LightGray;
            this.btnSelectFolder.Enabled = false;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSelectFolder.Location = new System.Drawing.Point(16, 19);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(114, 33);
            this.btnSelectFolder.TabIndex = 3;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblProgressBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblProgressBar.Location = new System.Drawing.Point(13, 91);
            this.lblProgressBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(176, 18);
            this.lblProgressBar.TabIndex = 4;
            this.lblProgressBar.Text = "Waiting for file selection...";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.Location = new System.Drawing.Point(16, 113);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(594, 31);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            // 
            // lblPercent
            // 
            this.lblPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPercent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPercent.Location = new System.Drawing.Point(577, 91);
            this.lblPercent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(33, 18);
            this.lblPercent.TabIndex = 6;
            this.lblPercent.Text = "0 %";
            // 
            // filesSelected
            // 
            this.filesSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.filesSelected.ForeColor = System.Drawing.SystemColors.WindowText;
            this.filesSelected.Location = new System.Drawing.Point(265, 19);
            this.filesSelected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filesSelected.Name = "filesSelected";
            this.filesSelected.Size = new System.Drawing.Size(352, 33);
            this.filesSelected.TabIndex = 7;
            this.filesSelected.Text = "No Files Selected";
            this.filesSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLog
            // 
            this.infoLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLog.BackColor = System.Drawing.Color.LightGray;
            this.infoLog.Location = new System.Drawing.Point(16, 159);
            this.infoLog.Multiline = true;
            this.infoLog.Name = "infoLog";
            this.infoLog.ReadOnly = true;
            this.infoLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoLog.Size = new System.Drawing.Size(462, 95);
            this.infoLog.TabIndex = 8;
            this.infoLog.TabStop = false;
            // 
            // btnBatchName
            // 
            this.btnBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnBatchName.Location = new System.Drawing.Point(16, 19);
            this.btnBatchName.Name = "btnBatchName";
            this.btnBatchName.Size = new System.Drawing.Size(244, 33);
            this.btnBatchName.TabIndex = 9;
            this.btnBatchName.Text = "Create New Batch";
            this.btnBatchName.UseVisualStyleBackColor = true;
            this.btnBatchName.Click += new System.EventHandler(this.btnBatchName_Click);
            // 
            // checkBoxIncludeVideo
            // 
            this.checkBoxIncludeVideo.AutoSize = true;
            this.checkBoxIncludeVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIncludeVideo.Location = new System.Drawing.Point(79, 58);
            this.checkBoxIncludeVideo.Name = "checkBoxIncludeVideo";
            this.checkBoxIncludeVideo.Size = new System.Drawing.Size(122, 22);
            this.checkBoxIncludeVideo.TabIndex = 10;
            this.checkBoxIncludeVideo.Text = "Include Videos";
            this.checkBoxIncludeVideo.UseVisualStyleBackColor = true;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(628, 266);
            this.Controls.Add(this.checkBoxIncludeVideo);
            this.Controls.Add(this.btnBatchName);
            this.Controls.Add(this.infoLog);
            this.Controls.Add(this.filesSelected);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnAnalyze);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(644, 305);
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label filesSelected;
        private System.Windows.Forms.TextBox infoLog;
        private System.Windows.Forms.Button btnBatchName;
        private System.Windows.Forms.CheckBox checkBoxIncludeVideo;
    }
}