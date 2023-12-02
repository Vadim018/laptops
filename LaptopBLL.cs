using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    class LaptopBLL
    {
        DBItemDAL<Laptop> dbLaptop;
        public LaptopBLL(DBItemDAL<Laptop> dbLaptop)
        {
            this.dbLaptop = dbLaptop;
        }
        public void CreateLaptop(string brand, string model)
        {
            Laptop laptop = new Laptop(brand, model);

            dbLaptop.Add(laptop);
        }
        public List<Laptop> GetAllLaptop()
        {
            return dbLaptop.Items;
        }
        public Laptop GetLaptopById(int id)
        {
            return dbLaptop.GetById(id);
        }
        public void DeleteLaptop(Laptop laptop)
        {
            
            dbLaptop.Delete(laptop);
        }
        public void UpdateLaptop(Laptop oldLaptop, string brand, string model)
        {
            Laptop newLaptop = new Laptop(brand, model);

            dbLaptop.Update(oldLaptop, newLaptop);
        }
    }
}