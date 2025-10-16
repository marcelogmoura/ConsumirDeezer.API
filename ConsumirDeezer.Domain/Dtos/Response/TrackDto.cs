using System.Text.Json.Serialization;

namespace ConsumirDeezer.Domain.Dtos.Response
{
    public class TrackDto
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; } // Duração em segundos

        [JsonPropertyName("preview")]
        public string Preview { get; set; } // URL para um trecho de 30s da música

        [JsonPropertyName("album")]
        public AlbumInTrackDto Album { get; set; }
    }
        
    public class AlbumInTrackDto
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("cover_medium")]
        public string CoverMedium { get; set; }
    }
}