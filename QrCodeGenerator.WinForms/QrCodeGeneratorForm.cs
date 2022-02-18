using System;
using System.Drawing;
using System.Windows.Forms;

namespace QrCodeGenerator.WinForms
{
    public partial class QrCodeGeneratorForm : Form
    {
        private readonly IQrCodeGenerationExecutor _executor;
        private readonly QrCodeGeneratorOptions _options;

        private QrCodeGenerationResult _result;

        public QrCodeGeneratorForm(QrCodeGeneratorOptions options = null)
        {
            _options = options ?? new QrCodeGeneratorOptions();
            _options.ApplyAppSettings();
            _executor = _options.Executor ?? new WinFormsQrCodeGenerationExecutor();

            InitializeComponent();
        }

        public QrCodeGeneratorForm(QrCodeGenerationResult result)
        {
            _result = result;
            InitializeComponent();
        }

        private void InitializeLayout()
        {
            ClientSize = new Size(_options.ImageSize, _options.ImageSize + pboxCode.Location.Y);
            pboxCode.Size = new Size(_options.ImageSize, _options.ImageSize);
            MinimumSize = Size;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            Text = _options.FormTitle ?? Text;
            try
            {
                _result = _result ?? _executor?.Execute(pboxCode.Width, pboxCode.Height, _options);
                if (_result is null)
                {
                    Close();
                    return;
                }
                if (!_result.IsSuccess) throw new Exception(_result.ErrorMessage);
                pboxCode.BackgroundImage = _result.Image;
                txtSourceFilePath.Text = _result.FilePath;
                txtSourceFilePath.SelectionStart = txtSourceFilePath.Text.Length;

                InitializeLayout();
                BringToTop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void BringToTop()
        {
            //Checks if the method is called from UI thread or not
            if (InvokeRequired)
            {
                Invoke(new Action(BringToTop));
            }
            else
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                }
                //Keeps the current topmost status of form
                var top = TopMost;
                //Brings the form to top
                TopMost = true;
                //Set form's topmost status back to whatever it was
                TopMost = top;
            }
        }
    }
}