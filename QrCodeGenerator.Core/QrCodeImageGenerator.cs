using System;
using System.Collections.Generic;
using System.Drawing;
using ZXing;
using ZXing.QrCode;
#if NETSTANDARD
using ZXing.Windows.Compatibility;
#endif

namespace QrCodeGenerator
{
    public class QrCodeImageGenerator : IQrCodeImageGenerator
    {
        public virtual Image Generate(string text, int width, int height, string encoding)
        {
            var qrCodeWriter = new QRCodeWriter();
            IDictionary<EncodeHintType, object> hints = new Dictionary<EncodeHintType, object>();
            if (!String.IsNullOrEmpty(encoding))
            {
                hints[EncodeHintType.CHARACTER_SET] = encoding;
            }
            var matrix = qrCodeWriter.encode(text, BarcodeFormat.QR_CODE, width, height, hints);
            var barCodeWriter = new BarcodeWriter();
            return barCodeWriter.Write(matrix);
        }
    }
}