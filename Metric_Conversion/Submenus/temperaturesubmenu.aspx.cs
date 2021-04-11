using Metric_Conversion.Businesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metric_Conversion.Submenus
{
    public partial class temperaturesubmenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void ddlkmandmile_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfc.Text = "";
            txtfcresult.Text = "";
            if (ddlfc.SelectedValue == "Fahrenheit")
            {
                lblfc.Text = "Celsius";
            }
            else if (ddlfc.SelectedValue == "Celsius")
            {
                lblfc.Text = "Fahrenheit";
            }
            else
            {
                lblfc.Text = "";
            }
        }

        static List<Temperature1> temp = new List<Temperature1>();
        protected void btnkmandmile_Click(object sender, EventArgs e)
        {
            Temperature1 temp1 = new Temperature1();

            if (IsValid)
            {
                if (ddlfc.SelectedValue == "Fahrenheit")
                {
                    double input = Convert.ToDouble(txtfc.Text);
                    double result = (input - 32) * 0.5555;
                    txtfcresult.Text = result.ToString();
                    temp1.datetime = DateTime.Now.ToString();
                    temp1.num1 = txtfc.Text + " F";
                    temp1.num2 = "=";
                    temp1.result = result.ToString() + " C";
                }
                else if (ddlfc.SelectedValue == "Celsius")
                {
                    double input = Convert.ToDouble(txtfc.Text);
                    double result = (input * 1.8) + 32;
                    txtfcresult.Text = result.ToString();
                    temp1.datetime = DateTime.Now.ToString();
                    temp1.num1 = txtfc.Text + " C";
                    temp1.num2 = "=";
                    temp1.result = result.ToString() + " F";
                }
                
                temp.Add(temp1);
                Session["temp"] = temp;
            }

            

        }
    }
}