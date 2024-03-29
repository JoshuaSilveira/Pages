﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pages
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var test = new PAGEDB();

            List<Page> testList = test.List_Query("Select * from pages");

            foreach (Page row in testList)
            {
                //System.Diagnostics.Debug.WriteLine(row.PageContent + " " + row.PageTitle);
                pages.InnerHtml += "<li><a href=\"ShowPage.aspx?pageid=" + row.GetPageId() + "\">" + row.GetPageTitle() + "</a></li>";
            }
        }
    }
}