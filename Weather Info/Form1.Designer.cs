
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
            this.components = new System.ComponentModel.Container();
            this.groupBox_weather = new System.Windows.Forms.GroupBox();
            this.listBox_Cities = new System.Windows.Forms.ListBox();
            this.label_SelectCity = new System.Windows.Forms.Label();
            this.button_weatherUpdate = new System.Windows.Forms.Button();
            this.groupBox_wind = new System.Windows.Forms.GroupBox();
            this.label_Direction = new System.Windows.Forms.Label();
            this.label_WindSpeed = new System.Windows.Forms.Label();
            this.label_Pressure = new System.Windows.Forms.Label();
            this.label_Humidity = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.comboBox_Cities = new System.Windows.Forms.ComboBox();
            this.panel_ImageStatus = new System.Windows.Forms.Panel();
            this.label_Degrees = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_update = new System.Windows.Forms.Timer(this.components);
            this.groupBox_weather.SuspendLayout();
            this.groupBox_wind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_weather
            // 
            this.groupBox_weather.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox_weather.Controls.Add(this.listBox_Cities);
            this.groupBox_weather.Controls.Add(this.dataGridView1);
            this.groupBox_weather.Controls.Add(this.label_SelectCity);
            this.groupBox_weather.Controls.Add(this.button_weatherUpdate);
            this.groupBox_weather.Controls.Add(this.groupBox_wind);
            this.groupBox_weather.Controls.Add(this.label_Name);
            this.groupBox_weather.Controls.Add(this.comboBox_Cities);
            this.groupBox_weather.Controls.Add(this.panel_ImageStatus);
            this.groupBox_weather.Controls.Add(this.label_Degrees);
            this.groupBox_weather.Controls.Add(this.label_Description);
            this.groupBox_weather.Controls.Add(this.label_main);
            this.groupBox_weather.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_weather.Location = new System.Drawing.Point(12, 27);
            this.groupBox_weather.Name = "groupBox_weather";
            this.groupBox_weather.Size = new System.Drawing.Size(817, 476);
            this.groupBox_weather.TabIndex = 1;
            this.groupBox_weather.TabStop = false;
            this.groupBox_weather.Text = "Weather";
            // 
            // listBox_Cities
            // 
            this.listBox_Cities.BackColor = System.Drawing.Color.GhostWhite;
            this.listBox_Cities.FormattingEnabled = true;
            this.listBox_Cities.ItemHeight = 22;
            this.listBox_Cities.Items.AddRange(new object[] {
            "Almaty",
            "Amsterdam",
            "Athens",
            "Baghdad",
            "Bangkok",
            "Barcelona",
            "Beijing",
            "Belgrade",
            "Berlin",
            "Bogota",
            "Bratislava",
            "Brussels",
            "Bucharest",
            "Budapest",
            "Buenos Aires",
            "Cairo",
            "Cape Town",
            "Caracas",
            "Chicago",
            "Copenhagen",
            "Dhaka",
            "Dubai",
            "Dublin",
            "Frankfurt",
            "Geneva",
            "Hanoi",
            "Helsinki",
            "Hong Kong",
            "Istanbul",
            "Jakarta",
            "Jerusalem",
            "Johannesburg",
            "Kabul",
            "Karachi",
            "Kyiv",
            "Lagos",
            "Lahore",
            "Lima",
            "Lisbon",
            "Ljubljana",
            "London",
            "Los Angeles",
            "Luxembourg",
            "Madrid",
            "Manila",
            "Marrakesh",
            "Mexico City",
            "Montreal",
            "Moscow",
            "Mumbai",
            "Nairobi",
            "New Delhi ",
            "New York",
            "Nicosia",
            "Nur-Sultan",
            "Oslo",
            "Ottawa",
            "Paris",
            "Prague",
            "Reykjavik",
            "Riga",
            "Rio de Janeiro",
            "Rome",
            "Saint Petersburg",
            "San Francisco",
            "Santiago",
            "São Paulo",
            "Seoul",
            "Shanghai",
            "Singapore",
            "Sofia",
            "Stockholm",
            "Sydney",
            "Tallinn",
            "Tehran",
            "The Hague",
            "Tokyo",
            "Toronto",
            "Venice",
            "Vienna",
            "Vilnius",
            "Warsaw",
            "Washington, D.C.",
            "Wellington",
            "Zagreb"});
            this.listBox_Cities.Location = new System.Drawing.Point(580, 44);
            this.listBox_Cities.Name = "listBox_Cities";
            this.listBox_Cities.Size = new System.Drawing.Size(231, 422);
            this.listBox_Cities.Sorted = true;
            this.listBox_Cities.TabIndex = 7;
            this.listBox_Cities.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label_SelectCity
            // 
            this.label_SelectCity.AutoSize = true;
            this.label_SelectCity.Location = new System.Drawing.Point(580, 19);
            this.label_SelectCity.Name = "label_SelectCity";
            this.label_SelectCity.Size = new System.Drawing.Size(130, 22);
            this.label_SelectCity.TabIndex = 6;
            this.label_SelectCity.Text = "Choose city:";
            // 
            // button_weatherUpdate
            // 
            this.button_weatherUpdate.BackColor = System.Drawing.Color.LightYellow;
            this.button_weatherUpdate.Location = new System.Drawing.Point(749, 460);
            this.button_weatherUpdate.Name = "button_weatherUpdate";
            this.button_weatherUpdate.Size = new System.Drawing.Size(31, 16);
            this.button_weatherUpdate.TabIndex = 4;
            this.button_weatherUpdate.Text = "Update";
            this.button_weatherUpdate.UseVisualStyleBackColor = false;
            this.button_weatherUpdate.Visible = false;
            this.button_weatherUpdate.Click += new System.EventHandler(this.button_weatherUpdate_Click);
            // 
            // groupBox_wind
            // 
            this.groupBox_wind.Controls.Add(this.label_Direction);
            this.groupBox_wind.Controls.Add(this.label_WindSpeed);
            this.groupBox_wind.Controls.Add(this.label_Pressure);
            this.groupBox_wind.Controls.Add(this.label_Humidity);
            this.groupBox_wind.Location = new System.Drawing.Point(6, 300);
            this.groupBox_wind.Name = "groupBox_wind";
            this.groupBox_wind.Size = new System.Drawing.Size(406, 170);
            this.groupBox_wind.TabIndex = 5;
            this.groupBox_wind.TabStop = false;
            this.groupBox_wind.Text = "Data";
            // 
            // label_Direction
            // 
            this.label_Direction.AutoSize = true;
            this.label_Direction.Location = new System.Drawing.Point(6, 99);
            this.label_Direction.Name = "label_Direction";
            this.label_Direction.Size = new System.Drawing.Size(150, 22);
            this.label_Direction.TabIndex = 1;
            this.label_Direction.Text = "Wind direction";
            // 
            // label_WindSpeed
            // 
            this.label_WindSpeed.AutoSize = true;
            this.label_WindSpeed.Location = new System.Drawing.Point(5, 140);
            this.label_WindSpeed.Name = "label_WindSpeed";
            this.label_WindSpeed.Size = new System.Drawing.Size(110, 22);
            this.label_WindSpeed.TabIndex = 0;
            this.label_WindSpeed.Text = "Wind speed";
            // 
            // label_Pressure
            // 
            this.label_Pressure.AutoSize = true;
            this.label_Pressure.Location = new System.Drawing.Point(6, 26);
            this.label_Pressure.Name = "label_Pressure";
            this.label_Pressure.Size = new System.Drawing.Size(90, 22);
            this.label_Pressure.TabIndex = 4;
            this.label_Pressure.Text = "Pressure";
            // 
            // label_Humidity
            // 
            this.label_Humidity.AutoSize = true;
            this.label_Humidity.Location = new System.Drawing.Point(6, 62);
            this.label_Humidity.Name = "label_Humidity";
            this.label_Humidity.Size = new System.Drawing.Size(90, 22);
            this.label_Humidity.TabIndex = 3;
            this.label_Humidity.Text = "Humidity";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Name.Location = new System.Drawing.Point(12, 31);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(89, 37);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "City";
            // 
            // comboBox_Cities
            // 
            this.comboBox_Cities.BackColor = System.Drawing.Color.Lavender;
            this.comboBox_Cities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cities.FormattingEnabled = true;
            this.comboBox_Cities.Location = new System.Drawing.Point(681, 446);
            this.comboBox_Cities.Name = "comboBox_Cities";
            this.comboBox_Cities.Size = new System.Drawing.Size(62, 30);
            this.comboBox_Cities.TabIndex = 2;
            this.comboBox_Cities.Visible = false;
            this.comboBox_Cities.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cities_SelectedIndexChanged);
            // 
            // panel_ImageStatus
            // 
            this.panel_ImageStatus.BackColor = System.Drawing.Color.Bisque;
            this.panel_ImageStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_ImageStatus.Location = new System.Drawing.Point(176, 101);
            this.panel_ImageStatus.Name = "panel_ImageStatus";
            this.panel_ImageStatus.Size = new System.Drawing.Size(110, 110);
            this.panel_ImageStatus.TabIndex = 0;
            // 
            // label_Degrees
            // 
            this.label_Degrees.AutoSize = true;
            this.label_Degrees.BackColor = System.Drawing.Color.Bisque;
            this.label_Degrees.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Degrees.Location = new System.Drawing.Point(304, 99);
            this.label_Degrees.Name = "label_Degrees";
            this.label_Degrees.Size = new System.Drawing.Size(100, 112);
            this.label_Degrees.TabIndex = 2;
            this.label_Degrees.Text = "|";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Location = new System.Drawing.Point(12, 101);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(120, 22);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "Description";
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Location = new System.Drawing.Point(11, 140);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(50, 22);
            this.label_main.TabIndex = 0;
            this.label_main.Text = "Main";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(651, 452);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(24, 24);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.базаДанныхToolStripMenuItem,
            this.aPIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeThemeToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.параметрыToolStripMenuItem.Text = "Settings";
            // 
            // changeThemeToolStripMenuItem
            // 
            this.changeThemeToolStripMenuItem.Name = "changeThemeToolStripMenuItem";
            this.changeThemeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changeThemeToolStripMenuItem.Text = "Change theme";
            // 
            // базаДанныхToolStripMenuItem
            // 
            this.базаДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem});
            this.базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            this.базаДанныхToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.базаДанныхToolStripMenuItem.Text = "Database";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.таблицаToolStripMenuItem.Text = "Weather Table";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.создатьToolStripMenuItem.Text = "Create";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.удалитьToolStripMenuItem.Text = "Delete";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
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
            this.открытьAPIToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.открытьAPIToolStripMenuItem.Text = "Open API";
            this.открытьAPIToolStripMenuItem.Click += new System.EventHandler(this.открытьAPIToolStripMenuItem_Click);
            // 
            // timer_update
            // 
            this.timer_update.Enabled = true;
            this.timer_update.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 515);
            this.Controls.Add(this.groupBox_weather);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_weather.ResumeLayout(false);
            this.groupBox_weather.PerformLayout();
            this.groupBox_wind.ResumeLayout(false);
            this.groupBox_wind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem changeThemeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox_Cities;
        private System.Windows.Forms.Timer timer_update;
    }
}

