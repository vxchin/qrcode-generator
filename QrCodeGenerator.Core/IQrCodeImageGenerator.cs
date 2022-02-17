using System.Drawing;

namespace QrCodeGenerator
{
    public interface IQrCodeImageGenerator
    {
        Image Generate(string text, int width, int height, string encoding);
    }
}