using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Pages
{
    public class PAGEDB
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "pagedb"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //ConnectionString is something that we use to connect to a database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }
        public Page FindPage(int id)
        {
            string query = "select * from pages where pageid = " + id;
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

            Page ResultPage = new Page();
            try
            {
                Connect.Open();
                //give the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();
                List<Page> pages = new List<Page>();

                while (resultset.Read())
                {
                    Page Row = new Page();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.SetPageTitle(resultset["pagetitle"].ToString());
                        Row.SetPageContent(resultset["pagebody"].ToString());
                        Row.SetPageId(Int32.Parse(resultset["pageid"].ToString()));
                    }
                    pages.Add(Row);

                }
                ResultPage = pages[0];

            }
            catch (Exception ex)
            {
                //If something (anything) goes wrong with the try{} block, this block will execute
                Debug.WriteLine("Something went wrong in the find Student method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultPage;

        }

        public List<Page> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            List<Page> ResultSet = new List<Page>();

            try
            {
                Debug.WriteLine("Connection Initialized...");

                //open the db connection
                Connect.Open();
                //give the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();


                //for every row in the result set
                while (resultset.Read())
                {
                    Page Row = new Page();
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.SetPageTitle(resultset["pagetitle"].ToString());
                        Row.SetPageContent(resultset["pagebody"].ToString());
                        Row.SetPageId(Int32.Parse(resultset["pageid"].ToString()));

                    }
                    ResultSet.Add(Row);


                }
                resultset.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }



    }


}
