using QrCodeGenerator.WinForms;

namespace QrCodeGenerator.NET
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var options = new QrCodeGeneratorOptions
            {
            };
            Application.Run(new QrCodeGeneratorForm(options));
        }
    }
}