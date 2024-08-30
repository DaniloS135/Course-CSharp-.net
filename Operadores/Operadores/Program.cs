using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores Matemáticos
            //int num1 = 10;
            //int num2 = 2;

            //int resultado = num1 + num2;

            //Console.WriteLine(resultado); //ou podemos usar sem a variavel, ex: Console.WriteLine (num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);
            //Console.ReadKey();
            #endregion

            int num1 = 100;
            int num2 = 10;
            int num3 = 5;

            int res = (num1 + num2) * num3;

            Console.WriteLine(res);
            Console.ReadKey();
            //ordem de prioridade = 1° (), 2° * e /, 3° + e -. Se tiverem o mesmo nivel de prioridade, vão fazer da esquerda para direita.

        }
    }
}
