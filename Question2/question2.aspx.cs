using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace question2
{
    public partial class question2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                img.ImageUrl = "images/tomato.jfif";
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                img.ImageUrl = "images/potatoes.jfif";

            }
            else
                img.ImageUrl = "images/chili.jfif";


        }

        protected void btn_click(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedIndex > -1)
            {
                int cost = DropDownList1.SelectedIndex;
                price.Text = "Rs ";

                if (cost == 0)
                    price.Text += "10";

                else  if (cost == 1)
                    price.Text += "100";



                else 
                    price.Text += "60";

            }





        }

        
    }
}