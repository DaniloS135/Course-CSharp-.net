﻿using System;
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

            int num1 = 10;
            int num2 = 2;

            int resultado = num1 + num2;

            Console.WriteLine(resultado); //ou podemos usar sem a variavel, ex: Console.WriteLine (num1 + num2);
            Console.WriteLine(num1 - num2);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num1 % num2);
            Console.ReadKey();


        }
    }
}
