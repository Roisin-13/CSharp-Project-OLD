using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.IO;

namespace SalesApp.SalesApp
{
    class Sale
    {
        public int ID { get; set; }
        private string name;
        private int quantity;
        private double price;
        private DateTime date; // = DateTime.Now; //default date set for now

        //--------get/set sale name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //--------get/set sale quantity
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        //--------get/set sale price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        //--------get/set sale date
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        
        //-----sale construcors:
        public Sale(string name, int quantity, double price, DateTime date)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
            this.Date = date;
        }

        public override string ToString()
        {
            return $"Sale ID: {ID}, Name: {name}, Quantity: {quantity}, Price: {price}";
        }
        public Sale()
        {
        }

       





 
    }
}
