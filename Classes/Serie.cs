using DioDesafioSerie.Enuns;
namespace DioDesafioSerie.Classes

{
    public class Serie : Conteudo
    {
        public int temporada;
        public int episodios;

        public Serie(string nome,Tipo tipo, Genero genero, int temporada, int episodios)   
        {
            this.nome = nome;
            this.tipo = tipo;
            this.genero = genero;
            this.temporada = temporada;
            this.episodios = episodios;
        }
        public override string ToString()
        {
            string retorno;
            retorno = $"Título: {this.nome}\nGênero: {this.genero}\nTemporada: {this.temporada}\nEpisodios: {this.episodios}";
            return retorno;
        }
    }
}