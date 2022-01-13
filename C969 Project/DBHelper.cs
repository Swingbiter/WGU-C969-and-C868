using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace C969_Project
{
    class DBHelper
    {
        public static string connection_string = "server=localhost;uid=sqlUser;pwd=Passw0rd!;database=client_schedule";
        public static int currentUserId;
        public static string currentUserName;
        public static bool loggedIn = false;

        static public Dictionary<string, string> getCustomerData(int customerID)
        {
            string customerQuery = $"SELECT * FROM customer WHERE customerId = '{customerID.ToString()}'";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(customerQuery, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> customerInfo = new Dictionary<string, string>();

            // Data from customer table
            customerInfo.Add("customerName", reader[1].ToString());
            customerInfo.Add("addressId", reader[2].ToString());
            customerInfo.Add("active", reader[3].ToString());
            reader.Close();

            // Data from address table
            customerQuery = $"SELECT * FROM address WHERE addressId = '{customerInfo["addressId"]}'";
            cmd = new MySqlCommand(customerQuery, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            customerInfo.Add("address", reader[1].ToString());
            customerInfo.Add("cityId", reader[3].ToString());
            customerInfo.Add("zip", reader[4].ToString());
            customerInfo.Add("phone", reader[5].ToString());
            reader.Close();


            // City Table Details
            customerQuery = $"SELECT * FROM city WHERE cityId = '{customerInfo["cityId"]}'";
            cmd = new MySqlCommand(customerQuery, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            customerInfo.Add("city", reader[1].ToString());
            customerInfo.Add("countryId", reader[2].ToString());
            reader.Close();

            // Country Table Details
            customerQuery = $"SELECT * FROM country WHERE countryId = '{customerInfo["countryId"]}'";
            cmd = new MySqlCommand(customerQuery, conn);
            reader = cmd.ExecuteReader();
            reader.Read();

            customerInfo.Add("country", reader[1].ToString());
            reader.Close();

            // close db connection
            conn.Close();

            return customerInfo;
        }

        static public bool LoginUser(string userName, string pwd)
        {
            // remove me1!!!!
            //loggedIn = true;
            //currentUserName = "FartSniffer";
            //return true;

            string query = $"SELECT userId FROM user WHERE userName = '{userName}' and password = '{pwd}'";

            // db connecting
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                currentUserId = Convert.ToInt32(reader[0]);
                currentUserName = userName;
                loggedIn = true;
                
                // Clean up, everybody clean up
                reader.Close();
                conn.Close();

                return true;
            }

            return false;
        }

        // Lambda expression used here because what function does is obvious but path to get there is a bit obscure.
        static public Func<string, string> convertToTimeZone = date_str => DateTime.Parse(date_str.ToString()).ToLocalTime().ToString("MM/dd/yyyy hh:mm tt");
    }
}
