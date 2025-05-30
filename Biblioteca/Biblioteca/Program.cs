using System;

namespace Biblioteca
{
    class exemplo
    {
        static void Main(string[] args)




        {

            const int maxLivros= 100;
            string[] cadastroNomeLivro = new string[maxLivros];
            string[] cadastroAutorLivro = new string[maxLivros];
            string[] cadastroTipoLivro = new string[maxLivros];
            int estoqueLivros = 0;



            int opcao;
            string nomeLivro;
            string tipoLivro;
            string autorLivro;
            string nome;
            string tel;
            string rg;
            string endereco;

            do
            {

                Console.WriteLine(" ________________________________");
                Console.WriteLine(" | MENU PRINCIPAL DA BIBLIOTECA |");
                Console.WriteLine(" |   ESCOLHA UMA OPÇÃO ABAIXO   |");
                Console.WriteLine(" | 1. cadastrar livro           |");
                Console.WriteLine(" | 2. cadastrar cliente         |");
                Console.WriteLine(" | 3. Livros em estoque         |");
                Console.WriteLine(" | 4. Informações de cliente    |");
                Console.WriteLine(" | 5. sair                      |");
                Console.WriteLine(" |______________________________|");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();



                switch (opcao)
                {
                    case 1:
                    novocadastro:

                        


                        Console.Clear();

                        Console.WriteLine("{estoqueLivros++}");
                        

                            Console.WriteLine("|  Digite o nome do livro:");
                            cadastroNomeLivro[estoqueLivros] = Console.ReadLine();
                            Console.WriteLine("|  Digite o tipo do livro:");
                            cadastroTipoLivro[estoqueLivros] = Console.ReadLine();
                            Console.WriteLine("|  Digite o autor do livro");
                            cadastroAutorLivro[estoqueLivros] = Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine("|" + cadastroNomeLivro[estoqueLivros]);
                            Console.WriteLine("|" + cadastroTipoLivro[estoqueLivros]);
                            Console.WriteLine("|" + cadastroAutorLivro[estoqueLivros]);



                            Console.WriteLine(" ** LIVRO CADASTRAO COM SUCESSO!! **");

                            Console.Write(" \n\nDeseja cadastrar mais algum livro? [s/n]");
                            opcao = Char.Parse(Console.ReadLine());
                        
                        if (opcao == 's' || opcao == 'S')
                        {
                            goto novocadastro;
                        }else if(opcao == 'n' || opcao == 'N')
                        {
                            Console.Clear();
                            Console.WriteLine("\n Livros cadastrados!!\n pressiome enter para voltar ao menu da biblioteca. ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Letra digitada invalida, encerrando cadastro de\nlivros e voltando para menu biblioteca!\npressione enter para continuar! ");
                            Console.ReadLine();
                            Console.Clear();
                            
                        }
                        
                        
                        
                        break;

                        
                        

                    case 2:

                        novocadastrocliente:
                        Console.Clear();

                        Console.Write("|  Nome:");
                        nome = Console.ReadLine();

                        Console.Write("|  Rg:");
                        rg = Console.ReadLine();

                        Console.Write("|  Tel:");
                        tel = Console.ReadLine();

                        Console.Write("|  Endereço:");
                        endereco = Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("__________________________________________________");
                        Console.WriteLine("|  " + nome);
                        Console.WriteLine("|  " + rg);
                        Console.WriteLine("|  " + tel);
                        Console.WriteLine("|  " + endereco);
                        Console.WriteLine("|________________________________________________|\n\n");
                        Console.WriteLine(" ** CLIENTE CADSTRADO COM SUCESSO **");

                        Console.WriteLine(" \n\nVoce deseja cadastrar mais algum cliente?{s/n]");
                        opcao = char.Parse(Console.ReadLine());

                        if(opcao == 'S' || opcao == 's')
                        {
                            Console.Clear() ;
                            goto novocadastrocliente;
                        }else if (opcao == 'n' || opcao == 'N')
                        {
                            Console.Clear();
                            Console.WriteLine("Cadastros realizados com sucesso !!\nvoltando para o menu da biblioteca!\npressione enter ");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Comando invalido!!\nEncerrando cadastro de clientes \ne voltando para o menu biblioteca, \npressione enter para continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }




                        break;

                    case 3:
                        foreach (int i in estoqueLivros)
                        {
                            Console.WriteLine(estoqueLivros);
                           
                        }
                        
                        break;

                    case 4:
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Saindo em 3 2 1 ...");
                        break;

                    default:
                        Console.WriteLine("Opção inexistente , tente novamente.");
                        break;

                }
            } while (opcao != 5);

        }
    }
}