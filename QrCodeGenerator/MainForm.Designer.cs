namespace QrCodeGenerator
{
    partial class MainForm
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
            ((System.ComponentModel.ISupportInitialize)(this.pboxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxCode
            // 
            this.pboxCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxCode.Location = new System.Drawing.Point(0, 34);
            this.pboxCode.Name = "pboxCode";
            this.pboxCode.Size = new System.Drawing.Size(500, 500);
            this.pboxCode.TabIndex = 0;
            this.pboxCode.TabStop = false;
            // 
            // lblSourceFilePath
            // 
            this.lblSourceFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSourceFilePath.AutoSize = true;
            this.lblSourceFilePath.Location = new System.Drawing.Point(12, 9);
            this.lblSourceFilePath.Name = "lblSourceFilePath";
            this.lblSourceFilePath.Size = new System.Drawing.Size(89, 12);
            this.lblSourceFilePath.TabIndex = 1;
            this.lblSourceFilePath.Text = "Source File : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 534);
            this.Controls.Add(this.lblSourceFilePath);
            this.Controls.Add(this.pboxCode);
            this.MinimumSize = new System.Drawing.Size(516, 573);
            this.Name = "MainForm";
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCode;
        private System.Windows.Forms.Label lblSourceFilePath;
    }
}

