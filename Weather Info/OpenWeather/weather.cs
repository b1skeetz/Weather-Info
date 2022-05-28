using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Weather_Info.OpenWeather
{
    class weather
    {
        public string path = "C:/Users/КадыржановД/Documents/GitHub/Weather-Info/Weather Info/icons/";

        public int id;

        public string main;

        public string description;

        public string icon;

        public Bitmap Icon
        {
            get
            {
                return new Bitmap(Image.FromFile($"{path}{icon}.png"));
            }
        }
    }
}
