using System;
using System.Windows.Forms;
using QrCodeGenerator.Internal;

namespace QrCodeGenerator
{
    public partial class MainForm : Form
    {
        private readonly string _lblSourceFileTextPrefix;
        private readonly IQrCodeImageGenerator _generator;
        private readonly QrCodeGeneratorOptions _options;

        public MainForm(QrCodeGeneratorOptions options = null)
        {
            _options = options ?? new QrCodeGeneratorOptions();
            _options.ApplyAppSettings();
            _generator = _options.Generator ?? new QrCodeImageGenerator();

            InitializeComponent();

            _lblSourceFileTextPrefix = lblSourceFilePath.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var sourceFilePath = _options.SourceFilePath ?? GetSourceFilePathFromDialog();
            if (String.IsNullOrEmpty(sourceFilePath)) Application.Exit();

            try
            {
                pboxCode.Image = _generator.GenerateFromFile(sourceFilePath,
                    _options.SourceFileEncoding,
                    pboxCode.Width, pboxCode.Height);
                lblSourceFilePath.Text = _lblSourceFileTextPrefix + sourceFilePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "QR Code Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private static string GetSourceFilePathFromDialog()
        {
            var dialog = new OpenFileDialog { Title = "选择要生成二维码图片的文件" };
            if (dialog.ShowDialog() != DialogResult.OK) Application.Exit();

            return dialog.FileName;
        }
    }
}