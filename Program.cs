using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < ints.Length; i++) 
            {
                ints[i] = rnd.Next(0,109099);
                Console.WriteLine(ints[i]);
            }
        }
    }
}
