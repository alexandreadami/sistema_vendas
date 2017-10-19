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
                        CadastrarCliente();
                        break;
                    case "2":
                        CadastrarProduto();
                        break;
                    case "3":
                        RealizarVenda();
                        break;
                    case "4":
                        ExtratoCliente();
                        break;            
                    //default:
                }

            }while(opcao != "9");
        }

        //Cadastra um novo cliente
        static void CadastrarCliente(){

        }

        //Cadastra um novo produto
        static void CadastrarProduto(){

        }

        //Realiza uma venda
        static void RealizarVenda(){

        }

        //Extrato do cliente
        static void ExtratoCliente(){

        }

    }
}
