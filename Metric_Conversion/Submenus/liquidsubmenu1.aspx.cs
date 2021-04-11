using Metric_Conversion.Businesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metric_Conversion.Submenus
{
    public partial class liquidsubmenu1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ddlkmandmile_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtpg.Text = "";
            txtpgresult.Text = "";
            if (ddlpg.SelectedValue == "pint")
            {
                lblpg.Text = "gallons";
            }
            else if (ddlpg.SelectedValue == "gallon")
            {
                lblpg.Text = "pints";
            }
            else
            {
                lblpg.Text = "";
            }
        }

        static List<liquid1> l = new List<liquid1>();
        protected void btnkmandmile_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                liquid1 l1 = new liquid1();

                if (ddlpg.SelectedValue == "pint")
                {
                    double input = Convert.ToDouble(txtpg.Text);
                    double result = input * 0.125;
                    txtpgresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtpg.Text + " pints";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " gallons";
                }
                else if (ddlpg.SelectedValue == "gallon")
                {
                    double input = Convert.ToDouble(txtpg.Text);
                    double result = input * 9.60762;
                    txtpgresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtpg.Text + " gallons";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " pints";
                }

                l.Add(l1);
                Session["liquid1"] = l;
            }
        }
    }
}