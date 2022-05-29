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
        string direct;
        string direction;
        DateTime now = DateTime.Now;
        string answer;
        string queryString;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=master;" +
                "Integrated Security=True;";
        bool isExist = true;

        public Form1()
        {
            InitializeComponent();
            comboBox_Cities.Items.Add("London");
            comboBox_Cities.Items.Add("Moscow");
            comboBox_Cities.Items.Add("Berlin");
            comboBox_Cities.Items.Add("Nur-Sultan");
            comboBox_Cities.Items.Add("Kyiv");
            
            try
            {
                queryString = "CREATE TABLE [dbo].[Weather] (" +
                                                           "[Id] BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY," +
                                                           "[City_Name] nvarchar(50) NOT NULL," +
                                                           "[Main] nvarchar(50) NOT NULL," +
                                                           "[Descript] nvarchar(50) NOT NULL," +
                                                           "[Degrees] INT NOT NULL," +
                                                           "[WindSpeed] INT NOT NULL," +
                                                           "[Direction] nvarchar(50) NOT NULL," +
                                                           "[Humidity] INT NOT NULL," +
                                                           "[Pressure] int NOT NULL," +
                                                           "[Icon] nvarchar(50) NOT NULL);";
                functional.CreateCommand(queryString, connectionString);
                InsertIntoDataBase();
                isExist = true;
            }
            catch (Exception ex)
            {
                return;
            }
            listBox_Cities.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            functional.SelectDataBase(connectionString, dataGridView1);

            timer_update.Interval = (10 * 60 * 1000); // 10 mins
            timer_update.Start();

        }

        public void InsertIntoDataBase() // производит INSERT запрос в базу данных из API 
        {
            foreach (string cities in listBox_Cities.Items)
            {
                answer = functional.Get_Weather_Api(cities, api_Key);
                OpenWeatherInfo openWeatherInfo = JsonConvert.DeserializeObject<OpenWeatherInfo>(answer);
                direction = functional.Direction(openWeatherInfo.wind.deg, out direct);

                queryString = "INSERT INTO Weather (City_Name, Main, Descript, Degrees, WindSpeed, Direction, Humidity, Pressure, Icon) VALUES ('"
                    + cities + "', '"
                    + openWeatherInfo.weather[0].main + "', '"
                    + openWeatherInfo.weather[0].description + "', "
                    + ((int)openWeatherInfo.main.temp).ToString() + ", "
                    + ((int)openWeatherInfo.wind.speed).ToString() + ", '"
                    + direct + "', "
                    + openWeatherInfo.main.humidity.ToString() + ", "
                    + ((int)openWeatherInfo.main.pressure).ToString() + ", '"
                    + openWeatherInfo.weather[0].icon + "');";
                functional.CreateCommand(queryString, connectionString);
            }
        }
        public void UpdateDataBase() // производит INSERT запрос в базу данных из API 
        {
            foreach (string cities in listBox_Cities.Items)
            {
                answer = functional.Get_Weather_Api(cities, api_Key);
                OpenWeatherInfo openWeatherInfo = JsonConvert.DeserializeObject<OpenWeatherInfo>(answer);
                direction = functional.Direction(openWeatherInfo.wind.deg, out direct);
                queryString = "UPDATE[dbo].[Weather] SET " +
                    "City_Name = '" + cities + "', " +
                    "Main = '" + openWeatherInfo.weather[0].main + "', " +
                    "Descript = '" + openWeatherInfo.weather[0].description + "', " +
                    "Degrees = " + ((int)openWeatherInfo.main.temp).ToString("0.##") + ", " +
                    "WindSpeed = " + ((int)openWeatherInfo.wind.speed).ToString() + ", " +
                    "Direction = '" + direct + "', " +
                    "Humidity = " + openWeatherInfo.main.humidity.ToString() + ", " +
                    "Pressure = " + ((int)openWeatherInfo.main.pressure).ToString() + ", " +
                    "Icon = '" + openWeatherInfo.weather[0].icon + "' " +
                    "WHERE City_Name = ' " + cities + " ';";
                functional.CreateCommand(queryString, connectionString);
                functional.SelectDataBase(connectionString, dataGridView1);
            }
        }


        private void comboBox_Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = comboBox_Cities.SelectedItem.ToString();
            string path = Directory.GetCurrentDirectory() + "/icons/";
            string iconName = "";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Weather] WHERE [City_Name] = '" + city + "';";
            command.Connection = connection;
            SqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    label_Name.Text = reader["City_Name"].ToString().ToUpper();
                    label_main.Text = reader["Main"].ToString().ToUpper();
                    label_Description.Text = reader["Descript"].ToString().ToUpper();
                    label_Degrees.Text = reader["Degrees"].ToString() + "°С";
                    label_WindSpeed.Text = "Wind speed (m/s): " + reader["WindSpeed"].ToString();
                    label_Direction.Text = "Wind direction: " + reader["Direction"].ToString();
                    label_Humidity.Text = "Humidity (%): " + reader["Humidity"].ToString();
                    label_Pressure.Text = "Pressure (mm): " + reader["Pressure"].ToString();
                    iconName = reader["Icon"].ToString();
                    panel_ImageStatus.BackgroundImage = new Bitmap(Image.FromFile($"{path}{iconName}.png"));
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

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Cities.Text != "")
            {
                answer = functional.Get_Weather_Api(city, api_Key);
            }
        }

        private void button_weatherUpdate_Click(object sender, EventArgs e)
        {
            if (comboBox_Cities.Text != "")
            {
                UpdateDataBase();
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
            if (isExist)
            {
                queryString = "DROP TABLE [dbo].[Weather];";
                functional.CreateCommand(queryString, connectionString);
                dataGridView1.Enabled = false;
                isExist = false;
                MessageBox.Show("Table succesfully eliminated!", "Congrats!");
            }
            else
            {
                MessageBox.Show("Create \"Weather\" table because curently it doesn't exist!", "Warning");
            }
            
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            if (!isExist)
            {
                queryString = "CREATE TABLE [dbo].[Weather] (" +
                                                           "[Id] BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY," +
                                                           "[City_Name] nvarchar(50) NOT NULL," +
                                                           "[Main] nvarchar(50) NOT NULL," +
                                                           "[Descript] nvarchar(50) NOT NULL," +
                                                           "[Degrees] INT NOT NULL," +
                                                           "[WindSpeed] INT NOT NULL," +
                                                           "[Direction] nvarchar(50) NOT NULL," +
                                                           "[Humidity]  INT NOT NULL," +
                                                           "[Pressure] int NOT NULL," +
                                                           "[Icon] nvarchar(50) NOT NULL);";
                functional.CreateCommand(queryString, connectionString);
                InsertIntoDataBase();
                isExist = true;
                MessageBox.Show("Table succesfully created!", "Congrats!");
            }
            else
            {
                MessageBox.Show("Table \"Weather\" already exists!", "Warning");
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {           
            queryString = "DROP TABLE [dbo].[Weather];";
            functional.CreateCommand(queryString, connectionString);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = listBox_Cities.SelectedItem.ToString();
            string path = Directory.GetCurrentDirectory() + "/icons/";
            string iconName = "";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM [dbo].[Weather] WHERE [City_Name] = '" + city + "';";
            command.Connection = connection;
            SqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    label_Name.Text = reader["City_Name"].ToString().ToUpper();
                    label_main.Text = reader["Main"].ToString().ToUpper();
                    label_Description.Text = reader["Descript"].ToString().ToUpper();
                    label_Degrees.Text = reader["Degrees"].ToString() + "°С";
                    label_WindSpeed.Text = "Wind speed (m/s): " + reader["WindSpeed"].ToString();
                    label_Direction.Text = "Wind direction: " + reader["Direction"].ToString();
                    label_Humidity.Text = "Humidity (%): " + reader["Humidity"].ToString();
                    label_Pressure.Text = "Pressure (mm): " + reader["Pressure"].ToString();
                    iconName = reader["Icon"].ToString();
                    panel_ImageStatus.BackgroundImage = new Bitmap(Image.FromFile($"{path}{iconName}.png"));
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (string cities in listBox_Cities.Items)
            {
                answer = functional.Get_Weather_Api(cities, api_Key);
                OpenWeatherInfo openWeatherInfo = JsonConvert.DeserializeObject<OpenWeatherInfo>(answer);
                direction = functional.Direction(openWeatherInfo.wind.deg, out direct);
                queryString = "UPDATE[dbo].[Weather] SET " +
                    "City_Name = '" + cities + "', " +
                    "Main = '" + openWeatherInfo.weather[0].main + "', " +
                    "Descript = '" + openWeatherInfo.weather[0].description + "', " +
                    "Degrees = " + ((int)openWeatherInfo.main.temp).ToString("0.##") + ", " +
                    "WindSpeed = " + ((int)openWeatherInfo.wind.speed).ToString() + ", " +
                    "Direction = '" + direct + "', " +
                    "Humidity = " + openWeatherInfo.main.humidity.ToString() + ", " +
                    "Pressure = " + ((int)openWeatherInfo.main.pressure).ToString() + ", " +
                    "Icon = '" + openWeatherInfo.weather[0].icon + "' " +
                    "WHERE City_Name = ' " + cities + " ';";
                functional.CreateCommand(queryString, connectionString);
                functional.SelectDataBase(connectionString, dataGridView1);
            }
        }

        private void changeThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.DimGray;
            groupBox_weather.BackColor = Color.DarkGray;
            panel_ImageStatus.BackColor = Color.DimGray;
            label_Degrees.BackColor = Color.DimGray;
            listBox_Cities.BackColor = Color.MediumPurple;
            groupBox_wind.BackColor = Color.DarkGray;
            this.BackColor = Color.DimGray;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.WhiteSmoke;
            groupBox_weather.BackColor = Color.SeaShell;
            panel_ImageStatus.BackColor = Color.Bisque;
            label_Degrees.BackColor = Color.Bisque;
            listBox_Cities.BackColor = Color.GhostWhite;
            groupBox_wind.BackColor = Color.SeaShell;
            this.BackColor = Color.WhiteSmoke;
        }
    }
}
