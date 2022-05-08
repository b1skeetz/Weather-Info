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
        public int id;

        public string main;

        public string description;

        public string icon;

        public Bitmap Icon
        {
            get
            {
                return new Bitmap(Image.FromFile($"/Users/damir/source/repos/Weather Info/Weather Info/bin/Debug/net5.0-windows/icons/{icon}.png"));
            }
        }
    }
}
