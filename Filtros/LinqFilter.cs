using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    public class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {                                   // "selecione apenas os generos únicos" 
            var generosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach(var genero in generosMusicais)
            {
                System.Console.WriteLine($"- {genero}");
            }
        }


        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {                       
                                                    // exibir apenas os nomes dos artistas ordenados
            var artistasOrdenados = musicas.OrderBy(res => res.Artista).Select(res => res.Artista).Distinct().ToList();  
                                                                    // a partir do resultado da lista ordenada, eu vou selecionar só a parte do artista

            foreach(var artista in artistasOrdenados)
            {
                System.Console.WriteLine($"- {artista}");
            }
        }


        public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
        {
                                                    // filtro onde uma condicao seja atendida => todas onde o genero seja igual ao que passei como parâmetro
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
            System.Console.WriteLine($"Exibindo artista por gênero musical >>> {genero}");

            foreach(var item in artistasPorGeneroMusical)
            {
                System.Console.WriteLine($"- {item}");
            }
        }


        public static void FiltrarAsMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            // sempre que eu quiser pegar um subconjunto de uma lista devo usar o Where
            var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
            System.Console.WriteLine(nomeDoArtista);

            foreach(var musica in musicasDoArtista)
            {
                System.Console.WriteLine($"- {musica.Nome}");
            }
        }

        public static void ExibirListaDeMusicasCSharp(List<Musica> musicas)
        {  
            var tonalidade = "C#";                                              // p/ comparar strings tem que usar o equals
            var musicasAgrupadas = musicas.Where(musica => musica.Tonalidades.Equals(tonalidade)).Select(musica => musica.Nome).ToList();
            System.Console.WriteLine($"Músicas cuja tonalidade é C#");

            foreach(var musica in musicasAgrupadas)
            {
                System.Console.WriteLine(musica);
            }
        }
    }
}