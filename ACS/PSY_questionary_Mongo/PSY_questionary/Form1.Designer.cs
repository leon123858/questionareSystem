using System.Windows.Forms;

namespace PSY_questionary
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListNumber = new System.Windows.Forms.ListBox();
            this.progress_word = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.clear_show = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showData_all = new System.Windows.Forms.Button();
            this.outCSV_all = new System.Windows.Forms.Button();
            this.show_whichForAll = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.show_qn_name = new System.Windows.Forms.Label();
            this.showOnDatagrid = new System.Windows.Forms.Button();
            this.show_which_qn = new System.Windows.Forms.TrackBar();
            this.outCSV_one = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupbox3 = new System.Windows.Forms.GroupBox();
            this.Manual = new System.Windows.Forms.Button();
            this.edit_text = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.path_to_server = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_middle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reverse = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_which_qn)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListNumber);
            this.tabPage1.Controls.Add(this.progress_word);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.clear_show);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.backup);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "常用";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ListNumber
            // 
            this.ListNumber.Font = new System.Drawing.Font("新細明體", 13F);
            this.ListNumber.FormattingEnabled = true;
            this.ListNumber.ItemHeight = 26;
            this.ListNumber.Location = new System.Drawing.Point(15, 213);
            this.ListNumber.Name = "ListNumber";
            this.ListNumber.Size = new System.Drawing.Size(360, 160);
            this.ListNumber.TabIndex = 16;
            // 
            // progress_word
            // 
            this.progress_word.Font = new System.Drawing.Font("新細明體", 12F);
            this.progress_word.Location = new System.Drawing.Point(15, 127);
            this.progress_word.Name = "progress_word";
            this.progress_word.ReadOnly = true;
            this.progress_word.Size = new System.Drawing.Size(360, 36);
            this.progress_word.TabIndex = 15;
            this.progress_word.Text = "程式初始化:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 169);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(363, 34);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 13;
            this.progressBar.Value = 100;
            // 
            // clear_show
            // 
            this.clear_show.Location = new System.Drawing.Point(387, 317);
            this.clear_show.Name = "clear_show";
            this.clear_show.Size = new System.Drawing.Size(372, 63);
            this.clear_show.TabIndex = 12;
            this.clear_show.Text = "清除右方文字框";
            this.clear_show.UseVisualStyleBackColor = true;
            this.clear_show.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showData_all);
            this.groupBox2.Controls.Add(this.outCSV_all);
            this.groupBox2.Controls.Add(this.show_whichForAll);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(384, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 126);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "輸出單一表格合併資料";
            // 
            // showData_all
            // 
            this.showData_all.Location = new System.Drawing.Point(6, 24);
            this.showData_all.Name = "showData_all";
            this.showData_all.Size = new System.Drawing.Size(108, 96);
            this.showData_all.TabIndex = 7;
            this.showData_all.Text = "關係連結圖";
            this.showData_all.UseVisualStyleBackColor = true;
            this.showData_all.Click += new System.EventHandler(this.showData_all_Click);
            // 
            // outCSV_all
            // 
            this.outCSV_all.Enabled = false;
            this.outCSV_all.Location = new System.Drawing.Point(120, 63);
            this.outCSV_all.Name = "outCSV_all";
            this.outCSV_all.Size = new System.Drawing.Size(255, 57);
            this.outCSV_all.TabIndex = 8;
            this.outCSV_all.Text = "(多)輸出下方表格";
            this.outCSV_all.UseVisualStyleBackColor = true;
            this.outCSV_all.Click += new System.EventHandler(this.outCSV_all_Click);
            // 
            // show_whichForAll
            // 
            this.show_whichForAll.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.show_whichForAll.Location = new System.Drawing.Point(120, 28);
            this.show_whichForAll.Name = "show_whichForAll";
            this.show_whichForAll.Size = new System.Drawing.Size(255, 29);
            this.show_whichForAll.TabIndex = 9;
            this.show_whichForAll.Text = "請填寫0~8任意個數字 ex:0123";
            this.show_whichForAll.Enter += new System.EventHandler(this.Show_whichForAll_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.show_qn_name);
            this.groupBox1.Controls.Add(this.showOnDatagrid);
            this.groupBox1.Controls.Add(this.show_which_qn);
            this.groupBox1.Controls.Add(this.outCSV_one);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(381, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸出單一表格所有填答";
            // 
            // show_qn_name
            // 
            this.show_qn_name.AutoSize = true;
            this.show_qn_name.Font = new System.Drawing.Font("新細明體", 12F);
            this.show_qn_name.Location = new System.Drawing.Point(164, 118);
            this.show_qn_name.Name = "show_qn_name";
            this.show_qn_name.Size = new System.Drawing.Size(165, 24);
            this.show_qn_name.TabIndex = 7;
            this.show_qn_name.Text = "顯示第0份問卷";
            // 
            // showOnDatagrid
            // 
            this.showOnDatagrid.Location = new System.Drawing.Point(6, 24);
            this.showOnDatagrid.Name = "showOnDatagrid";
            this.showOnDatagrid.Size = new System.Drawing.Size(156, 60);
            this.showOnDatagrid.TabIndex = 3;
            this.showOnDatagrid.Text = "表格show";
            this.showOnDatagrid.UseVisualStyleBackColor = true;
            this.showOnDatagrid.Click += new System.EventHandler(this.showOnDatagrid_Click);
            // 
            // show_which_qn
            // 
            this.show_which_qn.Location = new System.Drawing.Point(9, 90);
            this.show_which_qn.Maximum = 8;
            this.show_which_qn.Name = "show_which_qn";
            this.show_which_qn.Size = new System.Drawing.Size(142, 69);
            this.show_which_qn.TabIndex = 6;
            this.show_which_qn.Scroll += new System.EventHandler(this.Show_which_qn_Scroll);
            this.show_which_qn.ValueChanged += new System.EventHandler(this.Show_which_qn_ValueChanged);
            // 
            // outCSV_one
            // 
            this.outCSV_one.Enabled = false;
            this.outCSV_one.Location = new System.Drawing.Point(168, 24);
            this.outCSV_one.Name = "outCSV_one";
            this.outCSV_one.Size = new System.Drawing.Size(187, 60);
            this.outCSV_one.TabIndex = 1;
            this.outCSV_one.Text = "(單一)輸出下方表格";
            this.outCSV_one.UseVisualStyleBackColor = true;
            this.outCSV_one.Click += new System.EventHandler(this.outCSV_one_Click);
            // 
            // backup
            // 
            this.backup.Font = new System.Drawing.Font("新細明體", 22F);
            this.backup.Location = new System.Drawing.Point(12, 14);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(363, 107);
            this.backup.TabIndex = 0;
            this.backup.Text = "備分";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupbox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "額外功能";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupbox3
            // 
            this.groupbox3.Controls.Add(this.Manual);
            this.groupbox3.Controls.Add(this.edit_text);
            this.groupbox3.Controls.Add(this.pictureBox1);
            this.groupbox3.Controls.Add(this.path_to_server);
            this.groupbox3.Controls.Add(this.label2);
            this.groupbox3.Controls.Add(this.delete_middle);
            this.groupbox3.Controls.Add(this.button1);
            this.groupbox3.Controls.Add(this.label1);
            this.groupbox3.Controls.Add(this.reverse);
            this.groupbox3.Enabled = false;
            this.groupbox3.Location = new System.Drawing.Point(3, 6);
            this.groupbox3.Name = "groupbox3";
            this.groupbox3.Size = new System.Drawing.Size(755, 382);
            this.groupbox3.TabIndex = 7;
            this.groupbox3.TabStop = false;
            this.groupbox3.Text = "請詳閱說明後謹慎使用";
            // 
            // Manual
            // 
            this.Manual.Location = new System.Drawing.Point(5, 229);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(205, 60);
            this.Manual.TabIndex = 9;
            this.Manual.Text = "軟體說明書";
            this.Manual.UseVisualStyleBackColor = true;
            this.Manual.Click += new System.EventHandler(this.Manual_Click);
            // 
            // edit_text
            // 
            this.edit_text.Location = new System.Drawing.Point(5, 165);
            this.edit_text.Name = "edit_text";
            this.edit_text.Size = new System.Drawing.Size(205, 58);
            this.edit_text.TabIndex = 8;
            this.edit_text.Text = "更改問卷說明";
            this.edit_text.UseVisualStyleBackColor = true;
            this.edit_text.Click += new System.EventHandler(this.Edit_text_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(225, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // path_to_server
            // 
            this.path_to_server.Location = new System.Drawing.Point(466, 337);
            this.path_to_server.Name = "path_to_server";
            this.path_to_server.Size = new System.Drawing.Size(283, 29);
            this.path_to_server.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "(非server無法使用關係連結圖)";
            // 
            // delete_middle
            // 
            this.delete_middle.Location = new System.Drawing.Point(5, 104);
            this.delete_middle.Name = "delete_middle";
            this.delete_middle.Size = new System.Drawing.Size(205, 55);
            this.delete_middle.TabIndex = 5;
            this.delete_middle.Text = "清空資料庫";
            this.delete_middle.UseVisualStyleBackColor = true;
            this.delete_middle.Click += new System.EventHandler(this.Delete_middle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "抓取非本地全數資料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(221, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "server備分資料庫地址";
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(5, 37);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(205, 61);
            this.reverse.TabIndex = 1;
            this.reverse.Text = "抓取備分資料庫";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("新細明體", 14F);
            this.show.Location = new System.Drawing.Point(790, 40);
            this.show.Multiline = true;
            this.show.Name = "show";
            this.show.ReadOnly = true;
            this.show.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.show.Size = new System.Drawing.Size(454, 394);
            this.show.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 444);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(1232, 517);
            this.dataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 1050);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.show);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "桌球問卷系統";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_which_qn)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupbox3.ResumeLayout(false);
            this.groupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox show;
        private System.Windows.Forms.Button backup;
        private System.Windows.Forms.Button outCSV_one;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button showOnDatagrid;
        private System.Windows.Forms.TrackBar show_which_qn;
        private System.Windows.Forms.Button showData_all;
        private Button outCSV_all;
        private TextBox show_whichForAll;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label show_qn_name;
        private Button clear_show;
        private ProgressBar progressBar;
        private TextBox progress_word;
        private ListBox ListNumber;
        private Button reverse;
        private Label label1;
        private TextBox path_to_server;
        private Button button1;
        private Label label2;
        private GroupBox groupbox3;
        private Button delete_middle;
        private PictureBox pictureBox1;
        private Button Manual;
        private Button edit_text;
    }
}

