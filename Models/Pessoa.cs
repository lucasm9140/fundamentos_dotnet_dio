using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos_dotnet_dio.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            //caso o parametro fique muito grande, para organizar pode usar
            //dessa maneira fecha aspas coloca o + e na outra linha $ abrindo a aspas.
            //Console.WriteLine($"Olá Meu Nome é {Nome}" +
            //"$e Tenho Idade de {Idade} anos.");

            //maneira normal
            //Console.WriteLine($"Olá Meu Nome é {Nome}, e tenho Idade de {Idade} anos.");

            // Quebra de linha \n
            Console.WriteLine($"Olá Meu Nome é {Nome} \n e tenho Idade de {Idade} anos.");
        }
    }
}