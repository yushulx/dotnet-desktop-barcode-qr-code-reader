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
1. Import the project into **Visual Studio** or **Visual Studio Code**.
2. Download C++ SDK, and copy DLL files to the root of the project. Rename `DynamsoftBarcodeReaderx64.dll` to `DynamsoftBarcodeReader.dll`.
3. Set the license in `BarcodeReaderManager.cs`:

    ```C#
    string errorMsg = "";
    DBR_InitLicense("LICENSE-KEY", out errorMsg, 512);
    ```

4. Press F5 to run the application or execute the command `dotnet run` in command-line tool:

    ![.net core barcode reader](http://www.codepool.biz/wp-content/uploads/2019/11/net-core-barcode-reader.png)


## Blog
[GUI Barcode Reader: Porting .NET Framework to .NET Core](https://www.codepool.biz/net-core-gui-barcode-reader.html)
