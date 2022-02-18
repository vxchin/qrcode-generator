namespace QrCodeGenerator
{
    public interface IQrCodeGenerationExecutor
    {
        QrCodeGenerationResult Execute(int width, int height, QrCodeGeneratorOptions options = null);
    }
}
