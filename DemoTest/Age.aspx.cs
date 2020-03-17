using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoTest
{
    public partial class Age : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
            BLClass BL = new BLClass();
            txtAge.Text = (BL.Age(DateTime.Parse(txtDob.Text))).ToString();
            }

            catch(CustomException E)
            {
                Response.Write(E.Message);
            }
            finally
            {

            }
        }
    }
}