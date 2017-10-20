using System;

namespace sistema_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            do{
                Console.Clear();
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.WriteLine("    Digite a opção:");
                Console.WriteLine();
                Console.WriteLine("    1 - Cadastrar Cliente");
                Console.WriteLine("    2 - Cadastrar Produto");
                Console.WriteLine("    3 - Realizar Venda");
                Console.WriteLine("    4 - Extrato Cliente");
                Console.WriteLine("    9 - Sair");
                Console.WriteLine();
                Console.WriteLine("===========================");
                
                //Recebe opção do Cliente
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        CadastrarCliente();
                        break;
                    case "2":
                        Console.Clear();
                        CadastrarProduto();
                        break;
                    case "3":
                        Console.Clear();
                        RealizarVenda();
                        break;
                    case "4":
                        Console.Clear();
                        ExtratoCliente();
                        break;            
                    //default:
                }


            }while(opcao != "9");
        }

        //Cadastra um novo cliente
        static void CadastrarCliente(){
                string opcao_pessoa = "";
                bool correto = false;
            do
            {
                
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.WriteLine("    Digite a opção: ");
                Console.WriteLine();
                Console.WriteLine("    1 - Pessoa Física");
                Console.WriteLine("    2 - Pessoa Jurídica");
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao_pessoa = Console.ReadLine();
                if (opcao_pessoa == "1")
                {
                    

                    correto = true;
                }
                if (opcao_pessoa == "2")
                {
                    

                    correto = true;
                }
                if ((opcao_pessoa != "1") || (opcao_pessoa != "2"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                }

                
            } while (correto != true);

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
