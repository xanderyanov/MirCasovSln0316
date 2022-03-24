using System;

namespace TestConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = a / b;
            //int d = a % b;
            //Console.WriteLine(a + " / " + b + " = " a / b);


            string[] b = Console.ReadLine().Split(new char[] { ' ' });

            int rezult = 0;

            foreach (string s in b)
            {
                rezult += int.Parse(s);
            }

            Console.WriteLine(rezult);
        }
    //Console.WriteLine(int.Parse(b[0]) + int.Parse(b[1]));

    }
}
