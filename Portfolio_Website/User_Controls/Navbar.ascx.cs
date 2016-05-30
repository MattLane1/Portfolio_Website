using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Lab_Two_Matthew_Lane
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        /*
         *This Method adds a css class of "Active" to list items related to natication links of each page 
         * 
         * @method SetActivePage
         */

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;

                case "About":
                    about.Attributes.Add("class", "active");
                    break;

                case "Projects":
                    projects.Attributes.Add("class", "active");
                    break;

                case "Services":
                    services.Attributes.Add("class", "active");
                    break;

                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}