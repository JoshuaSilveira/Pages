using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pages
{
    public class Page
    {
        private string PageTitle;
        private string PageContent;
        private int PageId;

        public int GetPageId()
        {
            return PageId;
        }
        public void SetPageId(int value)
        {
            PageId = value;
        }
        public string GetPageTitle()
        {
            return PageTitle;
        }
        public void SetPageTitle(string value)
        {
            PageTitle = value;
        }

        public string GetPageContent()
        {
            return PageContent;
        }
        
        public void SetPageContent(string value)
        {
            PageContent = value;
        }
    }
}