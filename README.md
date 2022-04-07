# Desktop .NET Barcode and QR Code Reader
The samples demonstrate how to use [Dynamsoft Barcode Reader](https://www.dynamsoft.com/barcode-reader/sdk-desktop-server/) to create Desktop barcode and QR code reader applications based on **.NET Framework** and **.NET 6**.

## SDK Version
[v9.0](https://www.dynamsoft.com/barcode-reader/downloads//#desktop)

## License Activation
Click [here](https://www.dynamsoft.com/customer/license/trialLicense?product=dbr) to get a valid license key.

### Usage

### .NET Framework
1. Import the project into **Visual Studio**.
2. Install Dynamsoft Barcode Reader SDK via **Nuget**.
3. Set the license key in `BarcodeReaderManager.cs`:

    ```C#
    string errorMsg;
    BarcodeReader.InitLicense("LICENSE-KEY", out errorMsg);
    ```
4. Run the application:

    ![.net framework barcode and QR code reader](http://www.codepool.biz/wp-content/uploads/2019/11/net-framework-barcode-reader.png)

## .NET 6
1. Set the license in `Form1.cs`:

    ```C#
    BarcodeQRCodeReader.InitLicense("LICENSE-KEY");
    ```

2. Build and run the project:
    
    ```bash
    dotnet restore
    dotnet run
    ```

    ![.net core barcode reader](https://www.dynamsoft.com/codepool/img/2022/03/desktop-dotnet-barcode-qr-code-reader.png)


## Blog
[Windows Barcode and QR Code Reader: Porting .NET Framework to .NET 6](https://www.dynamsoft.com/codepool/dotnet-desktop-gui-barcode-qrcode-reader.html)
