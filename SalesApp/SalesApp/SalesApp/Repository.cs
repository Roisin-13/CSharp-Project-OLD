using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.IO;

namespace SalesApp.SalesApp
{
    class Repository 
    { 
        public Repository(MySqlConnection mySqlConnection)
        {
            this.connection = mySqlConnection;
        }

        //===========DATA ENTRY============//
        internal Sale Create(Sale toCreate)
        {
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into sales(name, quantity, price, date_of_sale) " +
                "values(@Name, @Quantity, @Price, @Date)";
            command.Parameters.AddWithValue("@Title", toCreate.Name);
            command.Parameters.AddWithValue("@Star", toCreate.Quantity);
            command.Parameters.AddWithValue("@Type", toCreate.Price);
            command.Parameters.AddWithValue("@Date", toCreate.Date);
            command.Prepare();
            command.ExecuteNonQuery();

            connection.Close();

            Sale sale = new Sale();
            sale.ID = (int)command.LastInsertedId;
            return sale;

        }



        //===========EXISTS? METHOD===============//
        //-----used to help delete method, so will not delete if ID is not available
        internal bool Exists(int id)
        {
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "select count(*) from sales where id=@id";
            command.Parameters.AddWithValue("@id", id);
            command.Prepare();
            int result = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return result > 0;
        }

        //===========DELETE============//
        internal void Delete(int id)
        {
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = $"delete from sales where id={id}";
            command.ExecuteNonQuery();

            connection.Close();

        }





    }
}
