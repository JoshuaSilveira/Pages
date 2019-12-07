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
        public void DeletePage(int pageid)
        {
            string removepage = "delete from pages where pageid=" + pageid;

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand removePageCommand = new MySqlCommand(removepage, Connect);
            try
            {
                
                Connect.Open();
                
                removePageCommand.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + removePageCommand);
                
            }
            catch (Exception ex)
            {
                
                Debug.WriteLine("Error at page Method:");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
        public void UpdatePage(int pageid, Page page)
        {
            string updatepage = "update pages set pagetitle ='{0}',pagebody='{1}' where pageid='{2}'";
            updatepage = String.Format(updatepage, page.GetPageTitle(), page.GetPageContent(), pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(updatepage, Connect);

            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + updatepage);

            }
            catch (Exception ex)
            {
                
                Debug.WriteLine("Error at UpdatePage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
    }
}