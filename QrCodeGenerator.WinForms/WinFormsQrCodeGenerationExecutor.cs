using System;
using System.Windows.Forms;

namespace QrCodeGenerator.WinForms
{
    public class WinFormsQrCodeGenerationExecutor : IQrCodeGenerationExecutor
    {
        public QrCodeGenerationResult Execute(int width, int height, QrCodeGeneratorOptions options = null)
        {
            options = options ?? new QrCodeGeneratorOptions();
            options.ApplyAppSettings();

            var generator = options.Generator ?? new QrCodeImageGenerator();
            var sourceFilePath = options.SourceFilePath ?? GetSourceFilePathFromDialog();
            if (String.IsNullOrEmpty(sourceFilePath)) return null;

            try
            {
                var image = generator.GenerateFromFile(sourceFilePath, options.SourceFileEncoding, width, height);
                return QrCodeGenerationResult.Succeed(sourceFilePath, image);
            }
            catch (Exception ex)
            { return QrCodeGenerationResult.Fail(ex.Message);
            }
        }

        private static string GetSourceFilePathFromDialog()
        {
            var dialog = new OpenFileDialog { Title = "选择要生成二维码图片的文件" };
            return dialog.ShowDialog() != DialogResult.OK ? null : dialog.FileName;
        }
    }
}