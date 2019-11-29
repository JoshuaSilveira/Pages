using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            PAGEDB db = new PAGEDB();

            if (valid)
            {
                Page currentPage = db.FindPage(int.Parse(pageid));

                title.InnerHtml += currentPage.GetPageTitle();
                content.InnerHtml += currentPage.GetPageContent();
            }
            else
            {
                valid = false;
            }
            if (!valid)
            {
                title.InnerHtml = "There was error";
            }
        }
    }
}