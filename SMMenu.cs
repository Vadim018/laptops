using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    class SMMenu : AbstractMenu
    {
        SMPL smPL;
        ConsoleColor defaultColor;
        public SMMenu(SMPL smPL)
        {
            this.smPL = smPL;
        }
        protected override void Init()
        {
            flag = true;
            defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("INIT");
        }
       protected override void Idle()
        {
            Console.WriteLine("1. CREATE");
            Console.WriteLine("2. GET");
            Console.WriteLine("3. FIND BY ID");
            Console.WriteLine("4. DELETE");
            Console.WriteLine("5. UPDATE");
            Console.WriteLine("6. EXIT");

            int menuNumber = int.Parse(Console.ReadLine());

            switch (menuNumber)
            {
                case 1:
                    Console.Clear();
                    smPL.CreateLaptop();
                    Console.WriteLine();
                    break;

                case 2:
                    Console.Clear();
                    smPL.GetAllLaptop();
                    Console.WriteLine();
                    break;

                case 3:
                    Console.Clear();
                    smPL.GetLaptopById();
                    Console.WriteLine();
                    break;

                case 4:
                    Console.Clear();
                    smPL.DeleteLaptop();
                    Console.WriteLine();
                    break;

                case 5:
                    Console.Clear();
                    smPL.UpdateLaptop();
                    Console.WriteLine();
                    break;

                case 6:
                    Console.Clear();
                    flag = false;
                    break;
                default:
                    Console.WriteLine("ERROR! PLEASE, TRY AGAIN...");
                    break;
            }
        }
        protected override void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("CLEANUP");
        }
    }
}