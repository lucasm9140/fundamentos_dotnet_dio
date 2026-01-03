// apontando o caminho do namespace da classe usando o using
using System.Linq.Expressions;
using fundamentos_dotnet_dio.Models;

// Switch Case
// Console.WriteLine("Digite Uma Letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//     Console.WriteLine("Esta letra e uma vogal.");
//     break;

//     default:
//     Console.WriteLine("Esta letra nao e uma vogal.");
//     break;
// }


// Console.WriteLine("Digite Uma Letra: ");
// string letra = Console.ReadLine();

// if (letra == "a"||
//     letra == "e"||
//     letra == "i"||
//     letra == "o"||
//     letra == "u")
// {
//     Console.WriteLine("Esta letra e uma vogal.");
// }
// else
// {
//     Console.WriteLine("Esta letra nao e uma vogal.");
// }


// Console.WriteLine("Digite Uma Letra: ");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("Essa letra e uma vogal.");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Essa Letra e uma vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Essa Letra e uma vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Essa Letra e uma vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Essa Letra e uma vogal");
// }







// Operador condicional
// int quantidadeEmEstoque = 10;
// int quantidadeEmCompra = 4;

// if(quantidadeEmEstoque >= quantidadeEmCompra)
// {
//     Console.WriteLine("Venda Realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, nao temos a quantidade desejada em estoque!");
// }

// Operador condicional, passando uma variavel booleana
// int quantidadeEmEstoque = 10;
// int quantidadeEmCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeEmCompra;

// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em Compra: {quantidadeEmCompra}");
// Console.WriteLine($"Será Possível Realizar a Venda: {possivelVenda}");

// if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, nao temos a quantidade em estoque!");
// }
//*************************************************************************************//
//if aninhado
// int quantidadeEmEstoque = 10;
// int quantidadeEmCompra = 4;
// bool possivelVenda = quantidadeEmCompra > 0 && quantidadeEmEstoque >= quantidadeEmCompra;

// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em Compra: {quantidadeEmCompra}");
// Console.WriteLine($"Será Possível Realizar a Venda: {possivelVenda}");

// if (quantidadeEmCompra == 0)
// {
//     Console.WriteLine("Venda Invalida!");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, nao temos a quantidade em estoque!");
// }


// Conversao para tipo string
//int inteiro = 5;
//string a = inteiro.ToString(); // melhor pratica para converter para string.
// nao tem parse para string, e o convert e redundante.
//********************************************************************************//

// Cast implicito
// int a = 5;
// double b = a;
// inteiro cabe no double, por isso ele faz o casting implicito. (sem ver)
// long a = 5;
// int b = a;
// nao permite o casting implicito, sera necessario realizar a conversao.
// long a = 5;
// int b = Convert.ToInt32(a);
//**********************************************************************************//

// Cast - Casting
// Converter uma string para inteiro.
// 1 forma
//int a = Convert.ToInt32("5");
// 2 forma
// int a = int.Parse("5");
//**********************************************************************************//

// Diferença entre convert e parse
// parse nao aceita valor null.
// convert ele aceita null e retorna 0.
//***********************************************************************************//

// Operador de atribuição(= sinal de atribuição, quando quer modificar o valor da variável.)
// int a = 10;
// int b = 20;

// int c = a + b;
// c = c + 5; // 30 + 5
// c += 5; // representara a mesma coisa, esta acrescentando mais 5, somando os valores.
// c -= 5; // subtrai, decremento.
// Console.WriteLine(c);
//**********************************************************//

// // pega a data atual da maquina em uso.
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);
//*********************************************************//


// string aprensentacao = "Seja Bem Vindo";

// int quantidade = 1;
// //Manipulando a variavel
// //quantidade = 10;
// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(aprensentacao);
// Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura);
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da variavel condicao: " + condicao);
//************************************************************************//


// instanciando a classe Pessoa
// Pessoa p1 = new Pessoa();

// p1.Nome = "Dev. Lucas";
// p1.Idade = 28;
// p1.Apresentar();

// Declarando variaveis

//string nome= "LUCAS" 
//int idade = 1;
//double altura = 1.90;
//float altura = 1.90;
// decimal = 1.80M; obs.: o M é obrigatório par contar a casa e o valor monetário.
// bool condicao = true;
