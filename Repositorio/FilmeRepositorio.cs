using System.Collections.Generic;
using DioDesafioSerie.Classes;
using DioDesafioSerie.Enuns;
using System;

namespace DioDesafioSerie.Repositorio
{
    public static class FilmeRepositorio
    {
        private static List<Filme> filme = new List<Filme>();
        static int id = 0;

        public static void Insere(Filme novoFilme)
        {
            filme.Add(novoFilme);
            id += 1;
            filme[filme.Count-1].id = id;
            Console.WriteLine($"\nFilme adicionado: {filme[filme.Count-1].id}-{filme[filme.Count-1].nome}");
        }

        public static void Exclui()
        {
            Console.WriteLine("\nQual o id do filme para excluir");
            int id = Program.LerOpcao(filme.Count);
            for (int i = 0; i < filme.Count; i++)
            {
                if (filme[i].id == id)
                {
                    Console.WriteLine($"\n Item\n{filme[i].ToString()}\n Foi removido.");
                    filme.RemoveAt(i);
                }
            }
        }
        public static void Listar()
        {
            if (filme.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado");
                return;                
            }
            foreach (var item in filme)
            {
                Console.WriteLine($"Id: {item.id} - Título: {item.nome} - Gênero: {item.genero}");
            }
        }

        public static void ExibirInfo()
        {
            Console.WriteLine("\nQual o id do filme a exibir as informações");
            int id = Program.LerOpcao(filme.Count);
            foreach (var item in filme)
            {
                if (item.id == id)
                {
                    Console.WriteLine(item.ToString());                  
                }
            }
        }

        public static void AlterarInfo()
        {

            Console.WriteLine("\nQual o id do filme a alterar as informações");
            int id = Program.LerOpcao(filme.Count);
            for (int i = 0; i < filme.Count; i++)
            {
                if (filme[i].id == id)
                {
                    Console.WriteLine(filme[i].ToString());
                    id = i;
                }
            }
            Console.WriteLine("Digite o título do filme: ");
            filme[id].nome = Console.ReadLine();
            foreach(int i in Enum.GetValues(typeof(Genero)))
                    {
                        Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero),i)}");
                    }
            Console.WriteLine("Selecione o gênero do título: ");
            int genero = Program.LerOpcao(Enum.GetNames(typeof(Genero)).Length);
            filme[id].genero = (Genero)genero;
            Console.WriteLine("Qual a duração: ");
            filme[id].duracao = Program.LerOpcao(600);
        }
    }
}