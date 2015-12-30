using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            int result = myClient.c2f(Convert.ToInt32(txtInput.Text));
            this.txtInput2.Text = result.ToString();
        }

        protected void btn2Submit_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();
            int result = myClient.f2c(Convert.ToInt32(TextBox1.Text));
            this.TextBox2.Text = result.ToString();
        }
    }
}