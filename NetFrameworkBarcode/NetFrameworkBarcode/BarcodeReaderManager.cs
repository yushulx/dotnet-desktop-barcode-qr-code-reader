using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dynamsoft.Barcode;
using System.Drawing;

namespace NetFrameworkBarcode
{
    class BarcodeReaderManager
    {
        private BarcodeReader mBarcodeReader;

        public BarcodeReaderManager()
        {
            mBarcodeReader = new BarcodeReader("LICENSE-KEY");
        }

        public string[] ReadBarcode(Bitmap bitmap)
        {
            TextResult[] textResults = mBarcodeReader.DecodeBitmap(bitmap, "");
            
            if (textResults != null)
            {
                string[] results = new string[textResults.Length];
                int index = 0;
                foreach (TextResult result in textResults)
                {
                    results[index++] = result.BarcodeText;
                }
                return results;
            }

            return null;
        }
    }
}
