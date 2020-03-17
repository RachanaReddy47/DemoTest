using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoTest
{
    public partial class DemoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BLClass BL = new BLClass();

            try
            {
                txtResult.Text = (BL.Divide(txtNumerator.Text,txtDenominator.Text)).ToString();
            }
           catch(DivideByZeroException E)
            {
              Response.Write(E.Message);
            }
            catch(FormatException E)
            {
                Response.Write(E.Message);
            }
            finally
            {

            }
        }
    }
}