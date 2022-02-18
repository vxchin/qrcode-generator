using System;
using System.Drawing;

namespace QrCodeGenerator
{
    public class QrCodeGenerationResult
    {
        private QrCodeGenerationResult(string filePath = null, Image image = null, string errorMessage = null)
        {
            FilePath = filePath;
            Image = image;
            ErrorMessage = errorMessage;
        }

        public string FilePath { get; }

        public Image Image { get; }

        public string ErrorMessage { get; }

        public bool IsSuccess => String.IsNullOrEmpty(ErrorMessage);

        public static QrCodeGenerationResult Succeed(string filePath, Image image)
        {
            return new QrCodeGenerationResult(filePath, image);
        }

        public static QrCodeGenerationResult Fail(string errorMessage)
        {
            return new QrCodeGenerationResult(errorMessage: errorMessage);
        }
    }
}