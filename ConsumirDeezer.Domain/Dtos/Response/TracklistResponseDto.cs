using System.Text.Json.Serialization;

namespace ConsumirDeezer.Domain.Dtos.Response
{
    public class TracklistResponseDto
    {
        [JsonPropertyName("data")]
        public List<TrackDto> Data { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}