using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace T9
{
    class MainMenu : AbstractMenu
    {
        SMMenu smMenu;
        ConsoleColor defaultColor;
        public MainMenu(SMMenu smMenu)
        {
            this.smMenu = smMenu;
        }
        protected override void Init()
        {
            flag = true;
            defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("INIT");
        }
        protected override void Idle()
        {
            Console.WriteLine("1 - LAPTOPS");
            Console.WriteLine("2 - EXIT");

            int menuNumber = int.Parse(Console.ReadLine());

            switch (menuNumber)
            {
                case 1:
                    smMenu.Run();
                    break;
                case 2:
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