using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MukthadirsBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            myBrowser.Navigate(txtUrl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncryptionService.ServiceClient myClient = new EncryptionService.ServiceClient();

            try
            {
                textBox2.Text = myClient.Encrypt(textBox1.Text);
            }
            catch (Exception ec) {
                textBox2.Text = ec.Message.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EncryptionService.ServiceClient myClient = new EncryptionService.ServiceClient();

            try
            {
                textBox3.Text = myClient.Decrypt(textBox2.Text);
            }
            catch (Exception ec)
            {
                textBox3.Text = ec.Message.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockQuote.ServiceClient stockClient = new StockQuote.ServiceClient();
            textBox5.Text = stockClient.getStockquote(textBox4.Text);
        }
    }
}
