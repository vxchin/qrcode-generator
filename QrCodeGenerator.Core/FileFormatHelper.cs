using System;

namespace QrCodeGenerator
{
    internal static class FileFormatHelper
    {
        private const string BinaryEncodingName = "binary";

        public static bool IsBinary(string encoding) =>
            String.Equals(encoding, BinaryEncodingName, StringComparison.OrdinalIgnoreCase);
    }
}