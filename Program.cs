/*
------------------------------------------------------------------------------------------------------------------
Завдання T9
------------------------------------------------------------------------------------------------------------------
Створити в окремому класі DBItemDAL колекцію об'єктів класу Laptop та вивести інформацію щодо колекції на консоль.
Клас повинен мати такі властивості (поля): 
Id Brand Model
Окремий клас DBItemDAL повинен мати інтерфейс та такі методи:
 * додавання елемента до колекції;
 * отримання всіх елементів з колекції;
 * пошук елемента по Id;
 * видалення елемента з колекції;
 * заміна старого елемента на новий.
Створити окремий клас LaptopBLL з інтерфейсом, методи якого використовують методи класу з колекцією.
Створити окремий клас SalesManagerPL з інтерфейсом, методи якого використовують методи класу LaptopBLL.
Створити дворівневе меню: MainMenu та SalesManagerMenu, використовуючи патерн проектування шаблонний метод та універсальний алгоритм.
Кожне меню в окремому класі.
-------------------------------------------------------------------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            DBItemDAL<Laptop> dbLaptop = new DBItemDAL<Laptop>();

            Laptop laptop1 = new Laptop("HP", "ELITEBOOK");
            dbLaptop.Add(laptop1);

            Laptop laptop2 = new Laptop("HP", "VICTUS");
            dbLaptop.Add(laptop2);

            Laptop laptop3 = new Laptop("HP", "LAPTOP");
            dbLaptop.Add(laptop3);

            LaptopBLL laptopBLL = new LaptopBLL(dbLaptop);

            SMPL smPL = new SMPL(laptopBLL);

            SMMenu smMenu = new SMMenu(smPL);

            MainMenu mainMenu = new MainMenu(smMenu);

            mainMenu.Run();

            Console.ReadKey();
        }
    }
}