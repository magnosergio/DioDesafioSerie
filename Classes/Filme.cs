using DioDesafioSerie.Enuns;
namespace DioDesafioSerie.Classes
{
    public class Filme : Conteudo
    {
        public int duracao;

        public Filme(string nome,Tipo tipo, Genero genero, int duracao)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.genero = genero;
            this.duracao = duracao;            
        }
        public override string ToString()
        {
            string retorno;
            retorno = $"Título: {this.nome}\nGênero: {this.genero}\nDuração: {this.duracao}";
            return retorno;
        }
    }
}