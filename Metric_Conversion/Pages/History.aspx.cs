using Metric_Conversion.Businesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Metric_Conversion.Pages
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Length1> l1 = (List<Length1>)Session["Length1"];
            grid1.DataSource = l1;
            grid1.DataBind();
            
            List<liquid1> liquid = (List<liquid1>)Session["liquid"];
            grid2.DataSource = liquid;
            grid2.DataBind();
            
            List<liquid1> liquid1 = (List<liquid1>)Session["liquid1"];
            grid3.DataSource = liquid1;
            grid3.DataBind();
            
            List<liquid1> liquid2 = (List<liquid1>)Session["liquid2"];
            grid4.DataSource = liquid2;
            grid4.DataBind();

            List<Temperature1> temp = (List<Temperature1>)Session["temp"];
            grid5.DataSource = temp;
            grid5.DataBind();

            List<Mass1> m = (List<Mass1>)Session["mass"];
            grid6.DataSource = m;
            grid6.DataBind();

            //if(m != null)
            //{
            //    foreach (var element in m)
            //    {
            //        ListBox1.Items.Add(element.datetime + " " + element.num1 + " " + element.num2 + " " + element.result);
            //    }
            //}
            
        
        }
    }
}