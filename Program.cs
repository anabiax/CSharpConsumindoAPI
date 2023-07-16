// estou gerenciando um recurso apenas dentro deste escopo. Qnd fechar libero o recurso client

using (HttpClient client = new HttpClient()){
    try
    {
        string resposta = await client.GetStringAsync($"https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
        System.Console.WriteLine(resposta);     
    } 
    catch(Exception ex)
    {
        //throw ex;
        System.Console.WriteLine($"Falha ao requisitar os dados à API externa. Erro: {ex.Message}"); 
    } 
}

