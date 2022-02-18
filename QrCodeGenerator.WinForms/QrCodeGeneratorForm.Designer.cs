namespace QrCodeGenerator.WinForms
{
    partial class QrCodeGeneratorForm
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
            this.pboxCode = new System.Windows.Forms.PictureBox();
            this.lblSourceFilePath = new System.Windows.Forms.Label();
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCode)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxCode
            // 
            this.pboxCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxCode.Location = new System.Drawing.Point(0, 34);
            this.pboxCode.Name = "pboxCode";
            this.pboxCode.Size = new System.Drawing.Size(500, 501);
            this.pboxCode.TabIndex = 0;
            this.pboxCode.TabStop = false;
            // 
            // lblSourceFilePath
            // 
            this.lblSourceFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceFilePath.AutoSize = true;
            this.lblSourceFilePath.Location = new System.Drawing.Point(15, 11);
            this.lblSourceFilePath.Name = "lblSourceFilePath";
            this.lblSourceFilePath.Size = new System.Drawing.Size(35, 12);
            this.lblSourceFilePath.TabIndex = 1;
            this.lblSourceFilePath.Text = "&File:";
            // 
            // txtSourceFilePath
            // 
            this.txtSourceFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFilePath.Location = new System.Drawing.Point(53, 6);
            this.txtSourceFilePath.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.txtSourceFilePath.Name = "txtSourceFilePath";
            this.txtSourceFilePath.ReadOnly = true;
            this.txtSourceFilePath.Size = new System.Drawing.Size(435, 21);
            this.txtSourceFilePath.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Controls.Add(this.txtSourceFilePath, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSourceFilePath, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 34);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // QrCodeGeneratorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 535);
            this.Controls.Add(this.pboxCode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QrCodeGeneratorForm";
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCode)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCode;
        private System.Windows.Forms.Label lblSourceFilePath;
        private System.Windows.Forms.TextBox txtSourceFilePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

