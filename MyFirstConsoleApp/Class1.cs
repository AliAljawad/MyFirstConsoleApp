using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int IMEI { get; set; }

        public Phone(string brand, string name, string color, int imei)
        {
            Brand = brand;
            Name = name;
            Color = color;
            IMEI = imei;
        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Name: {Name}, Color: {Color}, IMEI: {IMEI}";
        }
    }
}