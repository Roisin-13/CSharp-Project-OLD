using System;
using MySql.Data.MySqlClient;

using System.IO;
using SalesApp.SalesApp;
using SalesApp.Utils;
using SalesApp.Exceptions;


namespace SalesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //============ DB connection ===================//
            //             MySqlConnection connection = mySqlUtils.GetConnection();
            //connection.Open();
            ////----connecting to sql file
            //mySqlUtils.RunSchema(Environment.CurrentDirectory + @"\static\schema.sql", connection);
            ////---checking connection
            //bool connectionOpen = connection.Ping();
            //Console.WriteLine($@"Connection status: {connection.State}
            //Ping successful: {connectionOpen}
            //DB version: {connection.ServerVersion}");

            //connection.Dispose();

            MySqlConnection connection = mySqlUtils.GetConnection();
            try
            {

                Menu menu = new Menu(new Controller(
                        new Services(
                            new Repository(connection))));
                menu.firstMenu();

            }
            catch (MySqlException)
            {
                //--just needed to check exception message REMEMBER TO CHANGE
                Console.WriteLine("Cannot connect to the server...oh noooo!!!!");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Dispose();
                }
            }


        }
    }
}
