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
                bool cpfvalido = false;
                bool cnpjvalido = false;
                string nome;
                string email;
                string data_cadastro;
            do
            {
                
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.WriteLine("    Digite a opção:       ");
                Console.WriteLine();
                Console.WriteLine("    1 - Pessoa Física     ");
                Console.WriteLine("    2 - Pessoa Jurídica   ");
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao_pessoa = Console.ReadLine();
                
                if (opcao_pessoa == "1") //pessoa fisica
                {
                    

                    do
                    {
                    Console.WriteLine();
                    Console.Write("Informe o CPF: ");
                    string cpf = Console.ReadLine();
                    cpfvalido = ValidaCpf(cpf);
                        
                        
                    } while (cpfvalido == false);

                    Console.WriteLine();
                    Console.Write("Nome Completo: ");
                    nome = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("E-mail: ");
                    email = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Data de cadastro: ");
                    data_cadastro = Console.ReadLine();

                    correto = true;
                }
                
                if (opcao_pessoa == "2") //pessoa juridica
                {
                     do
                    {
                    Console.WriteLine();
                    Console.Write("Informe o CNPJ: ");
                    string cnpj = Console.ReadLine();
                    cnpjvalido = ValidaCnpj(cnpj);
                        
                        
                    } while (cnpjvalido == false);

                    Console.WriteLine();
                    Console.Write("Nome Completo: ");
                    nome = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("E-mail: ");
                    email = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Data de cadastro: ");
                    data_cadastro = Console.ReadLine();

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

            Console.Clear();
            Console.WriteLine();
            Console.Write("Nome Completo: ");
            nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("E-mail: ");
            email = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Data de cadastro: ");
            data_cadastro = Console.ReadLine();


        }

        //Realiza uma venda
        static void RealizarVenda(){

        }

        //Extrato do cliente
        static void ExtratoCliente(){

        }



        //metodo para validar o cpf
        static bool ValidaCpf(string cpf){
            
             if (cpf.Length != 11){
                Console.WriteLine("CPF inválido");
                return false;
            }
            else{
                int[] multiplicador1 = new int[9]{10,9,8,7,6,5,4,3,2};
                int[] multiplicador2 = new int[10]{11,10,9,8,7,6,5,4,3,2};
                string tempcpf, digito;
                int soma = 0, resto = 0;

                tempcpf = cpf.Substring(0,9);

                for (int i = 0; i < 9; i++){
                   soma += Convert.ToInt16(tempcpf[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;

                if (resto < 2){
                    resto = 0;
                }
                else{
                    resto = 11 - resto;
                }

                digito = resto.ToString();

                tempcpf = tempcpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++){
                    soma += Convert.ToInt16(tempcpf[i].ToString()) * multiplicador2[i];
                }

                resto = soma % 11;

                if (resto <2)
                    resto = 0;
                
                else
                    resto = 11 - resto;
                
                digito = digito + resto.ToString();

              
                if (cpf.EndsWith(digito) == true)
                {
                    return true;
                }
                else
                     return false;

            }
           
            
        }






        //metodo valida cnpj
        static bool ValidaCnpj(string cnpj){
                           
                      if (cnpj.Length != 14){
                Console.WriteLine("CNPJ inválido");
                return false;
            }
            else{
                int[] multiplicador1 = new int[12]{5,4,3,2,9,8,7,6,5,4,3,2};
                int[] multiplicador2 = new int[13]{6,5,4,3,2,9,8,7,6,5,4,3,2};
                string tempcnpj, digito;
                int soma = 0, resto = 0;

                tempcnpj = cnpj.Substring(0,12);

                for (int i = 0; i < 12; i++){
                   soma += Convert.ToInt16(tempcnpj[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;

                if (resto < 2){
                    resto = 0;
                }
                else{
                    resto = 11 - resto;
                }

                digito = resto.ToString();

                tempcnpj = tempcnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++){
                    soma += Convert.ToInt16(tempcnpj[i].ToString()) * multiplicador2[i];
                }

                resto = soma % 11;

                if (resto <2)
                    resto = 0;
                
                else
                    resto = 11 - resto;
                
                digito = digito + resto.ToString();

              
                if (cnpj.EndsWith(digito) == true)
                {
                    return true;
                }
                else
                     return false;

            }
           
            
        }
            
        }


    }
