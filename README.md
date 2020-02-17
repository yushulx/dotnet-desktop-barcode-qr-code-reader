# .NET Barcode Reader

The source code demonstrates how to create GUI barcode reader apps on **.NET Framework** and **.NET Core**.

## License Requirement
Register a new Dynamsoft account to get a valid [trial license](https://www.dynamsoft.com/CustomerPortal/Portal/Triallicense.aspx).

## .NET Framework Barcode Reader
Set the license:

```C#
// BarcodeReaderManager.cs
mBarcodeReader = new BarcodeReader("LICENSE-KEY");
```

Run the app in **Visual Studio 2017**:

![.net framework barcode reader](http://www.codepool.biz/wp-content/uploads/2019/11/net-framework-barcode-reader.png)

## .NET Core Barcode Reader
Set the license:

```C#
// BarcodeReaderManager.cs
DBR_InitLicense(hBarcode, "LICENSE-KEY");
```

Download [Dynamsoft Barcode Reader 7.2.2](https://www.dynamsoft.com/Downloads/Dynamic-Barcode-Reader-Download.aspx). Alternatively, you can download [DynamsoftBarcodeReader.dll](https://github.com/yushulx/net-barcode-reader/releases/download/v1.0/DynamsoftBarcodeReader.dll) directly from GitHub.

Copy `DynamsoftBarcodeReaderx64.dll` to `NetCoreBarcode` folder and rename it to `DynamsoftBarcodeReader.dll`.

Press F5 to run the app in **Visual Studio Code** or execute the command `dotnet run` via **cmd.exe**:

![.net core barcode reader](http://www.codepool.biz/wp-content/uploads/2019/11/net-core-barcode-reader.png)


## Blog
[GUI Barcode Reader: Porting .NET Framework to .NET Core](https://www.codepool.biz/net-core-gui-barcode-reader.html)
