using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            int numberOfS0 = s.Count('0'.Equals);
            int numberOfS1 = s.Count('1'.Equals);
            int numberOfS2 = s.Count('2'.Equals);
            int numberOfS3 = s.Count('3'.Equals);
            int numberOfS4 = s.Count('4'.Equals);
            int numberOfS5 = s.Count('5'.Equals);
            int numberOfS6 = s.Count('6'.Equals);
            int numberOfS7 = s.Count('7'.Equals);
            int numberOfS8 = s.Count('8'.Equals);
            int numberOfS9 = s.Count('9'.Equals);
            Console.Write(
                " 0: = " + numberOfS0 + "," +
                " 1: = " + numberOfS1 + "," +
                " 2: = " + numberOfS2 + "," +
                " 3: = " + numberOfS3 + "," +
                " 4: = " + numberOfS4 + "," +
                " 5: = " + numberOfS5 + "," +
                " 6: = " + numberOfS6 + "," +
                " 7: = " + numberOfS7 + "," +
                " 8: = " + numberOfS8 + "," +
                " 9: = " + numberOfS9);
            Console.ReadLine();

        }
    }
}
