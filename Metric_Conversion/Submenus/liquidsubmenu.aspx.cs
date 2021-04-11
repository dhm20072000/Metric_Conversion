using Metric_Conversion.Businesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metric_Conversion.Submenus
{
    public partial class liquidsubmenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ddlkmandmile_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtlg.Text = "";
            txtlgresult.Text = "";
            if(ddllg.SelectedValue == "liter")
            {
                lbllg.Text = "gallons";
            }
            else if(ddllg.SelectedValue == "gallon")
            {
                lbllg.Text = "liters";
            }
            else
            {
                lbllg.Text = "";
            }
        }

        static List<liquid1> l = new List<liquid1>();
        protected void btnkmandmile_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                liquid1 l1 = new liquid1();

                if(ddllg.SelectedValue == "liter")
                {
                    double input = Convert.ToDouble(txtlg.Text);
                    double result = input * 0.264172;
                    txtlgresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtlg.Text + " liters";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " gallons";
                }
                else if (ddllg.SelectedValue == "gallon")
                {
                    double input = Convert.ToDouble(txtlg.Text);
                    double result = input * 3.78541;
                    txtlgresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtlg.Text + " gallons";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " liters";
                }

                l.Add(l1);
                Session["liquid"] = l;

            }
        }
    }
}