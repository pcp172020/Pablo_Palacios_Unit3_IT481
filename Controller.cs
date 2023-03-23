using System;
using System.Data.SqlClient;

namespace Pablo_Palacios_Unit3_IT481
{
    class Controller
    {

        string connectionString;
        SqlConnection cnn;
        public Controller()
        {
            connectionString = "";
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
            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            return names;
        }

        public string getEmployeeCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from employees;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);

            try
            {
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return count.ToString();
        }

        public string getEmployeeNames()
        {
            String names = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select FirstName + ' ' + LastName from employees;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return names;
        }

        public string getOrderCount()
        {
            Int32 count = 0;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select count(*) from orders;";
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

        public string getShipNames()
        {
            string names = "";
            SqlDataReader dataReader;

            cnn = new SqlConnection(connectionString);
            cnn.Open();
            string countQuery = "select shipname from orders;";
            SqlCommand cmd = new SqlCommand(countQuery, cnn);
            try
            {
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    names = names + dataReader.GetValue(0) + "\n";
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            return names;
        }
    }
}
