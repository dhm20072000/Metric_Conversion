using Metric_Conversion.Businesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metric_Conversion.Submenus
{
    public partial class liquidsubmenu2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ddlkmandmile_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtqg.Text = "";
            txtqgresult.Text = "";
            if (ddlqg.SelectedValue == "quart")
            {
                lblqg.Text = "gallons";
            }
            else if (ddlqg.SelectedValue == "gallon")
            {
                lblqg.Text = "quarts";
            }
            else
            {
                lblqg.Text = "";
            }
        }

        static List<liquid1> l = new List<liquid1>();
        protected void btnkmandmile_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                liquid1 l1 = new liquid1();

                if (ddlqg.SelectedValue == "quart")
                {
                    double input = Convert.ToDouble(txtqg.Text);
                    double result = input * 0.20817;
                    txtqgresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtqg.Text + " quarts";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " gallons";
                }
                else if (ddlqg.SelectedValue == "gallon")
                {
                    double input = Convert.ToDouble(txtqg.Text);
                    double result = input * 4.80381;
                    txtqgresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtqg.Text + " gallons";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " quarts";
                }

                l.Add(l1);
                Session["liquid2"] = l;

            }
        }
    }
}