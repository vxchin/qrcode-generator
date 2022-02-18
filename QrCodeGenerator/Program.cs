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
            IQrCodeGenerationExecutor executor = new WinFormsQrCodeGenerationExecutor();
            //var result = executor.Execute(500, 500, options);
            Application.Run(new QrCodeGeneratorForm());
        }
    }
}
