using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaSaida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Danilo"); //imprime a mensagem e faz a quebra de linha

            //Console.Write("Souza"); //imprime a mensagem mas não faz a quebra de linha

            //Console.Read(); //realiza a captura do caractere, captura apenas o primeiro caracter, podemos tambem dar ENTER para seguir para o proximo código e pode armazenar em uma variavel,  por exemplo na linha de baixo:

            //int codigo = Console.Read();

            string texto = Console.ReadLine(); //lê a linha inteira e retorna como uma string, logo podemos utilizar de diversas formas. Um exemplo de uso está na linha abaixo, pedindo para Writeline reescrever o valor digitado anteriormente.
            Console.WriteLine(texto);

            Console.ReadKey();  //deixa o cursor aguardando para que digite
        }
    }
}
