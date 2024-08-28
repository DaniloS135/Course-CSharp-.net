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
            #region Conversão Implícita
            //byte num1 = 100; //8 bits, de 0 a 255
            //ushort num2; //16 bits, 0 a 65.535
            ////é permitido que a váriavel tipo byte seja "implementada" na variavel tipo ushort, devido que os valores da byte estão sendo abrangidos na váriavel do ushor.
            //num2 = num1;

            //Console.WriteLine(num2);
            //Console.ReadKey();


            ////atribuir um tipo de dado em uma variavel de outro tipo, desde que essa váriavel suporte o valor que está recebendo

            //float num3 = 1250.45f;
            //double num4 = num3;

            //int numero = 'C';

            ////Deve-se frizar que não importa a váriavel que está sendo marcada ali e sim o tipo de dado que estamos inserindo, como neste exemplo onde não criamos outra variavel.

            //Console.WriteLine(numero);
            //Console.ReadKey();
            #endregion

            #region Conversão Explícita
            //ushort num1 = 100;
            //byte num2 = (byte)num1; //se não colocarmos o tipo de valor entre () vai dar erro no projeto pelo motivo de estarmos tentando puxar uma váriavel maior para uma menor. Colocando o tipo de dados entre (), informamos que sabemos dos riscos de perda de dado e que pode puxar os dados da outra variavel.

            //Console.WriteLine(num2);
            //Console.ReadKey();

            //float num3 = 2500f;
            //int num4 = (int)num3;

            //float num5 = 2500.786f;
            //int num6 = (int) 3500.45f;  //mostra que não precisa colocar o "float", pode colocar o dado/número direto e apenas informar a variavel que deseja "limitar"/abranger 

            //Console.WriteLine(num4);
            //Console.ReadKey();

            //char letra = (char)97;
            //Console.WriteLine(letra);
            //Console.ReadKey();
            #endregion

            string txtNumero = "1985";

            int numero = int.Parse (txtNumero);

            byte num1 = byte.Parse("155");

            double num2 = double.Parse ("125632,57");

            float num3 = float.Parse("457,75");

            //todos os tipos númericos possuem o método Parse, onde temos que passar por parametro um valor string que represente um valor númerico. A string pode estar em formato de variavel ou na forma literal.
            //lembrando que as casas decimais devem ser separadas por virgula e não por pontos e o float não precisa da letra F


            Console.WriteLine(numero);
            Console.ReadKey();










        }
    }
}
