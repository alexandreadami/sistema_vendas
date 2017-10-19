using System;

namespace sistema_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do{
                
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.WriteLine("Digite a opção:");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Realizar Venda");
                Console.WriteLine("4 - Extrato Cliente");
                Console.WriteLine("9 - Sair");
                Console.WriteLine();
                Console.WriteLine("===========================");

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

        //metodo para validar o cpf
        static bool ValidaCpf(string cpf){
            bool cpfvalido = false;

            if(cpf == "55349862120")
                cpfvalido = true;

                return cpfvalido;
        }

        //metodo valida cnpj
        static bool ValindaCnpj(string cnpj){
            bool cnpjvalido = false;

            if(cnpj == "00744472000159")
                cnpjvalido = true;
                return cnpjvalido;
            
        }


    }
}
