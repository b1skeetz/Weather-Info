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

//нужна функция которая будет обновлять базу данных раз в 10 минут
//нужна функция инсерта данных из апишки в базу и из базы в прогу

namespace Weather_Info
{
    public partial class Form1 : Form
    {
        Functional functional = new Functional();
        string city;
        string api_Key = "e8aa863082b25a1895eca1d16b744370";
        List<string> keysValues = new List<string>();
        /*Dictionary<string, string> languages = new Dictionary<string, string>()
        {
            { "en", "Английский" },
        };*/
        string direct;
        string direction;
        DateTime now = DateTime.Now;
        //string language;
        string answer;
        string queryString;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=master;" +
                "Integrated Security=True;";
        bool debug;

        public Form1()
        {
            InitializeComponent();
            comboBox_Cities.Items.Add("London");
            comboBox_Cities.Items.Add("Moscow");
            comboBox_Cities.Items.Add("Berlin");
            comboBox_Cities.Items.Add("Nur-Sultan");
            comboBox_Cities.Items.Add("Kyiv");
            /*string outLang;

             foreach (var lang in languages.Keys)
             {
                 languages.TryGetValue(lang, out outLang);
                 comboBox_language.Items.Add(outLang);
             }*/
            try
            {
                queryString = "CREATE TABLE [dbo].[Weather] (" +
                                                           "[Id] BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY," +
                                                           "[City_Name] nvarchar(50) NOT NULL," +
                                                           "[Main] nvarchar(50) NOT NULL," +
                                                           "[Descript] nvarchar(50) NOT NULL," +
                                                           "[Degrees] DECIMAL(18, 2) NOT NULL," +
                                                           "[WindSpeed] DECIMAL(18, 2) NOT NULL," +
                                                           "[Direction] nvarchar(50) NOT NULL," +
                                                           "[Humidity]  DECIMAL(18, 2) NOT NULL," +
                                                           "[Pressure] int NOT NULL);";
                functional.CreateCommand(queryString, connectionString);
                debug = InsertIntoDataBase();
            }
            catch (Exception ex)
            {
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
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
                this.dataGridView1.Columns.Add("City_Name", "Город");
                this.dataGridView1.Columns["City_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.dataGridView1.Columns.Add("Main", "Основное");
                this.dataGridView1.Columns["Main"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.dataGridView1.Columns.Add("Descript", "Описание");
                this.dataGridView1.Columns["Descript"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.dataGridView1.Columns.Add("Degrees", "Температура");
                this.dataGridView1.Columns["Main"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.dataGridView1.Columns.Add("WindSpeed", "Скорость ветра");
                this.dataGridView1.Columns["WindSpeed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.dataGridView1.Columns.Add("Direction", "Направление ветра");
                this.dataGridView1.Columns["Direction"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.dataGridView1.Columns.Add("Humidity", "Влажность");
                this.dataGridView1.Columns["Humidity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.dataGridView1.Columns.Add("Pressure", "Давление");
                this.dataGridView1.Columns["Pressure"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        public bool InsertIntoDataBase() // производит INSERT запрос в базу данных из API 
        {
            foreach (string cities in comboBox_Cities.Items)
            {
                answer = functional.Get_Weather_Api(cities, api_Key);
                OpenWeatherInfo openWeatherInfo = JsonConvert.DeserializeObject<OpenWeatherInfo>(answer);
                direction = functional.Direction(openWeatherInfo.wind.deg, out direct);
                queryString = "INSERT INTO Weather (City_Name, Main, Descript, Degrees, WindSpeed, Direction, Humidity, Pressure) VALUES ('"
                    + cities + "', '"
                    + openWeatherInfo.weather[0].main + "', '"
                    + openWeatherInfo.weather[0].description + "', "
                    + ((int)openWeatherInfo.main.temp).ToString("0.##") + ", " //нужно перевести в decimal
                    + ((int)openWeatherInfo.wind.speed).ToString() + ", '"
                    + direct + "', "
                    + openWeatherInfo.main.humidity.ToString() + ", "
                    + ((int)openWeatherInfo.main.pressure).ToString() + ");";
                functional.CreateCommand(queryString, connectionString);
                return true;
            }
            return false;
        }

        private void comboBox_Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = comboBox_Cities.SelectedItem.ToString();
            /*if (comboBox_language.Text != "")
            {
                string outLang;
                string key = "";
                string comboBoxValue = comboBox_language.SelectedItem.ToString();
                foreach (var lang in languages.Keys)
                {
                    languages.TryGetValue(lang, out outLang);
                    if (outLang == comboBoxValue)
                    {
                        key = lang;
                    }
                    }
                }*/

            answer = functional.Get_Weather_Api(city, api_Key);
            Show_Content(answer);


        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*language = comboBox_language.SelectedItem.ToString();
            string outLang;
            string key = "";
            string comboBoxValue = comboBox_language.SelectedItem.ToString();
            foreach (var lang in languages.Keys)
            {
                languages.TryGetValue(lang, out outLang);
                if (outLang == comboBoxValue)
                {
                    key = lang;
                }
            }*/

            if (comboBox_Cities.Text != "")
            {
                answer = functional.Get_Weather_Api(city, api_Key);
                Show_Content(answer);

            }
        }

        public void Show_Content(string answer)
        {
            OpenWeatherInfo openWeatherInfo = JsonConvert.DeserializeObject<OpenWeatherInfo>(answer);

            panel_ImageStatus.BackgroundImage = openWeatherInfo.weather[0].Icon;

            label_Name.Text = openWeatherInfo.name;
            label_main.Text = openWeatherInfo.weather[0].main;
            label_Description.Text = openWeatherInfo.weather[0].description;
            label_Degrees.Text = "Средняя температура (°С): " + openWeatherInfo.main.temp.ToString("0.##");
            label_WindSpeed.Text = "Скорость (м/с): " + openWeatherInfo.wind.speed.ToString();
            label_Direction.Text = "Направление: " + functional.Direction(openWeatherInfo.wind.deg, out direct);
            label_Humidity.Text = "Влажность: (%): " + openWeatherInfo.main.humidity.ToString();
            label_Pressure.Text = "Давление (мм): " + ((int)openWeatherInfo.main.pressure).ToString();
        }

        private void button_weatherUpdate_Click(object sender, EventArgs e)
        {
            if (comboBox_Cities.Text != "")
            {

                /*string outLang;
                string key = "";
                string comboBoxValue = comboBox_language.SelectedItem.ToString();
                foreach (var lang in languages.Keys)
                {
                    languages.TryGetValue(lang, out outLang);
                    if (outLang == comboBoxValue)
                    {
                        key = lang;
                    }
                }*/

                string update = functional.Get_Weather_Api(city, api_Key);
                Show_Content(update);
            }
        }

        private void открытьAPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            API api = new API(answer);
            api.ShowDialog();

        }



        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryString = "DROP TABLE [dbo].[Weather];";
            functional.CreateCommand(queryString, connectionString);
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryString = "CREATE TABLE [dbo].[Weather] (" +
                                                          "[Id] BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY," +
                                                          "[City_Name] nvarchar(50) NOT NULL," +
                                                          "[Main] nvarchar(50) NOT NULL," +
                                                          "[Descript] nvarchar(50) NOT NULL," +
                                                          "[Degrees] DECIMAL(18, 2) NOT NULL," +
                                                          "[WindSpeed] DECIMAL(18, 2) NOT NULL," +
                                                          "[Direction] nvarchar(50) NOT NULL," +
                                                          "[Humidity]  DECIMAL(18, 2) NOT NULL," +
                                                          "[Pressure] int NOT NULL);";
            functional.CreateCommand(queryString, connectionString);
            InsertIntoDataBase();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeatherTable weatherTable = new WeatherTable();
            weatherTable.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            queryString = "DROP TABLE [dbo].[Weather];";
            functional.CreateCommand(queryString, connectionString);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
