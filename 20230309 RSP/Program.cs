
using _20230309_RSP;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        run_Sequence running = new run_Sequence();
       
        while (true)
        {
            running.run_1();
            running.run_2();
        }

    }
}