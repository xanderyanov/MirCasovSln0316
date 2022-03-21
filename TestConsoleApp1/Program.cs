using System;

namespace TestConsoleApp1
{
    class Program
    {
        static void MakeLevel(int n) {
            string a = "*";
            int i = 0;
            while (i < n+1) {
                Console.WriteLine(a);
                a = a + "*";
                i++;
            }
        }
        static void MakeTree(int n) {
            int i = 1;
            while (i < n+1) {
                MakeLevel(i);
                i++;
            }
        }
        static void Main(string[] args)
        {
            MakeTree(5);
        }
    }
}
