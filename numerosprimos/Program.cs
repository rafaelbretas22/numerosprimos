using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosprimos
{
    class Program
    {
        static void Main(string[] args)
        {
            calcprimos y = new calcprimos();

            Console.WriteLine("Ate que n°?");
            y.limit = int.Parse(Console.ReadLine());

            Console.ReadKey();

            y.initNumbers(y.limit);
             
            Console.ReadKey();

            y.achareeliminar();
            y.espera();
            y.numerosparastring();
        }
    }
}
