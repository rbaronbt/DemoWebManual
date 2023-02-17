using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello there " + TextBox1.Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "As stated, you are a SILLY PERSON. Why did you click here, SILLY PERSON?";
        }
    }
}