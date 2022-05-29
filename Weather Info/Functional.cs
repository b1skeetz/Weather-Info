using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Weather_Info.OpenWeather;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace Weather_Info
{
    class Functional
    {

        public string Get_Weather_Api(string city, string api_Key, string lang)
        {
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&lang=" + lang + "&appid=" + api_Key);
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = request.GetResponse();
            string answer = string.Empty;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = reader.ReadToEnd();
                }
            }
            response.Close();
            return answer;
        }
        public string Get_Weather_Api(string city, string api_Key)
        {
            WebRequest request = WebRequest.Create("https://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&lang=en&appid=" + api_Key);
            request.Method = "POST";
            request.ContentType = "application/x-www-urlencoded";

            WebResponse response = request.GetResponse();
            string answer = string.Empty;
            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = reader.ReadToEnd();
                }
            }
            response.Close();
            return answer;
        }
        public void CreateCommand(string queryString, string connectionString)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void SelectDataBase(string connectionString, DataGridView dataGridView1)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Weather];";
            command.Connection = connection;
            SqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["City_Name"].ToString(), reader["Main"].ToString(), reader["Descript"].ToString(), reader["Degrees"].ToString(),
                        reader["WindSpeed"].ToString(), reader["Direction"].ToString(), reader["Humidity"].ToString(), reader["Pressure"].ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public string Direction(double degrees, out string direct)
        {
            if (degrees > 0 && degrees < 90)
            {
                direct = "North-East";
                return direct;
            }
            else if (degrees > 90 && degrees < 180)
            {
                direct = "South-East";
                return direct;
            }
            else if (degrees > 180 && degrees < 270)
            {
                direct = "South-West";
                return direct;
            }
            else if (degrees > 270 && degrees < 360)
            {
                direct = "North-West";
                return direct;
            }
            else if (degrees == 0 || degrees == 360)
            {
                direct = "North";
                return direct;
            }
            else if (degrees == 90)
            {
                direct = "East";
                return direct;
            }
            else if (degrees == 180)
            {
                direct = "South";
                return direct;
            }
            else if (degrees == 270)
            {
                direct = "West";
                return direct;
            }
            direct = "";
            return "";
        }
    }
}
