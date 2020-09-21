namespace Resort_Data
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.NumericUpDown();
            this.now_data = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_header = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Read
            // 
            this.Read.Font = new System.Drawing.Font("新細明體", 15F);
            this.Read.Location = new System.Drawing.Point(236, 261);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(260, 62);
            this.Read.TabIndex = 0;
            this.Read.Text = "讀取資料";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(232, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "問卷有幾種:";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(374, 226);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(120, 29);
            this.count.TabIndex = 3;
            // 
            // now_data
            // 
            this.now_data.Font = new System.Drawing.Font("新細明體", 15F);
            this.now_data.Location = new System.Drawing.Point(236, 329);
            this.now_data.Name = "now_data";
            this.now_data.Size = new System.Drawing.Size(260, 62);
            this.now_data.TabIndex = 4;
            this.now_data.Text = "目前資料";
            this.now_data.UseVisualStyleBackColor = true;
            this.now_data.Click += new System.EventHandler(this.now_data_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("新細明體", 23F);
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(722, 46);
            this.title.TabIndex = 5;
            this.title.Text = "點擊網頁輸出txt檔可以存入目標csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 26F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(109, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 68);
            this.label2.TabIndex = 6;
            this.label2.Text = "問卷轉換程式(簡化版)";
            // 
            // add_header
            // 
            this.add_header.Font = new System.Drawing.Font("新細明體", 12F);
            this.add_header.Location = new System.Drawing.Point(617, 371);
            this.add_header.Name = "add_header";
            this.add_header.Size = new System.Drawing.Size(129, 35);
            this.add_header.TabIndex = 7;
            this.add_header.Text = "添加標頭";
            this.add_header.UseVisualStyleBackColor = true;
            this.add_header.Click += new System.EventHandler(this.add_header_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 413);
            this.Controls.Add(this.add_header);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.now_data);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Read);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "問卷轉換程式";
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown count;
        private System.Windows.Forms.Button now_data;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_header;
    }
}

