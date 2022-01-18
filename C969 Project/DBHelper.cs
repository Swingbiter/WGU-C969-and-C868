using System;
using System.Collections;
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
        public static Dictionary<int, Hashtable> appointments = new Dictionary<int, Hashtable>();

        static public Dictionary<string, string> getCustomerData(int customerID)
        {
            string customerQuery = $"SELECT * FROM customer WHERE customerId = '{customerID.ToString()}'";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(customerQuery, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> customerInfo = new Dictionary<string, string>();

            reader.Read();

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

        static public Dictionary<string, string> getAppointmentData(int _appointmentID)
        {
            string desiredFields = "appointmentId, customerId, type, start, end";
            string appointmentQuery = $"SELECT {desiredFields} FROM appointment WHERE appointmentId = '{_appointmentID.ToString()}'";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(appointmentQuery, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> apptData = new Dictionary<string, string>();

            reader.Read();

            apptData.Add("appointmentId", reader[0].ToString());
            apptData.Add("customerId", reader[1].ToString());
            apptData.Add("type", reader[2].ToString());
            apptData.Add("start", reader[3].ToString());
            apptData.Add("end", reader[4].ToString());

            return apptData;
        }

        static public string getUserName(int userId)
        {
            string query = $"SELECT userName FROM user WHERE userId = {userId}";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return reader[0].ToString();
        }

        static public string getCustomerName(int customerId)
        {
            string query = $"SELECT customerName FROM customer WHERE customerId = {customerId}";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return reader[0].ToString();
        }

        static public string getCityName(int cityID)
        {
            string query = $"SELECT city FROM city WHERE cityId = {cityID}";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return reader[0].ToString();
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

        // Get datestamp in DB ready format
        static public Func<string> getTodayTimeStamp = () => DateTime.Today.ToString("yyyy/MM/dd hh:mm:ss");

        // Convert time to DB format
        static public Func<string, string> convertToDBTime = date_str => DateTime.Parse(date_str.ToString()).ToUniversalTime().ToString("yyyy/MM/dd HH:mm:ss");

        static public Array getCityData()
        {
            string cityQuery = $"SELECT * FROM city";
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(cityQuery, conn);
            MySqlDataReader reader = cmd.ExecuteReader();


            Dictionary<int, Hashtable> cities = new Dictionary<int, Hashtable>();

            while (reader.Read())
            {
                Hashtable city = new Hashtable();
                city.Add("City", reader[1]);
                city.Add("CountryID", reader[2]);

                cities.Add(Convert.ToInt32(reader[0]), city);
            }

            reader.Close();

            conn.Close();

            var cityArray = from row in cities
                            select new
                            {
                                ID = row.Key,
                                Name = row.Value["City"],
                                AddressID = row.Value["CountryId"]
                            };

            return cityArray.ToArray();
        }

        static public int getLastId(string table)
        {
            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();

            string query = $"SELECT * FROM {table}";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<int> ids = new List<int>();

            while(reader.Read())
            {
                ids.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();
            conn.Close();

            return (int)ids[ids.Count - 1];
        }

        public static bool isAppointmentConflict(DateTime start, DateTime end, int app_id)
        {
            foreach (var app in appointments.Values)
            {
                if ((start < DateTime.Parse(app["end"].ToString()) && DateTime.Parse(app["start"].ToString()) < end) && app_id != (int)app["appointmentId"])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
