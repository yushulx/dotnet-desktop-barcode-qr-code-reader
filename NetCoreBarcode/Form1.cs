using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetFrameworkBarcode
{
    public partial class Form1 : Form
    {
        private BarcodeReaderManager mBarcodeReaderManager;

        public Form1()
        {
            InitializeComponent();

            mBarcodeReaderManager = new BarcodeReaderManager();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
                base.OnFormClosing(e);
                // Code
                mBarcodeReaderManager.Destroy();
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image files (*.bmp, *.jpg, *.png) | *.bmp; *.jpg; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = null;
                    
                    try
                    {
                        bitmap = new Bitmap(dlg.FileName);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                        return;
                    }

                    pictureBox1.Image = bitmap;
                    textBox1.Clear();

                    this.Invoke((MethodInvoker)delegate
                    {
                        string[] results = mBarcodeReaderManager.ReadBarcode(bitmap);
                        if (results != null)
                        {
                            foreach (string result in results)
                            {
                                textBox1.AppendText(result);
                                textBox1.AppendText(Environment.NewLine);
                            }
                        }
                        else
                        {
                            textBox1.AppendText("No barcode detected!");
                        }
                        
                    });
                }
            }
        }
    }
}
