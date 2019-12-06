using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Pages
{
    public class PageController:PAGEDB//PageController inherits PAGEDB provides db functions for pages
    {
        public void AddPage(Page newPage)
        {
            string query = "insert into pages (pagetitle, pagebody) values ('{0}','{1}')";
            query = String.Format(query, newPage.GetPageTitle(), newPage.GetPageContent());
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in AddPage Method:");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();

        }
    }
}