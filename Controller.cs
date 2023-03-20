﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pablo_Palacios_Unit3_IT481
{
    internal class Controller
    {
        string connectionString;
        SqlConnection cnn = null;
        public Controller()
        {
            connectionString = "Server = LAPTOP-MOQ8RUQ4\\SQLEXPRESS; " +
                                        "Trusted_Connection=true;" +
                                        "Database=Northwind;" +
                                        "User Instance=false;" +
                                        "Connection timeout=30";
        }

        //Constructor that takes DB Connection string
        public Controller(string conn)
        {

            connectionString = conn;

        }

        //Method to get the customer table count
        public string getCustomerCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }


        //Method to get the company names
        public string getCompanyNames()
        {
            string names = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "Select companyname from customers;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return names;
        }
    }
}
