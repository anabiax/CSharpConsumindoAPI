using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos{
    public class Musica 
    {
        [JsonPropertyName("key")]
        public int Key { get; set; }

        private List<string> tonalidades = new()
        {
            "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
        };

        public string Tonalidades { 
            get 
            { 
                return tonalidades[Key];
            } 
        }

        [JsonPropertyName("song")]  // dessa maneira eu consigo mapear/referenciar a prop especifica da estrutura que chega no formato JSON
        public string? Nome { get; set; }


        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        
        [JsonPropertyName("duration_ms")]
        public int? Duracao { get; set; }


        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        public void ExibirDetalhesDaMusica()
        {
            System.Console.WriteLine($"Artista: {Artista}");
            System.Console.WriteLine($"Musica: {Nome}");
            System.Console.WriteLine($"Duracao em segundos: {Duracao/1000}");
            System.Console.WriteLine($"Genero: {Genero}");
            System.Console.WriteLine($"Tonalidade: {Tonalidades}");
        }
    }
}