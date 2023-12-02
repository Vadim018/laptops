using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    internal class SMPL
    {
        LaptopBLL laptopBLL;
        public SMPL(LaptopBLL laptopBLL)
        {
            this.laptopBLL = laptopBLL;
        }
        public void CreateLaptop()
        {
            Console.Write("BRAND: ");
            string brand = Console.ReadLine();

            Console.Write("MODEL: ");
            string model = Console.ReadLine();

            laptopBLL.CreateLaptop(brand, model);
        }
        public void GetAllLaptop()
        {
            List<Laptop> laptops = laptopBLL.GetAllLaptop();

            foreach (Laptop laptop in laptops)
            {
                Console.WriteLine(laptop);
            }
        }
        public void GetLaptopById()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Laptop laptop = laptopBLL.GetLaptopById(id);
            Console.WriteLine(laptop);
        }
        public void DeleteLaptop()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Laptop laptop = laptopBLL.GetLaptopById(id);
            laptopBLL.DeleteLaptop(laptop);
        }
        public void UpdateLaptop()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Laptop oldLaptop = laptopBLL.GetLaptopById(id);
            Console.Write("BRAND: ");

            string brand = Console.ReadLine();
            Console.Write("MODEL: ");

            string model = Console.ReadLine();
            laptopBLL.UpdateLaptop(oldLaptop, brand, model);
        }
    }
}