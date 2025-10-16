using System.Text.Json.Serialization;

namespace ConsumirDeezer.Domain.Dtos
{
    public class ArtistDto
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("picture_medium")]
        public string PictureMedium { get; set; }

        [JsonPropertyName("nb_album")]
        public int NumberOfAlbums { get; set; }

        [JsonPropertyName("nb_fan")]
        public int NumberOfFans { get; set; }

        [JsonPropertyName("tracklist")]
        public string Tracklist { get; set; }
    }
}
