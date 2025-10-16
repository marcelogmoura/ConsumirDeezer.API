using System.Text.Json.Serialization;

namespace ConsumirDeezer.Domain.Dtos.Response
{
    public class ArtistSearchResponseDto
    {
        [JsonPropertyName("data")]
        public List<ArtistDto> Data { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
