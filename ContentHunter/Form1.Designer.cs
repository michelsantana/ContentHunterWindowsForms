namespace ContentHunter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDir1 = new System.Windows.Forms.LinkLabel();
            this.txtDir1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDir2 = new System.Windows.Forms.TextBox();
            this.btnDir2 = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnAddSearch = new System.Windows.Forms.LinkLabel();
            this.lstSearch = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstIgnore = new System.Windows.Forms.ListBox();
            this.btnAddIgnore = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIgnore = new System.Windows.Forms.TextBox();
            this.lblIgnoreInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDir1
            // 
            this.btnDir1.AutoSize = true;
            this.btnDir1.Location = new System.Drawing.Point(235, 30);
            this.btnDir1.Name = "btnDir1";
            this.btnDir1.Size = new System.Drawing.Size(37, 14);
            this.btnDir1.TabIndex = 0;
            this.btnDir1.TabStop = true;
            this.btnDir1.Text = "Select";
            this.btnDir1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbDir1_Click);
            // 
            // txtDir1
            // 
            this.txtDir1.Location = new System.Drawing.Point(12, 27);
            this.txtDir1.Name = "txtDir1";
            this.txtDir1.Size = new System.Drawing.Size(217, 20);
            this.txtDir1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory to Hunt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory log/backup";
            // 
            // txtDir2
            // 
            this.txtDir2.Location = new System.Drawing.Point(12, 69);
            this.txtDir2.Name = "txtDir2";
            this.txtDir2.Size = new System.Drawing.Size(217, 20);
            this.txtDir2.TabIndex = 4;
            // 
            // btnDir2
            // 
            this.btnDir2.AutoSize = true;
            this.btnDir2.Location = new System.Drawing.Point(235, 72);
            this.btnDir2.Name = "btnDir2";
            this.btnDir2.Size = new System.Drawing.Size(37, 14);
            this.btnDir2.TabIndex = 3;
            this.btnDir2.TabStop = true;
            this.btnDir2.Text = "Select";
            this.btnDir2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbDir2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(166, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "What i\'m searching?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Replace for";
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(12, 371);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(260, 20);
            this.txtReplace.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 432);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 25);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search Only";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(142, 432);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(130, 25);
            this.btnReplace.TabIndex = 12;
            this.btnReplace.Text = "Search and replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnAddSearch
            // 
            this.btnAddSearch.AutoSize = true;
            this.btnAddSearch.Location = new System.Drawing.Point(184, 114);
            this.btnAddSearch.Name = "btnAddSearch";
            this.btnAddSearch.Size = new System.Drawing.Size(92, 14);
            this.btnAddSearch.TabIndex = 14;
            this.btnAddSearch.TabStop = true;
            this.btnAddSearch.Text = "Add to search list";
            this.btnAddSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbAddSearch_Click);
            // 
            // lstSearch
            // 
            this.lstSearch.FormattingEnabled = true;
            this.lstSearch.ItemHeight = 14;
            this.lstSearch.Location = new System.Drawing.Point(12, 153);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(260, 60);
            this.lstSearch.TabIndex = 16;
            this.lstSearch.SelectedValueChanged += new System.EventHandler(this.lstSearch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Search list";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 398);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 18);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Replace?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ignore list";
            // 
            // lstIgnore
            // 
            this.lstIgnore.FormattingEnabled = true;
            this.lstIgnore.ItemHeight = 14;
            this.lstIgnore.Location = new System.Drawing.Point(12, 277);
            this.lstIgnore.Name = "lstIgnore";
            this.lstIgnore.Size = new System.Drawing.Size(260, 60);
            this.lstIgnore.TabIndex = 23;
            this.lstIgnore.SelectedValueChanged += new System.EventHandler(this.lstIgnore_SelectedIndexChanged);
            // 
            // btnAddIgnore
            // 
            this.btnAddIgnore.AutoSize = true;
            this.btnAddIgnore.Location = new System.Drawing.Point(184, 238);
            this.btnAddIgnore.Name = "btnAddIgnore";
            this.btnAddIgnore.Size = new System.Drawing.Size(72, 14);
            this.btnAddIgnore.TabIndex = 22;
            this.btnAddIgnore.TabStop = true;
            this.btnAddIgnore.Text = "Add to ignore";
            this.btnAddIgnore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbAddIgnore_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ignore";
            // 
            // txtIgnore
            // 
            this.txtIgnore.Location = new System.Drawing.Point(12, 235);
            this.txtIgnore.Name = "txtIgnore";
            this.txtIgnore.Size = new System.Drawing.Size(166, 20);
            this.txtIgnore.TabIndex = 20;
            // 
            // lblIgnoreInfo
            // 
            this.lblIgnoreInfo.AutoSize = true;
            this.lblIgnoreInfo.ForeColor = System.Drawing.Color.Red;
            this.lblIgnoreInfo.Location = new System.Drawing.Point(55, 218);
            this.lblIgnoreInfo.Name = "lblIgnoreInfo";
            this.lblIgnoreInfo.Size = new System.Drawing.Size(13, 14);
            this.lblIgnoreInfo.TabIndex = 25;
            this.lblIgnoreInfo.Text = "?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(627, 311);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 14;
            this.lstLog.Location = new System.Drawing.Point(278, 10);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(627, 130);
            this.lstLog.TabIndex = 17;
            this.lstLog.SelectedIndexChanged += new System.EventHandler(this.lstLog_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(921, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIgnoreInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstIgnore);
            this.Controls.Add(this.btnAddIgnore);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIgnore);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.lstSearch);
            this.Controls.Add(this.btnAddSearch);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDir2);
            this.Controls.Add(this.btnDir2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDir1);
            this.Controls.Add(this.btnDir1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hunter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.LinkLabel btnDir1;
        private System.Windows.Forms.TextBox txtDir1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDir2;
        private System.Windows.Forms.LinkLabel btnDir2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.LinkLabel btnAddSearch;
        private System.Windows.Forms.ListBox lstSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstIgnore;
        private System.Windows.Forms.LinkLabel btnAddIgnore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIgnore;
        private System.Windows.Forms.Label lblIgnoreInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstLog;


    }
}

