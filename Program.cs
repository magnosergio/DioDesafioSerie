using System;
using DioDesafioSerie.Enuns;
using DioDesafioSerie.Classes;
using DioDesafioSerie.Repositorio;

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
                int option = LerOpcao(6);
                switch (option)
                    {
                        case 1:
                            Inserir();
                            break;
                        case 2:
                            ListarConteudo();
                            break;
                        case 3:
                            ExibirInfo();
                            break;
                        case 4:
                            AlterarInfo();
                            break;
                        case 5:
                            ExcluirContúdo();
                            break;
                        case 6:
                            run = false;
                            break;
                    }
            }
        }

        private static void ExcluirContúdo()
        {
            foreach(int i in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Tipo),i)}");
            }
            Console.WriteLine("Qual conteúdo você deseja excluir:");
            int option = LerOpcao(Enum.GetNames(typeof(Tipo)).Length);
            switch (option)
            {
                case 1:
                    FilmeRepositorio.Exclui();
                    break;
                case 2:
                    SerieRepositorio.Exclui();
                    break;
            }
        }

        private static void AlterarInfo()
        {
            foreach(int i in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Tipo),i)}");
            }
            Console.WriteLine("Qual conteúdo você deseja alterar informações:");
            int option = LerOpcao(Enum.GetNames(typeof(Tipo)).Length);
            switch (option)
            {
                case 1:
                    FilmeRepositorio.AlterarInfo();
                    break;
                case 2:
                    SerieRepositorio.AlterarInfo();
                    break;
            }            
        }

        private static void ExibirInfo()
        {
            foreach(int i in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Tipo),i)}");
            }
            Console.WriteLine("Qual conteúdo você deseja ver informações:");
            int option = LerOpcao(Enum.GetNames(typeof(Tipo)).Length);
            switch (option)
            {
                case 1:
                    FilmeRepositorio.ExibirInfo();
                    break;
                case 2:
                    SerieRepositorio.ExibirInfo();
                    break;
            }
        }

        private static void ListarConteudo()
        {
            foreach(int i in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Tipo),i)}");
            }
            Console.WriteLine("\nQual tipo você deseja listar:");
            int option = LerOpcao(Enum.GetNames(typeof(Tipo)).Length);
            switch (option)
            {
                case 1:
                    FilmeRepositorio.Listar();    
                    break;
                case 2:
                    SerieRepositorio.Listar();
                    break;
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
        public static int LerOpcao(int numOpcao)
        {
            int i = numOpcao;
            int option = 0;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int o))
                {
                    option = o;
                    if (!(option >= 1 && option<=i))
                    {
                        Console.WriteLine("Valor inválido, tente outra vez");
                    }
                }  
            } 
            while (!(option >= 1 && option<=i));
            return option;
        }
        private static void Inserir()
        {
            foreach(int i in Enum.GetValues(typeof(Tipo)))
            {
                Console.WriteLine($"{i}-{Enum.GetName(typeof(Tipo),i)}");
            }
            Console.WriteLine("\nEscolha o tipo de conteúdo a ser inserido:");
            int option = LerOpcao(Enum.GetNames(typeof(Tipo)).Length);
            switch(option)
            {
                case 1:
                    Console.WriteLine("\nQual o nome do filme:");
                    string nome = Console.ReadLine();
                    foreach(int i in Enum.GetValues(typeof(Genero)))
                    {
                        Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero),i)}");
                    }
                    Console.WriteLine("\nEscolha o gênero do conteúdo a ser inserido:");
                    int genero = LerOpcao(Enum.GetNames(typeof(Genero)).Length);
                    Console.WriteLine("\nDigite a duração em min do conteúdo a ser inserido:");
                    int duracao = LerOpcao(600);
                    Filme novoFilme = new Filme(nome, (Tipo)option, (Genero)genero, duracao);
                    FilmeRepositorio.Insere(novoFilme);
                    break;
                case 2:
                    Console.WriteLine("\nQual o nome da Serie:");
                    nome = Console.ReadLine();
                    foreach(int i in Enum.GetValues(typeof(Genero)))
                    {
                        Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero),i)}");
                    }
                    Console.WriteLine("\nEscolha o gênero do conteúdo a ser inserido:");
                    genero = LerOpcao(Enum.GetNames(typeof(Genero)).Length);
                    Console.WriteLine("\nDigite a temporada do conteúdo a ser inserido:");
                    int temporada = LerOpcao(100);
                    Console.WriteLine("\nDigite o numero de episodios do conteúdo a ser inserido:");
                    int episodios = LerOpcao(100);
                    Serie novaSerie = new Serie(nome, (Tipo)option, (Genero)genero, temporada, episodios);
                    SerieRepositorio.Insere(novaSerie);
                    break;
            }

        }
    }
}
