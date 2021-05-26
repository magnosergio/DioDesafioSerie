using System.Collections.Generic;
using DioDesafioSerie.Classes;
using DioDesafioSerie.Enuns;
using System;

namespace DioDesafioSerie.Repositorio
{
    public static class SerieRepositorio
    {
        private static List<Serie> serie = new List<Serie>();

        public static void Insere(Serie novaSerie)
        {
            serie.Add(novaSerie);
            serie[serie.Count-1].id = serie.Count;
            Console.WriteLine($"\nSérie adicionado: {serie[serie.Count-1].id}-{serie[serie.Count-1].nome}");
        }

        public static void Exclui()
        {
            Console.WriteLine("\nQual o id da Serie para excluir");
            int id = Program.LerOpcao(serie.Count);
            for (int i = 0; i < serie.Count; i++)
            {
                if (serie[i].id == id)
                {
                    Console.WriteLine($"\n Item\n{serie[i].ToString()}\n Foi removido.");
                    serie.RemoveAt(i);
                }
            }
        }
        public static void Listar()
        {
            if (serie.Count == 0)
            {
                Console.WriteLine("Nenhuma serie cadastrado");
                return;                
            }
            foreach (var item in serie)
            {
                Console.WriteLine($"Id: {item.id} - Título: {item.nome} - Gênero: {item.genero}");
            }
        }

        public static void ExibirInfo()
        {
            Console.WriteLine("\nQual o id do filme a exibir as informações");
            int id = Program.LerOpcao(serie.Count);
            foreach (var item in serie)
            {
                if (item.id == id)
                {
                    Console.WriteLine(item.ToString());                    
                }
            }            
        }

        internal static void AlterarInfo()
        {

            Console.WriteLine("\nQual o id do filme a alterar as informações");
            int id = Program.LerOpcao(serie.Count);
            for (int i = 0; i < serie.Count; i++)
            {
                if (serie[i].id == id)
                {
                    Console.WriteLine(serie[i].ToString());
                    id = i;
                }
            }
            Console.WriteLine("Digite o título da série: ");
            serie[id].nome = Console.ReadLine();
            foreach(int i in Enum.GetValues(typeof(Genero)))
                    {
                        Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero),i)}");
                    }
            Console.WriteLine("Selecione o gênero do título: ");
            int genero = Program.LerOpcao(Enum.GetNames(typeof(Genero)).Length);
            serie[id].genero = (Genero)genero;
            Console.WriteLine("Qual a temporada: ");
            serie[id].temporada = Program.LerOpcao(100);
            Console.WriteLine("Qual a episodios: ");
            serie[id].episodios = Program.LerOpcao(100);
        }
    }
}