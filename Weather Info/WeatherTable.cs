using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Weather_Info
{
    public partial class WeatherTable : Form
    {
        Functional functional = new Functional();
        string queryString = "SELECT * FROM weather.weatherInfo;";
        string connectionString = "server=localhost;user=root;database=weather;password=IosifStalin2;";
        public WeatherTable()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand();
            command.CommandText = queryString;
            command.Connection = connection;
            MySqlDataReader reader;
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: \r\n{0}", ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        private void WeatherTable_Load(object sender, EventArgs e)
        {

        }
    }
}
