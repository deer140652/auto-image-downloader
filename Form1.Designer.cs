namespace 自動儲存圖片
{
    partial class txtSaveFolder
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.rtbImageUrls = new System.Windows.Forms.RichTextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPageUrl = new System.Windows.Forms.TextBox();
            this.btnGetImageUrls = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExtractImageUrls = new System.Windows.Forms.Button();
            this.rtbRawContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClearRawContent = new System.Windows.Forms.Button();
            this.btnClearImageUrls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDownload.Location = new System.Drawing.Point(391, 716);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(92, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "開始下載圖片";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbImageUrls
            // 
            this.rtbImageUrls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbImageUrls.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbImageUrls.Location = new System.Drawing.Point(38, 446);
            this.rtbImageUrls.Name = "rtbImageUrls";
            this.rtbImageUrls.Size = new System.Drawing.Size(715, 250);
            this.rtbImageUrls.TabIndex = 1;
            this.rtbImageUrls.Text = "";
            this.rtbImageUrls.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(769, 50);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(92, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "選擇資料夾";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(38, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(715, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "儲存路徑：";
            // 
            // textBoxPageUrl
            // 
            this.textBoxPageUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPageUrl.Location = new System.Drawing.Point(38, 108);
            this.textBoxPageUrl.Name = "textBoxPageUrl";
            this.textBoxPageUrl.Size = new System.Drawing.Size(715, 22);
            this.textBoxPageUrl.TabIndex = 5;
            // 
            // btnGetImageUrls
            // 
            this.btnGetImageUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetImageUrls.Location = new System.Drawing.Point(769, 108);
            this.btnGetImageUrls.Name = "btnGetImageUrls";
            this.btnGetImageUrls.Size = new System.Drawing.Size(92, 23);
            this.btnGetImageUrls.TabIndex = 6;
            this.btnGetImageUrls.Text = "擷取圖片網址";
            this.btnGetImageUrls.UseVisualStyleBackColor = true;
            this.btnGetImageUrls.Click += new System.EventHandler(this.buttonGetImageUrls_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "方法1. 網頁網址：";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.Aqua;
            this.btnHelp.Location = new System.Drawing.Point(769, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(92, 30);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "使用說明";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExtractImageUrls
            // 
            this.btnExtractImageUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtractImageUrls.Location = new System.Drawing.Point(769, 259);
            this.btnExtractImageUrls.Name = "btnExtractImageUrls";
            this.btnExtractImageUrls.Size = new System.Drawing.Size(92, 23);
            this.btnExtractImageUrls.TabIndex = 9;
            this.btnExtractImageUrls.Text = "整理圖片網址";
            this.btnExtractImageUrls.UseVisualStyleBackColor = true;
            this.btnExtractImageUrls.Click += new System.EventHandler(this.btnExtractImageUrls_Click);
            // 
            // rtbRawContent
            // 
            this.rtbRawContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRawContent.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtbRawContent.Location = new System.Drawing.Point(38, 159);
            this.rtbRawContent.Name = "rtbRawContent";
            this.rtbRawContent.Size = new System.Drawing.Size(719, 250);
            this.rtbRawContent.TabIndex = 10;
            this.rtbRawContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "方法3. 圖片網址清單：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "方法2. 原始內容：";
            // 
            // btnClearRawContent
            // 
            this.btnClearRawContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearRawContent.Location = new System.Drawing.Point(769, 288);
            this.btnClearRawContent.Name = "btnClearRawContent";
            this.btnClearRawContent.Size = new System.Drawing.Size(92, 23);
            this.btnClearRawContent.TabIndex = 13;
            this.btnClearRawContent.Text = "清空";
            this.btnClearRawContent.UseVisualStyleBackColor = true;
            this.btnClearRawContent.Click += new System.EventHandler(this.btnClearRawContent_Click);
            // 
            // btnClearImageUrls
            // 
            this.btnClearImageUrls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearImageUrls.Location = new System.Drawing.Point(769, 561);
            this.btnClearImageUrls.Name = "btnClearImageUrls";
            this.btnClearImageUrls.Size = new System.Drawing.Size(92, 23);
            this.btnClearImageUrls.TabIndex = 14;
            this.btnClearImageUrls.Text = "清空";
            this.btnClearImageUrls.UseVisualStyleBackColor = true;
            this.btnClearImageUrls.Click += new System.EventHandler(this.btnClearImageUrls_Click);
            // 
            // txtSaveFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 752);
            this.Controls.Add(this.btnClearImageUrls);
            this.Controls.Add(this.btnClearRawContent);
            this.Controls.Add(this.rtbRawContent);
            this.Controls.Add(this.btnExtractImageUrls);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGetImageUrls);
            this.Controls.Add(this.textBoxPageUrl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.rtbImageUrls);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "txtSaveFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自動下載圖";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox rtbImageUrls;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPageUrl;
        private System.Windows.Forms.Button btnGetImageUrls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExtractImageUrls;
        private System.Windows.Forms.RichTextBox rtbRawContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearRawContent;
        private System.Windows.Forms.Button btnClearImageUrls;
    }
}

