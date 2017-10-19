using System;

namespace sistema_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do{
                Console.WriteLine("Digite a opção:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Realizar Venda");
                Console.WriteLine("4 - Extrato Cliente");
                Console.WriteLine("9 - Sair");

                //Recebe opção do Cliente
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Castrar cliente");
                        break;
                    case "2":
                        Console.WriteLine("Castrar Produto");
                        break;
                    case "3":
                        Console.WriteLine("Realizar venda");
                        break;
                    case "4":
                        Console.WriteLine("Extrato Cliente");
                        break;            
                    //default:
                }





            }while(opcao != "9");
        }
    }
}
