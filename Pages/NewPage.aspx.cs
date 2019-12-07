using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages
{
    public partial class NewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void addPage(object sender, EventArgs e)
        {
            PageController db = new PageController();
            Page newPage = new Page();
            newPage.SetPageContent(page_content.Text);
            newPage.SetPageTitle(page_title.Text);
            db.AddPage(newPage);

            Response.Redirect("ListPages.aspx");
        }
    }
}