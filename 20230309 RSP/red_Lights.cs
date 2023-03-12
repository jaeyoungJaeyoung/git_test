using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230309_RSP
{
    internal class red_Lights
    {
        public void light_1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 0);
            Console.Write("■");
        }
        public void light_2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 0);
            Console.Write("■");
        }
        public void light_3()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(15, 5);
            Console.Write("■");
        }
        public void light_4()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(15, 10);
            Console.Write("■");
        }
        public void light_5()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(10, 15);
            Console.Write("■");
        }
        public void light_6()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 15);
            Console.Write("■");
        }
        public void light_7()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 10);
            Console.Write("■");
        }
        public void light_8()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 5);
            Console.Write("■");
        }
    }
}
