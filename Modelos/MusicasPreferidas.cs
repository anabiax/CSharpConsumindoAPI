using System.Text.Json;

namespace ScreenSound_04.Modelos
{
    public class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> MusicasFavoritas { get; }


        // ao criar uma nova lista vou atribuir a ela um nome SEMPRE
        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            MusicasFavoritas = new List<Musica>(); // inicializa a lista vazia
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            MusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            System.Console.WriteLine($"Músicas favoritas da: {Nome}");
            foreach (var musica in MusicasFavoritas)
            {
                System.Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            }
        }

        // n recebo algo novo pq tanto a lista das musicas como o nome ja fazem parte da instancia
        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new   // obj anonimo p/ criar uma estrutura temporária
            {
                nome = Nome,
                musicas = MusicasFavoritas,
            });

            string nomeDoArquivo = $"músicas-favoritas-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json); // o segundo é o conteudo do texto

            System.Console.WriteLine($"Arquivo JSON criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
                                                                            // caminho completo do arquivo
        }

        public void GerarDocumentoTXTComAsMusicasFavoritas()
        {
            var nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
            using(StreamWriter arquivo = new StreamWriter(nomeDoArquivo)){
                arquivo.WriteLine($"Músicas favoritas da {Nome}\n");
                foreach(var musica in MusicasFavoritas){
                    arquivo.WriteLine($"- {musica.Nome}");
                }
            }
            System.Console.WriteLine($"TXT gerado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }
    }
}
