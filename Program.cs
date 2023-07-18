using System.Text.Json;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient())  // estou gerenciando um recurso apenas dentro deste escopo. Qnd fechar libero o recurso client
{
    try
    {
        var resposta = await client.GetStringAsync($"https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // ao parsear a classe nunca poderá ser nula! A string deve ter conteúdo
        //System.Console.WriteLine(musicas.Count);
        //musicas[1998].ExibirDetalhesDaMusica();

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistaPorGeneroMusical(musicas, "blues");
        //LinqFilter.FiltrarAsMusicasDeUmArtista(musicas, "ZAYN");

        var musicasPreferidas = new MusicasPreferidas("Ana"); 
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[8]);
        musicasPreferidas.AdicionarMusicasFavoritas(musicas[10]);

        musicasPreferidas.ExibirMusicasFavoritas();

        musicasPreferidas.GerarArquivoJson();
        musicasPreferidas.GerarDocumentoTXTComAsMusicasFavoritas();
        
    }
    catch (Exception ex)
    {
        System.Console.WriteLine($"Falha ao requisitar os dados à API externa. Erro: {ex.Message}");
    }
}

