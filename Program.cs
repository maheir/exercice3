using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;

            Console.WriteLine("valeur de a");
            a = Console.ReadLine();
            Console.WriteLine("valeur de b");
            b = Console.ReadLine();
            int first = int.Parse(a);
            int second = int.Parse(b);


            

            first = first + 33;
            second = second + 1;

            Console.WriteLine("voici le résultat " + first / second);



        }
    }
}
