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
using MySql.Data.MySqlClient;

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
        public void CreateCommand(string queryString, string connectionString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(queryString, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }       

        public string Direction(double degrees, out string direct)
        {
            if (degrees > 0 && degrees < 90)
            {
                direct =  "Северо-Восток";
                return direct;
            }
            else if (degrees > 90 && degrees < 180)
            {
                direct = "Юго-Восток";
                return direct;
            }
            else if (degrees > 180 && degrees < 270)
            {
                direct = "Юго-Запад";
                return direct;
            }
            else if (degrees > 270 && degrees < 360)
            {
                direct = "Северо-Запад";
                return direct;
            }
            else if (degrees == 0)
            {
                direct = "Север";
                return direct;
            }
            else if (degrees == 90)
            {
                direct = "Восток";
                return direct;
            }
            else if (degrees == 180)
            {
                direct = "Юг";
                return direct;
            }
            else if (degrees == 270)
            {
                direct = "Запад";
                return direct;
            }
            else if (degrees == 360)
            {
                direct = "Север";
                return direct;
            }
            direct = "";
            return "";
        }
    }
}
