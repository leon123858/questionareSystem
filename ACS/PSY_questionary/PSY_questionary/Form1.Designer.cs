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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.dataTransform = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.show = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progress_word = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_which_qn)).BeginInit();
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
            this.tabPage1.Controls.Add(this.progress_word);
            this.tabPage1.Controls.Add(this.progressBar);
            this.tabPage1.Controls.Add(this.clear_show);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataTransform);
            this.tabPage1.Controls.Add(this.backup);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // dataTransform
            // 
            this.dataTransform.Enabled = false;
            this.dataTransform.Location = new System.Drawing.Point(198, 6);
            this.dataTransform.Name = "dataTransform";
            this.dataTransform.Size = new System.Drawing.Size(177, 120);
            this.dataTransform.TabIndex = 2;
            this.dataTransform.Text = "插入表格到SQL";
            this.dataTransform.UseVisualStyleBackColor = true;
            this.dataTransform.Click += new System.EventHandler(this.dataTransform_Click);
            // 
            // backup
            // 
            this.backup.Location = new System.Drawing.Point(12, 6);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(180, 120);
            this.backup.TabIndex = 0;
            this.backup.Text = "備分";
            this.backup.UseVisualStyleBackColor = true;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 169);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(363, 34);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 13;
            this.progressBar.Value = 100;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 1050);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.show);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_which_qn)).EndInit();
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
        private System.Windows.Forms.Button dataTransform;
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
    }
}

