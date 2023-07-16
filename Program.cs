// estou gerenciando um recurso apenas dentro deste escopo. Qnd fechar libero o recurso client

using System.Text.Json;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient()){
    try
    {
        var resposta = await client.GetStringAsync($"https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // ao parsear a classe nunca poderá ser nula! A string deve ter conteúdo
        //System.Console.WriteLine(musicas.Count);
        musicas[1998].ExibirDetalhesDaMusica();
        
    } 
    catch(Exception ex)
    {
        //throw ex;
        System.Console.WriteLine($"Falha ao requisitar os dados à API externa. Erro: {ex.Message}"); 
    } 
}

