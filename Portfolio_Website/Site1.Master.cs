using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_Website
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switchActivePage();
        }

        //Changes which page is active on the navbar
        private void switchActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    Home.Attributes.Add("class", "active");
                    break;

                case "Contact":
                    Contact.Attributes.Add("class", "active");
                    break;

                case "About":
                    About.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}