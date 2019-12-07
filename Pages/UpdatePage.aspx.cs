using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
  

        }
        protected void updatePage(object sender, EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {
                PageController pageController = new PageController();
                Page page = new Page();
                page.SetPageTitle(page_title.Text);
                page.SetPageContent(page_content.Text);

                pageController.UpdatePage(Int32.Parse(pageid), page);
                Response.Redirect("ShowPage.aspx?pageid=" + pageid);

            }

        }
    }
}