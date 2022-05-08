
namespace Weather_Info
{
    partial class API
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_Api = new System.Windows.Forms.RichTextBox();
            this.label_info = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox_Api
            // 
            this.richTextBox_Api.Location = new System.Drawing.Point(12, 82);
            this.richTextBox_Api.Name = "richTextBox_Api";
            this.richTextBox_Api.Size = new System.Drawing.Size(254, 290);
            this.richTextBox_Api.TabIndex = 1;
            this.richTextBox_Api.Text = "";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_info.Location = new System.Drawing.Point(12, 38);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(117, 25);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "API погоды: ";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(293, 82);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "WeatherAPI";
            this.saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            // 
            // API
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.richTextBox_Api);
            this.Name = "API";
            this.Text = "API";
            this.Load += new System.EventHandler(this.API_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Api;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}