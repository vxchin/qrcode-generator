using System;
using System.Configuration;

namespace QrCodeGenerator.WinForms
{
    public static class QrCodeGeneratorOptionsExtensions
    {
        public static void ApplyAppSettings(this QrCodeGeneratorOptions options)
        {
            if (options.SuppressLoadingExternalConfiguration) return;
            options.SourceFileEncoding = GetConfigValue("encoding", options.SourceFileEncoding);
            options.SourceFilePath = GetConfigValue("filePath", options.SourceFilePath);
        }

        private static string GetConfigValue(string key, string defaultValue)
        {
            var value = ConfigurationManager.AppSettings[key];
            return String.IsNullOrEmpty(value) ? defaultValue : value;
        }
    }
}