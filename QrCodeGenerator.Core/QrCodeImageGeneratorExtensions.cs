using System;
using System.Drawing;
using System.IO;

namespace QrCodeGenerator
{
    public static class QrCodeImageGeneratorExtensions
    {
        public static Image GenerateFromFile(
            this IQrCodeImageGenerator generator, string path, string encoding, int width, int height)
        {
            var isBinary = FileFormatHelper.IsBinary(encoding);
            if (isBinary) encoding = null;
            var text = GetTextFromFile(path, isBinary);
            try
            {
                return generator.Generate(text, width, height, encoding);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"为 {path} 文件的内容创建二维码时出错：{ex.GetBaseException().Message}");
            }
        }

        private static string GetTextFromFile(string path, bool isBinary)
        {
            var file = new FileInfo(path);
            if (!file.Exists) throw new FileNotFoundException($"找不到 {path} 文件。", path);
            if (file.Length > QrCodeGeneratorConstants.MaxSizeInBytes)
                throw new InvalidOperationException(
                    $"{path} 文件大小大于 {QrCodeGeneratorConstants.MaxSizeInKibibytes} KB，无法生成可读的 QR Code。");
            try
            {
                return isBinary ? Convert.ToBase64String(File.ReadAllBytes(path)) : File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"读取 {path} 文件的内容时出错：{ex.GetBaseException().Message}", ex);
            }
        }
    }
}