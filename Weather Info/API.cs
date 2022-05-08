using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Info
{
    public partial class API : Form
    {
        private string answer_Api;
        public API(string answer)
        {
            answer_Api = answer;
            InitializeComponent();
        }

        private void API_Load(object sender, EventArgs e)
        {
            richTextBox_Api.Text = answer_Api;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, richTextBox_Api.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
