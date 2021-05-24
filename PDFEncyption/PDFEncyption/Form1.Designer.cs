namespace PDFEncyption
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SrcPathBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DesEncrypPathText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenFilPassWText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PerrmisionPassText = new System.Windows.Forms.TextBox();
            this.EncryptionBtn = new System.Windows.Forms.Button();
            this.DesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件：";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(148, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "请选择待加密PDF文件";
            // 
            // SrcPathBtn
            // 
            this.SrcPathBtn.Location = new System.Drawing.Point(604, 53);
            this.SrcPathBtn.Name = "SrcPathBtn";
            this.SrcPathBtn.Size = new System.Drawing.Size(75, 23);
            this.SrcPathBtn.TabIndex = 2;
            this.SrcPathBtn.Text = "选择文件";
            this.SrcPathBtn.UseVisualStyleBackColor = true;
            this.SrcPathBtn.Click += new System.EventHandler(this.SrcPathBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "加密文件路径：\r\n";
            // 
            // DesEncrypPathText
            // 
            this.DesEncrypPathText.Enabled = false;
            this.DesEncrypPathText.Location = new System.Drawing.Point(148, 88);
            this.DesEncrypPathText.Name = "DesEncrypPathText";
            this.DesEncrypPathText.Size = new System.Drawing.Size(428, 21);
            this.DesEncrypPathText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "文件打开密码：";
            // 
            // OpenFilPassWText
            // 
            this.OpenFilPassWText.Location = new System.Drawing.Point(148, 128);
            this.OpenFilPassWText.Name = "OpenFilPassWText";
            this.OpenFilPassWText.Size = new System.Drawing.Size(200, 21);
            this.OpenFilPassWText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "权限更改密码：";
            // 
            // PerrmisionPassText
            // 
            this.PerrmisionPassText.Location = new System.Drawing.Point(148, 164);
            this.PerrmisionPassText.Name = "PerrmisionPassText";
            this.PerrmisionPassText.Size = new System.Drawing.Size(200, 21);
            this.PerrmisionPassText.TabIndex = 9;
            // 
            // EncryptionBtn
            // 
            this.EncryptionBtn.Location = new System.Drawing.Point(47, 213);
            this.EncryptionBtn.Name = "EncryptionBtn";
            this.EncryptionBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptionBtn.TabIndex = 10;
            this.EncryptionBtn.Text = "文档加密";
            this.EncryptionBtn.UseVisualStyleBackColor = true;
            this.EncryptionBtn.Click += new System.EventHandler(this.EncryptionBtn_Click);
            // 
            // DesBtn
            // 
            this.DesBtn.Location = new System.Drawing.Point(604, 90);
            this.DesBtn.Name = "DesBtn";
            this.DesBtn.Size = new System.Drawing.Size(75, 23);
            this.DesBtn.TabIndex = 11;
            this.DesBtn.Text = "目标路径";
            this.DesBtn.UseVisualStyleBackColor = true;
            this.DesBtn.Click += new System.EventHandler(this.DesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 283);
            this.Controls.Add(this.DesBtn);
            this.Controls.Add(this.EncryptionBtn);
            this.Controls.Add(this.PerrmisionPassText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OpenFilPassWText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DesEncrypPathText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SrcPathBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PDFEncryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SrcPathBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DesEncrypPathText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OpenFilPassWText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PerrmisionPassText;
        private System.Windows.Forms.Button EncryptionBtn;
        private System.Windows.Forms.Button DesBtn;
    }
}

