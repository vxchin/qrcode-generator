using System;
using System.Windows.Forms;
using QrCodeGenerator.WinForms;

namespace QrCodeGenerator
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var options = new QrCodeGeneratorOptions
            {
            };
            Application.Run(new QrCodeGeneratorForm(options));
        }
    }
}
