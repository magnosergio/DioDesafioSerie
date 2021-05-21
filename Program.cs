using System;

namespace DioDesafioSerie
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool run = true;
            Console.WriteLine("Central de Gerenciamento da DIO Entretenimento, Seja Bem-vindo!");
            while (run)
            {
                PrintOptions();
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("\nValor escolhido: " + option);
                            break;
                        case 6:
                            run = false;
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida: Escolha uma das opções!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOpção Inválida: Digite um valor numérico!");
                }
            }
        }
        static void PrintOptions(){
            Console.WriteLine("\nO que deseja fazer:");
            Console.WriteLine("1 - Cadastrar novo conteúdo");
            Console.WriteLine("2 - Listar Conteúdo por tipo");
            Console.WriteLine("3 - Exibir informação do conteúdo");
            Console.WriteLine("4 - Alterar informação sobre um conteúdo");
            Console.WriteLine("5 - Excluir um conteúdo");
            Console.WriteLine("6 - Sair");
            Console.Write("\nOpção:");
        }
    }
}
