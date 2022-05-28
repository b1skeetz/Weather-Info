
namespace Weather_Info
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_weather = new System.Windows.Forms.GroupBox();
            this.label_SelectCity = new System.Windows.Forms.Label();
            this.button_weatherUpdate = new System.Windows.Forms.Button();
            this.groupBox_wind = new System.Windows.Forms.GroupBox();
            this.label_Direction = new System.Windows.Forms.Label();
            this.label_WindSpeed = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.comboBox_Cities = new System.Windows.Forms.ComboBox();
            this.label_Pressure = new System.Windows.Forms.Label();
            this.panel_ImageStatus = new System.Windows.Forms.Panel();
            this.label_Humidity = new System.Windows.Forms.Label();
            this.label_Degrees = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_weather.SuspendLayout();
            this.groupBox_wind.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_weather
            // 
            this.groupBox_weather.Controls.Add(this.label_SelectCity);
            this.groupBox_weather.Controls.Add(this.button_weatherUpdate);
            this.groupBox_weather.Controls.Add(this.groupBox_wind);
            this.groupBox_weather.Controls.Add(this.label_Name);
            this.groupBox_weather.Controls.Add(this.comboBox_Cities);
            this.groupBox_weather.Controls.Add(this.label_Pressure);
            this.groupBox_weather.Controls.Add(this.panel_ImageStatus);
            this.groupBox_weather.Controls.Add(this.label_Humidity);
            this.groupBox_weather.Controls.Add(this.label_Degrees);
            this.groupBox_weather.Controls.Add(this.label_Description);
            this.groupBox_weather.Controls.Add(this.label_main);
            this.groupBox_weather.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_weather.Location = new System.Drawing.Point(12, 27);
            this.groupBox_weather.Name = "groupBox_weather";
            this.groupBox_weather.Size = new System.Drawing.Size(576, 476);
            this.groupBox_weather.TabIndex = 1;
            this.groupBox_weather.TabStop = false;
            this.groupBox_weather.Text = "Погода";
            // 
            // label_SelectCity
            // 
            this.label_SelectCity.AutoSize = true;
            this.label_SelectCity.Location = new System.Drawing.Point(15, 227);
            this.label_SelectCity.Name = "label_SelectCity";
            this.label_SelectCity.Size = new System.Drawing.Size(160, 22);
            this.label_SelectCity.TabIndex = 6;
            this.label_SelectCity.Text = "Выберите город:";
            // 
            // button_weatherUpdate
            // 
            this.button_weatherUpdate.Location = new System.Drawing.Point(288, 245);
            this.button_weatherUpdate.Name = "button_weatherUpdate";
            this.button_weatherUpdate.Size = new System.Drawing.Size(117, 37);
            this.button_weatherUpdate.TabIndex = 4;
            this.button_weatherUpdate.Text = "Обновить";
            this.button_weatherUpdate.UseVisualStyleBackColor = true;
            this.button_weatherUpdate.Click += new System.EventHandler(this.button_weatherUpdate_Click);
            // 
            // groupBox_wind
            // 
            this.groupBox_wind.Controls.Add(this.label_Direction);
            this.groupBox_wind.Controls.Add(this.label_WindSpeed);
            this.groupBox_wind.Location = new System.Drawing.Point(18, 337);
            this.groupBox_wind.Name = "groupBox_wind";
            this.groupBox_wind.Size = new System.Drawing.Size(397, 110);
            this.groupBox_wind.TabIndex = 5;
            this.groupBox_wind.TabStop = false;
            this.groupBox_wind.Text = "Ветер";
            // 
            // label_Direction
            // 
            this.label_Direction.AutoSize = true;
            this.label_Direction.Location = new System.Drawing.Point(6, 32);
            this.label_Direction.Name = "label_Direction";
            this.label_Direction.Size = new System.Drawing.Size(120, 22);
            this.label_Direction.TabIndex = 1;
            this.label_Direction.Text = "Направление";
            // 
            // label_WindSpeed
            // 
            this.label_WindSpeed.AutoSize = true;
            this.label_WindSpeed.Location = new System.Drawing.Point(6, 73);
            this.label_WindSpeed.Name = "label_WindSpeed";
            this.label_WindSpeed.Size = new System.Drawing.Size(150, 22);
            this.label_WindSpeed.TabIndex = 0;
            this.label_WindSpeed.Text = "Скорость ветра";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Name.Location = new System.Drawing.Point(18, 32);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(107, 37);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Город";
            // 
            // comboBox_Cities
            // 
            this.comboBox_Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cities.FormattingEnabled = true;
            this.comboBox_Cities.Location = new System.Drawing.Point(17, 249);
            this.comboBox_Cities.Name = "comboBox_Cities";
            this.comboBox_Cities.Size = new System.Drawing.Size(231, 30);
            this.comboBox_Cities.TabIndex = 2;
            this.comboBox_Cities.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cities_SelectedIndexChanged);
            // 
            // label_Pressure
            // 
            this.label_Pressure.AutoSize = true;
            this.label_Pressure.Location = new System.Drawing.Point(255, 174);
            this.label_Pressure.Name = "label_Pressure";
            this.label_Pressure.Size = new System.Drawing.Size(90, 22);
            this.label_Pressure.TabIndex = 4;
            this.label_Pressure.Text = "Давление";
            // 
            // panel_ImageStatus
            // 
            this.panel_ImageStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_ImageStatus.Location = new System.Drawing.Point(23, 83);
            this.panel_ImageStatus.Name = "panel_ImageStatus";
            this.panel_ImageStatus.Size = new System.Drawing.Size(110, 110);
            this.panel_ImageStatus.TabIndex = 0;
            // 
            // label_Humidity
            // 
            this.label_Humidity.AutoSize = true;
            this.label_Humidity.Location = new System.Drawing.Point(254, 142);
            this.label_Humidity.Name = "label_Humidity";
            this.label_Humidity.Size = new System.Drawing.Size(100, 22);
            this.label_Humidity.TabIndex = 3;
            this.label_Humidity.Text = "Влажность";
            // 
            // label_Degrees
            // 
            this.label_Degrees.AutoSize = true;
            this.label_Degrees.Location = new System.Drawing.Point(255, 72);
            this.label_Degrees.Name = "label_Degrees";
            this.label_Degrees.Size = new System.Drawing.Size(120, 22);
            this.label_Degrees.TabIndex = 2;
            this.label_Degrees.Text = "Температура";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(255, 37);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(90, 22);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "Описание";
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Location = new System.Drawing.Point(255, 108);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(90, 22);
            this.label_main.TabIndex = 0;
            this.label_main.Text = "Основное";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.базаДанныхToolStripMenuItem,
            this.aPIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.базаДанныхToolStripMenuItem.Text = "База данных";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // aPIToolStripMenuItem
            // 
            this.aPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьAPIToolStripMenuItem});
            this.aPIToolStripMenuItem.Name = "aPIToolStripMenuItem";
            this.aPIToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aPIToolStripMenuItem.Text = "API";
            // 
            // открытьAPIToolStripMenuItem
            // 
            this.открытьAPIToolStripMenuItem.Name = "открытьAPIToolStripMenuItem";
            this.открытьAPIToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.открытьAPIToolStripMenuItem.Text = "Открыть API";
            this.открытьAPIToolStripMenuItem.Click += new System.EventHandler(this.открытьAPIToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(618, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 462);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 515);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox_weather);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_weather.ResumeLayout(false);
            this.groupBox_weather.PerformLayout();
            this.groupBox_wind.ResumeLayout(false);
            this.groupBox_wind.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_weather;
        private System.Windows.Forms.GroupBox groupBox_wind;
        private System.Windows.Forms.Label label_Direction;
        private System.Windows.Forms.Label label_WindSpeed;
        private System.Windows.Forms.Label label_Pressure;
        private System.Windows.Forms.Label label_Humidity;
        private System.Windows.Forms.Label label_Degrees;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Panel panel_ImageStatus;
        private System.Windows.Forms.ComboBox comboBox_Cities;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_weatherUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьAPIToolStripMenuItem;
        private System.Windows.Forms.Label label_SelectCity;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

