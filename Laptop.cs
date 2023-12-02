using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    class Laptop : IID
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Laptop(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public override string ToString()
        {
            return String.Format("ID: " + Id + "     " + "BRAND: " + Brand + "     " + "MODEL: " + Model);
        }
    }
}       