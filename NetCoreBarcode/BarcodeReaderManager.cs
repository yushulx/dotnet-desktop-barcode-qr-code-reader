using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace NetFrameworkBarcode
{
    class BarcodeReaderManager
    {
        private IntPtr hBarcode;

        public BarcodeReaderManager()
        {
            hBarcode = DBR_CreateInstance();
            DBR_InitLicense(hBarcode, "LICENSE-KEY");
        }

        public void Destroy()
        {
            if (hBarcode != null)
            {
                DBR_DestroyInstance(hBarcode);
            }
        }

        public enum ImagePixelFormat
        {
            /**0:Black, 1:White */
            IPF_BINARY,

            /**0:White, 1:Black */
            IPF_BINARYINVERTED,

            /**8bit gray */
            IPF_GRAYSCALED,

            /**NV21 */
            IPF_NV21,

            /**16bit */
            IPF_RGB_565,

            /**16bit */
            IPF_RGB_555,

            /**24bit */
            IPF_RGB_888,

            /**32bit */
            IPF_ARGB_8888,

            /**48bit */
            IPF_RGB_161616,

            /**64bit */
            IPF_ARGB_16161616
        }

        public enum BarcodeFormat_2
        {
            /**No barcode format in BarcodeFormat group 2*/
            BF2_NULL = 0x00,

            /**Nonstandard barcode */
            BF2_NONSTANDARD_BARCODE = 0x01
        }

        public enum BarcodeFormat
        {
            /**All supported formats */
            BF_ALL = -32505857,

            /**Combined value of BF_CODABAR, BF_CODE_128, BF_CODE_39, BF_CODE_39_Extended, BF_CODE_93, BF_EAN_13, BF_EAN_8, INDUSTRIAL_25, BF_ITF, BF_UPC_A, BF_UPC_E; */
            BF_ONED = 0x000007FF,

            /**Combined value of BF_GS1_DATABAR_OMNIDIRECTIONAL, BF_GS1_DATABAR_TRUNCATED, BF_GS1_DATABAR_STACKED, BF_GS1_DATABAR_STACKED_OMNIDIRECTIONAL, BF_GS1_DATABAR_EXPANDED, BF_GS1_DATABAR_EXPANDED_STACKED, BF_GS1_DATABAR_LIMITED*/
            BF_GS1_DATABAR = 0x0003F800,

            /**Combined value of BF_USPSINTELLIGENTMAIL, BF_POSTNET, BF_PLANET, BF_AUSTRALIANPOST, BF_UKROYALMAIL. Not supported yet. */
            BF_POSTALCODE = 0x01F00000,

            /**Code 39 */
            BF_CODE_39 = 0x1,

            /**Code 128 */
            BF_CODE_128 = 0x2,

            /**Code 93 */
            BF_CODE_93 = 0x4,

            /**Codabar */
            BF_CODABAR = 0x8,

            /**ITF */
            BF_ITF = 0x10,

            /**EAN-13 */
            BF_EAN_13 = 0x20,

            /**EAN-8 */
            BF_EAN_8 = 0x40,

            /**UPC-A */
            BF_UPC_A = 0x80,

            /**UPC-E */
            BF_UPC_E = 0x100,

            /**Industrial 2 of 5 */
            BF_INDUSTRIAL_25 = 0x200,

            /**CODE39 Extended */
            BF_CODE_39_EXTENDED = 0x400,

            /**GS1 Databar Omnidirectional*/
            BF_GS1_DATABAR_OMNIDIRECTIONAL = 0x800,

            /**GS1 Databar Truncated*/
            BF_GS1_DATABAR_TRUNCATED = 0x1000,

            /**GS1 Databar Stacked*/
            BF_GS1_DATABAR_STACKED = 0x2000,

            /**GS1 Databar Stacked Omnidirectional*/
            BF_GS1_DATABAR_STACKED_OMNIDIRECTIONAL = 0x4000,

            /**GS1 Databar Expanded*/
            BF_GS1_DATABAR_EXPANDED = 0x8000,

            /**GS1 Databar Expaned Stacked*/
            BF_GS1_DATABAR_EXPANDED_STACKED = 0x10000,

            /**GS1 Databar Limited*/
            BF_GS1_DATABAR_LIMITED = 0x20000,

            /**Patch code. */
            BF_PATCHCODE = 0x00040000,

            /**USPS Intelligent Mail. Not supported yet. */
            BF_USPSINTELLIGENTMAIL = 0x00100000,

            /**Postnet. Not supported yet. */
            BF_POSTNET = 0x00200000,

            /**Planet. Not supported yet. */
            BF_PLANET = 0x00400000,

            /**Australian Post. Not supported yet. */
            BF_AUSTRALIANPOST = 0x00800000,

            /**UK Royal Mail. Not supported yet. */
            BF_UKROYALMAIL = 0x01000000,

            /**PDF417 */
            BF_PDF417 = 0x02000000,

            /**QRCode */
            BF_QR_CODE = 0x04000000,

            /**DataMatrix */
            BF_DATAMATRIX = 0x08000000,

            /**AZTEC */
            BF_AZTEC = 0x10000000,

            /**MAXICODE */
            BF_MAXICODE = 0x20000000,

            /**Micro QR Code*/
            BF_MICRO_QR = 0x40000000,

            /**Micro PDF417*/
            BF_MICRO_PDF417 = 0x00080000,

            /**GS1 Composite Code*/
            BF_GS1_COMPOSITE = -2147483648,

            /**No barcode format in BarcodeFormat group 1*/
            BF_NULL = 0x00
        }

        [DllImport("DynamsoftBarcodeReader")]
        public static extern IntPtr DBR_CreateInstance();

        [DllImport("DynamsoftBarcodeReader")]
        public static extern void DBR_DestroyInstance(IntPtr hBarcode);

        [DllImport("DynamsoftBarcodeReader")]
        public static extern int DBR_InitLicense(IntPtr hBarcode, string license);

        [DllImport("DynamsoftBarcodeReader")]
        public static extern int DBR_DecodeFile(IntPtr hBarcode, string filename, string template);

        [DllImport("DynamsoftBarcodeReader")]
        public static extern int DBR_FreeTextResults(ref IntPtr pTextResultArray);

        [DllImport("DynamsoftBarcodeReader")]
        public static extern void DBR_GetAllTextResults(IntPtr hBarcode, ref IntPtr pTextResultArray);
        [DllImport("DynamsoftBarcodeReader")]
        public static extern int DBR_DecodeBuffer(IntPtr hBarcode, IntPtr pBufferBytes, int width, int height, int stride, ImagePixelFormat format, string template);

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct PTextResult
        {
            BarcodeFormat emBarcodeFormat;
            public string barcodeFormatString;
            BarcodeFormat_2 barcodeFormat_2;
            string barcodeFormatString_2;
            public string barcodeText;
            IntPtr barcodeBytes;
            int barcodeBytesLength;
            IntPtr localizationResult;
            IntPtr detailedResult;
            int resultsCount;
            IntPtr results;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
            char[] reserved;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TextResultArray
        {
            public int resultsCount;
            public IntPtr results;
        }

        public string[] ReadBarcode(Bitmap bitmap)
        {
            // TextResult[] textResults = mBarcodeReader.DecodeBitmap(bitmap, "");
            // if (textResults != null)
            // {
            //     string[] results = new string[textResults.Length];
            //     int index = 0;
            //     foreach (TextResult result in textResults)
            //     {
            //         results[index++] = result.BarcodeText;
            //     }
            //     return results;
            // }

            //Create a BitmapData and Lock all pixels to be written 
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
            ImageLockMode.ReadWrite, bitmap.PixelFormat);

            ImagePixelFormat format = ImagePixelFormat.IPF_ARGB_8888;

            switch (bitmap.PixelFormat)
            {
                case PixelFormat.Format24bppRgb:
                    format = ImagePixelFormat.IPF_RGB_888;
                    break;
                case PixelFormat.Format32bppArgb:
                    format = ImagePixelFormat.IPF_ARGB_8888;
                    break;
                case PixelFormat.Format16bppRgb565:
                    format = ImagePixelFormat.IPF_RGB_565;
                    break;
                case PixelFormat.Format16bppRgb555:
                    format = ImagePixelFormat.IPF_RGB_555;
                    break;
                case PixelFormat.Format8bppIndexed:
                    format = ImagePixelFormat.IPF_GRAYSCALED;
                    break;
            }

            int ret = DBR_DecodeBuffer(hBarcode, bmpData.Scan0, bitmap.Width, bitmap.Height, bmpData.Stride, format, "");
            //Unlock the pixels
            bitmap.UnlockBits(bmpData);


            IntPtr pTextResultArray = IntPtr.Zero;

            DBR_GetAllTextResults(hBarcode, ref pTextResultArray);

            if (pTextResultArray != IntPtr.Zero)
            {
                TextResultArray results = (TextResultArray)Marshal.PtrToStructure(pTextResultArray, typeof(TextResultArray));
                int count = results.resultsCount;
                IntPtr[] barcodes = new IntPtr[count];
                Marshal.Copy(results.results, barcodes, 0, count);
                string[] resultArray = new string[count];

                for (int i = 0; i < count; i++)
                {
                    PTextResult result = (PTextResult)Marshal.PtrToStructure(barcodes[i], typeof(PTextResult));
                    resultArray[i] = result.barcodeText;
                }

                // Release memory of barcode results
                DBR_FreeTextResults(ref pTextResultArray);

                return resultArray;
            }

            return null;
        }
    }
}
