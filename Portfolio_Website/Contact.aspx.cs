/*------------------------------------------------------------------------------

  @Author : Matthew Lane
  @File Name : Contact.aspx.cs
  @Website Name : Portfolio_Website
  @File Description : This is the contact page for my portfolio website
  
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_Website
{
    public partial class Contact : System.Web.UI.Page
    {
        //This event is called when the page is loaded
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //This event is called when the Send button is pressed, and all responses are accepted
        protected void SendButton_Click(object sender, EventArgs e)
        {
            //Temp Replace with actual code
            Response.Redirect("Default.aspx");
        }
    }
}