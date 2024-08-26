using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte num1 = 100; //8 bits, de 0 a 255
            ushort num2; //16 bits, 0 a 65.535
            //é permitido que a váriavel tipo byte seja "implementada" na variavel tipo ushort, devido que os valores da byte estão sendo abrangidos na váriavel do ushor.
            num2 = num1;

            Console.WriteLine(num2);
            Console.ReadKey();


            //atribuir um tipo de dado em uma variavel de outro tipo, desde que essa váriavel suporte o valor que está recebendo

            float num3 = 1250.45f;
            double num4 = num3;

            int numero = 'C';

            //Deve-se frizar que não importa a váriavel que está sendo marcada ali e sim o tipo de dado que estamos inserindo, como neste exemplo onde não criamos outra variavel.

            Console.WriteLine(numero);
            Console.ReadKey();


        }
    }
}
