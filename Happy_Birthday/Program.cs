using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Saketh_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            string saketh = "HAPPY BIRTHDAY TO YOU!";
            char[] A = saketh.ToCharArray();
            string saketh1 = "HAPPY BIRTHDAY TO DEAR *SWETA*";
            char[] B = saketh1.ToCharArray();
            string saketh3 = "iiiiiiiiii";
            char[] C = saketh3.ToCharArray();
            Console.Clear();
            Console.Write("\n \t\t\t\t  Loading...0%");
            Thread.Sleep(500);
            for (i = 0; i <= 10; i++)
            {
                Console.Clear();
                Console.Write("\n \t\t\t\t  Loading..." + i + "%");
                Thread.Sleep(100);
            }
            Console.Clear();

            Console.Write("\n \t\t\t\t  Loading...10%\n\t\t");
            for (i = 0; i <= 45; i++)
            {
                Console.Write("-");
                Thread.Sleep(50);
            }
            Console.Write("\n\n\t\t\t\t");
            for (i = 0; i <= 21; i++)
            {
                Console.Write(A[i]);
                Thread.Sleep(100);
            }

            Console.Clear();

            Console.Write("\n \t\t\t\t  Loading...10%");
            Thread.Sleep(500);
            for (i = 10; i <= 20; i++)
            {
                Console.Clear();
                Console.Write("\n \t\t\t\t  Loading..." + i + "%");
                Thread.Sleep(100);
            }

            Console.Clear();

            Console.Write("\n \t\t\t\t  Loading...20%\n\t\t");
            for (i = 0; i <= 45; i++)
            {
                Console.Write("-");
                Thread.Sleep(20);
            }
            Console.Write("\n\n\t\t\t\t");
            for (j = 0; j <= 1; j++)
            {
                for (i = 0; i <= 21; i++)
                {
                    Console.Write(A[i]);
                    Thread.Sleep(100);
                }
                Console.Write("\n\n\t\t\t\t");
            }
            Console.Clear();
            Console.Write("\n \t\t\t\t  Loading...60%\n\t\t");
            for (i = 0; i <= 45; i++)
            {
                Console.Write("-");
                Thread.Sleep(20);
            }
            Console.Write("\n\n\t\t\t\t");
            for (j = 0; j <= 1; j++)
            {
                for (i = 0; i <= 21; i++)
                {
                    Console.Write(A[i]);
                    Thread.Sleep(100);
                }
                Console.Write("\n\n\t\t\t\t");
            }
            for (i = 0; i <= 29; i++)
            {
                Console.Write(B[i]);
                Thread.Sleep(100);
            }
            Thread.Sleep(1000);
            Console.Write("\n\n\t\t\t\t");
            for (i = 0; i <= 21; i++)
            {
                Console.Write(A[i]);
                Thread.Sleep(100);
            }
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("\n \t\t\t\t  Loading...60%");
            Thread.Sleep(500);
            for (i = 60; i <= 100; i++)
            {
                Console.Clear();
                Console.Write("\n \t\t\t\t  Loading..." + i + "%");
                Thread.Sleep(20);
            }
            Console.Clear();
            Console.Write("\n \t\t\t\t  Loading...100%\n\t\t");
            for (i = 0; i <= 45; i++)
            {
                Console.Write("-");
                Thread.Sleep(10);
            }
            Console.Write("\n\n\t\t\t\t");
            for (i = 0; i <= 9; i++)
            {
                Console.Write( C[i]);
                Thread.Sleep(100);
            }
            Console.Write("\n\t\t\t\t");
            for (i = 0; i <= 9; i++)
            {
                Console.Write( C[i]);
                Thread.Sleep(100);
            }
            Console.Write("\n\t\t\t       ");
            for (i = 0; i <= 5; i++)
            {
                Console.Write("_" + C[i]);
                Thread.Sleep(100);
            }
            Console.Write("\n\t\t\t       |");
            for (i = 0; i <= 8; i++)
            {
                Console.Write(" ");
                Thread.Sleep(100);
            }
            Console.Write("  |");
            Console.Write("\n\t\t\t     __|");
            Thread.Sleep(100);
            Console.Write(" 11/04/1993");
            Console.Write(" |__");
            Console.Write("\n\t\t\t    |");
            for (i = 0; i <= 14; i++)
            {
                Console.Write(" ");
                Thread.Sleep(100);
            }
            Console.Write("  |");
            Console.Write("\n\t\t\t  __|");
            Console.Write("HAPPY");
            Console.Write("            |__");

            Console.Write("\n\t\t\t |");
            Console.Write("          BIRTHDAY");
            Console.Write("     |");
            Console.Write("\n\t\t\t |");
            for (i = 0; i <= 19; i++)
            {
                Console.Write(" ");
                Thread.Sleep(100);
            }
            Console.Write("    |");
            Console.Write("\n\t\t\t_|");
            for (i = 0; i <= 18; i++)
            {
                Console.Write("_");
                Thread.Sleep(100);
            }
            Console.Write("_____|__");
            Console.Write("\n\n\t\t\t # HAPPY BIRTHDAY SWETA innocent n sweet  # ");
            Console.Write("\n\n\t\t\tfrom  => Lakshmi Saketh :P :D.....:) ");
            Console.ReadKey();


        }
    }
}
