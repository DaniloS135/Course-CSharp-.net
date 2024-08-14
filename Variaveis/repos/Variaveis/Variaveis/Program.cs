using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Numericas Integrais
            ////Integral assinado
            //sbyte num1 = 10; //8 bits, de -128 a 127
            //short num2 = 20; //16 bits, -32.768 a 32.767
            //int num3 = 30; //32 bit, -2.147.483.648 a 2.147.483.647
            //long num4 = 40L; //64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            ////Integral sem sinal
            //byte num5 = 10;
            //ushort num6 = 20;
            //uint num7 = 30;
            //ulong num9 = 40L;

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion
            #region Números Reais
            //float real1 = 100.5f; //32 bits, intervalo de 1,5 x 10-45 a 3,4 x 1038, precisão de 7 dígitos => Sufixo f, Ex.:10.5f
            //double real2 = 500.754; //64 bits intervalo de 5,0 x 10-324 a 1,7 x 10308, precisão de 15 dígitos => Sufixo d (opcional), Ex.: 10.5d
            //decimal real3 = 752538.457m;//128 bits, intervalo de pelo menos -7,9 x 10-28 a 7,9 x 1028, com precisão de pelo menos 28 dígitos => Sufixo m, Ex.: 10.5m

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra_literal = 'C'; //forma de utilizar as letras de forma literal
            //char código = '\u0041'; //forma de utilizar as letras mas por meio de códigos
            //char escape = '\n'; //forma de utilizar uma quebra de linha, como se fosse o "enter" nos textos
            //char nulo = '\0'; //caractere nulo
            //char barra = '\\'; //forma de utilizar a barra invertida sem dar problema
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (cadeia de caracteres)
            //string texto = @"Danilo Souza\n 2002 @@??$$2"; //é boa para utilizar sequencias de caracteres ou basicamente um texto
            //string mensagem = null; //para deixar nulo
            //mensagem = texto; // para puxar o primeiro e "anular" o nulo

            ////utilizando o "\n" da para fazer uma quebra de linha no meio do texto, talvez haja alguma outra forma mas essa foi a apresentada inicialmente.
            ////se utilizar o @ no começo da mensagem da string, ele vai fazer com que seja ignorado os caracteres de escape, no caso o "\n" seria ignorado da forma de um caractere especial. Ele vai ser apresentado como um texto normal, literalmente um \n.
            #endregion

            var valor = 100; //ela não tem um tipo definido até que seja declarado, se por exemplo utilizamos para algo númerico inicialmente, não poderemos colocar outros caracteres futuramente (ex:Escrever meu nome)
            valor = 20;




            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
