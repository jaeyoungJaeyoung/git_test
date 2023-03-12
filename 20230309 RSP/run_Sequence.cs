using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230309_RSP
{
    internal class run_Sequence
    {
        green_Lights greenie = new green_Lights();
        red_Lights redie = new red_Lights();

        public void run_1()
        {
            greenie.light_1();
            greenie.light_2();
            redie.light_3();
            redie.light_4();
            greenie.light_5();
            greenie.light_6();
            redie.light_7();
            redie.light_8();
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void run_2()
        {
            redie.light_1();
            redie.light_2();
            greenie.light_3();
            greenie.light_4();
            redie.light_5();
            redie.light_6();
            greenie.light_7();
            greenie.light_8();
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
