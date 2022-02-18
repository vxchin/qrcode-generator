using System.ComponentModel;

namespace QrCodeGenerator
{
    /// <summary>
    /// 一组用于应用程序的选项。
    /// </summary>
    public class QrCodeGeneratorOptions
    {
        /// <summary>
        /// 来源文件的相对路径。
        /// </summary>
        public string SourceFilePath { get; set; }

        /// <summary>
        /// 来源文件的编码。设置为 binary 时表示将来源文件当做二进制文件读取，并进行 base64 编码处理。
        /// </summary>
        public string SourceFileEncoding { get; set; }

        /// <summary>
        /// 二维码图片的边长，默认为 500px。
        /// </summary>
        [DefaultValue(500)]
        public int ImageSize { get; set; } = 500;

        /// <summary>
        /// 指定二维码展示窗体的标题。
        /// </summary>
        public string FormTitle { get; set; }

        /// <summary>
        /// 指示是否禁止程序根据来自外部的配置文件改变应用程序的其他选项。
        /// </summary>
        public bool SuppressLoadingExternalConfiguration { get; set; }

        /// <summary>
        /// 自定义的二维码图片生成器，默认为空，即使用默认实现。
        /// </summary>
        public IQrCodeImageGenerator Generator { get; set; }

        /// <summary>
        /// 自定义的二维码图片生成操作执行器，默认为空，即使用默认实现。
        /// </summary>
        public IQrCodeGenerationExecutor Executor { get; set; }
    }
}