using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class QrBarcodeGenerator : Form
    {
        bool isGenerated = false;
        public QrBarcodeGenerator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.CodeQrBarcodeDraw qrBarcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrBarcode.Draw(textBox1.Text, 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isGenerated = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            Zen.Barcode.Code128BarcodeDraw bar = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = bar.Draw(textBox2.Text, 200);
        }

        private void QrBarcodeGenerator_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(isGenerated)
            {

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            pictureBox1.Image.Save(path + "\\" + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + ".jpg", ImageFormat.Jpeg);

            }
        }
    }
}
