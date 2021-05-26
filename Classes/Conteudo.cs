using DioDesafioSerie.Enuns;
namespace DioDesafioSerie.Classes
{
    public abstract class Conteudo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Tipo tipo { get; set; }
        public Genero genero { get; set; }
    }
}