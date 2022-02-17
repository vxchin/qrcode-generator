# qrcode-generator

一个简单的二维码（QR-Code）生成工具，快速地为指定的文件内容创建二维码并显示在屏幕上。

## 主要特点

- 基于 .NET Framework 4.0+，可以在包括 Windows XP 在内的各版本 Windows 上运行。
- 支持单 EXE 文件运行，除了 .NET Framework 运行时外，不需要任何配置文件与动态链接库。
- 支持在代码、配置文件中指定文件路径和编码方式。

## 使用方式

1. 使用默认配置直接编译/运行程序后，程序将显示打开文件对话框。用户选择文件后，程序将对文件内容以二进制的方式读取出来，并进行 binary 编码，再转换为二维码显示在屏幕上。
2. 可在 `app.config` 文件（即 `<applicationName>.exe.config` 文件）中配置调整程序行为：
   - `filePath`: 指定该属性后，程序不再显示打开文件对话框，而是直接读取指定路径中的文件。
   - `encoding`: 指定来源文本的编码方式，默认值为空。可指定的可选值包括 `binary`、`GB2312`、`UTF-8` 等，不区分大小写。
     - 当未指定该设置值时，即表示具体编码方式由底层实现决定，一般为 `ISO-8859-1`。
     - 当指定编码为 `binary` 时，表示将来源文件以二级制的方式读取，并进行 base64 编码。
     - 指定其他值时，所指定的值将直接传递给底层实现。
3. 为了在不使用配置文件的场景下改变程序的行为，也可以通过在 `Program.cs` 中调整 `QrCodeGeneratorOptions` 的各个属性值，以改变程序行为。可配置的选项除了前述内容外，还包括：
   - `SuppressLoadingExternalConfiguration`: 设置是否禁止程序从 `app.config` 等处加载选项以调整程序的行为。默认为 `false`，即不禁止。
   - `Generator`: 指定一个自定义的二维码图片生成器实现。默认为 `null`，即使用默认实现。

## 配置示例

1. 程序运行后由用户选择文件，程序以 UTF-8 编码读取该文件，并且禁止用户通过配置文件调整程序行为：

   ```csharp
   var options = new QrCodeGeneratorOptions
   {
       SourceFileEncoding = "UTF-8",
       SuppressLoadingExternalConfiguration = true
   };
   ```

2. 程序运行后自动读取二进制文件 `Samples\binary.bin`：

   - 使用配置文件：

       ```xml
       <appSettings>
           <add key="filePath" value="Samples\binary.bin" />
           <add key="encoding" value="binary" />
       </appSettings>
       ```

   - 编辑 `Program.cs`：

     ```csharp
     var options = new QrCodeGeneratorOptions {
         SourceFilePath = @"Samples\binary.bin",
     	SourceFileEncoding = "binary"
     };
     ```

3. 程序运行后自动读取仅包含简单字符的文本文件 `Samples\simple.txt`：

   - 使用配置文件：

       ```xml
       <appSettings>
           <add key="filePath" value="Samples\simple.txt" />
       </appSettings>
       ```

   - 编辑 `Program.cs`：

     ```csharp
     var options = new QrCodeGeneratorOptions {
         SourceFilePath = @"Samples\simple.txt",
     };
     ```

4. 程序运行后自动读取包含中文等复杂字符的文本文件 `Samples\complex.txt`:

   - 使用配置文件：

       ```xml
       <appSettings>
           <add key="filePath" value="Samples\complex.txt" />
           <add key="encoding" value="utf-8" />
       </appSettings>
       ```

   - 编辑 `Program.cs`：

     ```csharp
     var options = new QrCodeGeneratorOptions {
         SourceFilePath = @"Samples\complex.txt",
         SourceFileEncoding = "UTF-8"
     };
     ```