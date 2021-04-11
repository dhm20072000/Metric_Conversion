using Metric_Conversion.Businesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metric_Conversion.Submenus
{
    public partial class masssubmenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ddlkmandmile_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmass.Text = "";
            txtmassresult.Text = "";
            if(ddlmass.SelectedValue == "kg")
            {
                lblmass.Text = "pounds";
            }
            else if(ddlmass.SelectedValue == "pound")
            {
                lblmass.Text = "kgs";
            }
            else if(ddlmass.SelectedValue == "ounce")
            {
                lblmass.Text = "grams";
            }
            else if(ddlmass.SelectedValue == "gram")
            {
                lblmass.Text = "ounces";
            }
            else
            {
                lblmass.Text = "";
            }
        }

        static List<Mass1> m = new List<Mass1>();
        protected void btnkmandmile_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Mass1 m1 = new Mass1();

                if (ddlmass.SelectedValue == "kg")
                {
                    double input = Convert.ToDouble(txtmass.Text);
                    double result = input * 2.20462;
                    txtmassresult.Text = result.ToString();
                    m1.datetime = DateTime.Now.ToString();
                    m1.num1 = txtmass.Text + " kgs";
                    m1.num2 = "=";
                    m1.result = result.ToString() + " pounds";
                }
                else if (ddlmass.SelectedValue == "pound")
                {
                    double input = Convert.ToDouble(txtmass.Text);
                    double result = input * 0.453592;
                    txtmassresult.Text = result.ToString();
                    m1.datetime = DateTime.Now.ToString();
                    m1.num1 = txtmass.Text + " pounds";
                    m1.num2 = "=";
                    m1.result = result.ToString() + " kgs";
                }
                else if (ddlmass.SelectedValue == "ounce")
                {
                    double input = Convert.ToDouble(txtmass.Text);
                    double result = input * 28.3495;
                    txtmassresult.Text = result.ToString();
                    m1.datetime = DateTime.Now.ToString();
                    m1.num1 = txtmass.Text + " ounces";
                    m1.num2 = "=";
                    m1.result = result.ToString() + " grams";
                }
                else if (ddlmass.SelectedValue == "gram")
                {
                    double input = Convert.ToDouble(txtmass.Text);
                    double result = input * 0.035274;
                    txtmassresult.Text = result.ToString();
                    m1.datetime = DateTime.Now.ToString();
                    m1.num1 = txtmass.Text + " grams";
                    m1.num2 = "=";
                    m1.result = result.ToString() + " ounces";
                }

                m.Add(m1);
                Session["mass"] = m;

            }
        }
    }
}