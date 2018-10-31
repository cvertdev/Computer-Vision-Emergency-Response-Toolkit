namespace Computer_Vision_Toolkit
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.editParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimizeForViewingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSelectResults = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnNewAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptimizedMode = new System.Windows.Forms.ToolStripMenuItem();
            this.viewingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLegend = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btnMarkAsViewed = new System.Windows.Forms.Button();
            this.btnSelectResults = new System.Windows.Forms.Button();
            this.btnNewAnalysis = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenImageNewWindow = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.FlagComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearFlag = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuOptions,
            this.menuBtnSelectResults,
            this.menuBtnNewAnalysis,
            this.menuOptimizedMode});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1513, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Enabled = false;
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Visible = false;
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuOptions
            // 
            this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editParametersToolStripMenuItem,
            this.selectAlgorithmsToolStripMenuItem,
            this.optimizeForViewingToolStripMenuItem});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(73, 24);
            this.menuOptions.Text = "Options";
            // 
            // editParametersToolStripMenuItem
            // 
            this.editParametersToolStripMenuItem.Name = "editParametersToolStripMenuItem";
            this.editParametersToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.editParametersToolStripMenuItem.Text = "Edit Parameters";
            this.editParametersToolStripMenuItem.Click += new System.EventHandler(this.editParametersToolStripMenuItem_Click);
            // 
            // selectAlgorithmsToolStripMenuItem
            // 
            this.selectAlgorithmsToolStripMenuItem.Name = "selectAlgorithmsToolStripMenuItem";
            this.selectAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.selectAlgorithmsToolStripMenuItem.Text = "Select Algorithms";
            this.selectAlgorithmsToolStripMenuItem.Click += new System.EventHandler(this.selectAlgorithmsToolStripMenuItem_Click);
            // 
            // optimizeForViewingToolStripMenuItem
            // 
            this.optimizeForViewingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewingToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.optimizeForViewingToolStripMenuItem.Name = "optimizeForViewingToolStripMenuItem";
            this.optimizeForViewingToolStripMenuItem.Size = new System.Drawing.Size(195, 24);
            this.optimizeForViewingToolStripMenuItem.Text = "Optimize for...";
            // 
            // viewingToolStripMenuItem
            // 
            this.viewingToolStripMenuItem.Name = "viewingToolStripMenuItem";
            this.viewingToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.viewingToolStripMenuItem.Text = "Viewing";
            this.viewingToolStripMenuItem.Click += new System.EventHandler(this.viewingToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.analysisToolStripMenuItem.Text = "Analysis";
            this.analysisToolStripMenuItem.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // menuBtnSelectResults
            // 
            this.menuBtnSelectResults.Enabled = false;
            this.menuBtnSelectResults.Name = "menuBtnSelectResults";
            this.menuBtnSelectResults.Size = new System.Drawing.Size(157, 24);
            this.menuBtnSelectResults.Text = "Select Results Folder";
            this.menuBtnSelectResults.Visible = false;
            this.menuBtnSelectResults.Click += new System.EventHandler(this.menuBtnSelectResults_Click);
            // 
            // menuBtnNewAnalysis
            // 
            this.menuBtnNewAnalysis.BackColor = System.Drawing.Color.LightGray;
            this.menuBtnNewAnalysis.Enabled = false;
            this.menuBtnNewAnalysis.Name = "menuBtnNewAnalysis";
            this.menuBtnNewAnalysis.Size = new System.Drawing.Size(137, 24);
            this.menuBtnNewAnalysis.Text = "Run New Analysis";
            this.menuBtnNewAnalysis.Visible = false;
            this.menuBtnNewAnalysis.Click += new System.EventHandler(this.menuBtnNewAnalysis_Click);
            // 
            // menuOptimizedMode
            // 
            this.menuOptimizedMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewingToolStripMenuItem1,
            this.analysisToolStripMenuItem1});
            this.menuOptimizedMode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuOptimizedMode.Name = "menuOptimizedMode";
            this.menuOptimizedMode.ShowShortcutKeys = false;
            this.menuOptimizedMode.Size = new System.Drawing.Size(121, 24);
            this.menuOptimizedMode.Text = "Optimized for: ";
            // 
            // viewingToolStripMenuItem1
            // 
            this.viewingToolStripMenuItem1.Name = "viewingToolStripMenuItem1";
            this.viewingToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.viewingToolStripMenuItem1.Text = "Viewing";
            this.viewingToolStripMenuItem1.Click += new System.EventHandler(this.viewingToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem1
            // 
            this.analysisToolStripMenuItem1.Name = "analysisToolStripMenuItem1";
            this.analysisToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.analysisToolStripMenuItem1.Text = "Analysis";
            this.analysisToolStripMenuItem1.Click += new System.EventHandler(this.analysisToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(597, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1, 5, 1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(594, 534);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Info, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 108);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1490, 576);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxLegend, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 540);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1192, 36);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // pictureBoxLegend
            // 
            this.pictureBoxLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLegend.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLegend.Image")));
            this.pictureBoxLegend.Location = new System.Drawing.Point(435, 6);
            this.pictureBoxLegend.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLegend.Name = "pictureBoxLegend";
            this.pictureBoxLegend.Size = new System.Drawing.Size(321, 30);
            this.pictureBoxLegend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLegend.TabIndex = 5;
            this.pictureBoxLegend.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(334, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Low Anomaly";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(760, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "High Anomaly";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Flag,
            this.Checked,
            this.Image,
            this.Score});
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(1195, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(292, 534);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // Flag
            // 
            this.Flag.HeaderText = "Flag";
            this.Flag.Name = "Flag";
            this.Flag.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Flag.Width = 40;
            // 
            // Checked
            // 
            this.Checked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Checked.DefaultCellStyle = dataGridViewCellStyle37;
            this.Checked.FillWeight = 27F;
            this.Checked.HeaderText = "Viewed";
            this.Checked.Name = "Checked";
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Image.DefaultCellStyle = dataGridViewCellStyle38;
            this.Image.FillWeight = 56F;
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            // 
            // Score
            // 
            this.Score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Score.DefaultCellStyle = dataGridViewCellStyle39;
            this.Score.FillWeight = 27F;
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // lbl_Info
            // 
            this.lbl_Info.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Info.Location = new System.Drawing.Point(1285, 549);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(112, 18);
            this.lbl_Info.TabIndex = 8;
            this.lbl_Info.Text = "Mouse Position";
            // 
            // btnMarkAsViewed
            // 
            this.btnMarkAsViewed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMarkAsViewed.Location = new System.Drawing.Point(89, 1);
            this.btnMarkAsViewed.Margin = new System.Windows.Forms.Padding(1);
            this.btnMarkAsViewed.Name = "btnMarkAsViewed";
            this.btnMarkAsViewed.Size = new System.Drawing.Size(206, 35);
            this.btnMarkAsViewed.TabIndex = 6;
            this.btnMarkAsViewed.Text = "Mark As Viewed";
            this.btnMarkAsViewed.UseVisualStyleBackColor = true;
            this.btnMarkAsViewed.Click += new System.EventHandler(this.btnMarkAsViewed_Click);
            // 
            // btnSelectResults
            // 
            this.btnSelectResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectResults.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectResults.Location = new System.Drawing.Point(20, 22);
            this.btnSelectResults.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btnSelectResults.Name = "btnSelectResults";
            this.btnSelectResults.Size = new System.Drawing.Size(257, 32);
            this.btnSelectResults.TabIndex = 4;
            this.btnSelectResults.Text = "View Analysis Results";
            this.btnSelectResults.UseVisualStyleBackColor = true;
            this.btnSelectResults.Click += new System.EventHandler(this.menuBtnSelectResults_Click);
            // 
            // btnNewAnalysis
            // 
            this.btnNewAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewAnalysis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNewAnalysis.Location = new System.Drawing.Point(317, 22);
            this.btnNewAnalysis.Margin = new System.Windows.Forms.Padding(20, 4, 20, 4);
            this.btnNewAnalysis.Name = "btnNewAnalysis";
            this.btnNewAnalysis.Size = new System.Drawing.Size(257, 32);
            this.btnNewAnalysis.TabIndex = 5;
            this.btnNewAnalysis.Text = "Run New Analysis";
            this.btnNewAnalysis.UseVisualStyleBackColor = true;
            this.btnNewAnalysis.Click += new System.EventHandler(this.menuBtnNewAnalysis_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 27);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1490, 78);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnSelectResults, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnNewAnalysis, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel3.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(594, 76);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnOpenImageNewWindow);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(597, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 37);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnOpenImageNewWindow
            // 
            this.btnOpenImageNewWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOpenImageNewWindow.Location = new System.Drawing.Point(409, 1);
            this.btnOpenImageNewWindow.Margin = new System.Windows.Forms.Padding(1);
            this.btnOpenImageNewWindow.Name = "btnOpenImageNewWindow";
            this.btnOpenImageNewWindow.Size = new System.Drawing.Size(184, 35);
            this.btnOpenImageNewWindow.TabIndex = 0;
            this.btnOpenImageNewWindow.Text = "Open in New Window";
            this.btnOpenImageNewWindow.UseVisualStyleBackColor = true;
            this.btnOpenImageNewWindow.Click += new System.EventHandler(this.openImagesInNewWindowToolStripMenuItem_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.FlagComboBox, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnMarkAsViewed, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1193, 40);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(296, 37);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // FlagComboBox
            // 
            this.FlagComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FlagComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlagComboBox.ItemHeight = 18;
            this.FlagComboBox.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray"});
            this.FlagComboBox.Location = new System.Drawing.Point(1, 5);
            this.FlagComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.FlagComboBox.Name = "FlagComboBox";
            this.FlagComboBox.Size = new System.Drawing.Size(86, 26);
            this.FlagComboBox.TabIndex = 8;
            this.FlagComboBox.SelectionChangeCommitted += new System.EventHandler(this.FlagComboBox_SelectionChangeCommitted);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.Controls.Add(this.btnClearFlag, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1193, 1);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(296, 37);
            this.tableLayoutPanel6.TabIndex = 12;
            // 
            // btnClearFlag
            // 
            this.btnClearFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFlag.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClearFlag.Location = new System.Drawing.Point(1, 1);
            this.btnClearFlag.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearFlag.Name = "btnClearFlag";
            this.btnClearFlag.Size = new System.Drawing.Size(86, 35);
            this.btnClearFlag.TabIndex = 9;
            this.btnClearFlag.Text = "Clear Flag";
            this.btnClearFlag.UseVisualStyleBackColor = true;
            this.btnClearFlag.Click += new System.EventHandler(this.btnClearFlag_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1513, 696);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(1240, 735);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Vision Emergency Response Toolkit";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSelectResults;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNewAnalysis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxLegend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem menuOptions;
        private System.Windows.Forms.ToolStripMenuItem editParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optimizeForViewingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOptimizedMode;
        private System.Windows.Forms.Button btnSelectResults;
        private System.Windows.Forms.Button btnNewAnalysis;
        private System.Windows.Forms.Button btnMarkAsViewed;
        private System.Windows.Forms.ToolStripMenuItem viewingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_Info;
        private System.Windows.Forms.ToolStripMenuItem selectAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.ComboBox FlagComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClearFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnOpenImageNewWindow;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}