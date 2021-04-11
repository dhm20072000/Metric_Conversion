using Metric_Conversion.Businesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metric_Conversion.Submenus
{
    public partial class kmandmiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ddlkmandmile_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkmandmileinput.Text = "";
            txtkmandmileresult.Text = "";
            if(ddlkmandmile.SelectedValue == "km")
            {
                lblkmandmile.Text = "miles";
            }
            else if(ddlkmandmile.SelectedValue == "mile")
            {
                lblkmandmile.Text = "kms";
            }
            else if(ddlkmandmile.SelectedValue == "yard")
            {
                lblkmandmile.Text = "feet";
            }
            else if (ddlkmandmile.SelectedValue == "ft")
            {
                lblkmandmile.Text = "yards";
            }
            else if (ddlkmandmile.SelectedValue == "inch")
            {
                lblkmandmile.Text = "cms";
            }
            else if (ddlkmandmile.SelectedValue == "cm")
            {
                lblkmandmile.Text = "inches";
            }
            else
            {
                lblkmandmile.Text = "";
            }
        }
        static List<Length1> l = new List<Length1>();
        protected void btnkmandmile_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Length1 l1 = new Length1();

                if(ddlkmandmile.SelectedValue == "km")
                {
                    double input = Convert.ToDouble(txtkmandmileinput.Text);
                    double result = input * 0.621371;
                    txtkmandmileresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtkmandmileinput.Text +" kms";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " miles";
                }
                else if(ddlkmandmile.SelectedValue == "mile")
                {
                    double input = Convert.ToDouble(txtkmandmileinput.Text);
                    double result = input * 1.60934;
                    txtkmandmileresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtkmandmileinput.Text + " miles";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " kms";
                }
                else if (ddlkmandmile.SelectedValue == "yard")
                {
                    double input = Convert.ToDouble(txtkmandmileinput.Text);
                    double result = input * 3;
                    txtkmandmileresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtkmandmileinput.Text + " yards";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " feet";
                }
                else if (ddlkmandmile.SelectedValue == "ft")
                {
                    double input = Convert.ToDouble(txtkmandmileinput.Text);
                    double result = input * 0.33333;
                    txtkmandmileresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtkmandmileinput.Text + " feet";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " yards";
                }
                else if (ddlkmandmile.SelectedValue == "inch")
                {
                    double input = Convert.ToDouble(txtkmandmileinput.Text);
                    double result = input * 2.54;
                    txtkmandmileresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtkmandmileinput.Text + " inches";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " cms";
                }
                else if (ddlkmandmile.SelectedValue == "cm")
                {
                    double input = Convert.ToDouble(txtkmandmileinput.Text);
                    double result = input * 0.3937;
                    txtkmandmileresult.Text = result.ToString();
                    l1.datetime = DateTime.Now.ToString();
                    l1.num1 = txtkmandmileinput.Text + " cms";
                    l1.num2 = "=";
                    l1.result = result.ToString() + " inches";
                }

                l.Add(l1);
                Session["Length1"] = l;
            }
        }
    }
}