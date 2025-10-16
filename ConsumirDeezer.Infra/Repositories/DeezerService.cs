using ConsumirDeezer.Domain.Dtos.Response;
using ConsumirDeezer.Domain.Repositories.Services;
using System.Net.Http.Json;

namespace ConsumirDeezer.Infra.Repositories
{
    public class DeezerService : IDeezerService
    {
        private readonly HttpClient _httpClient;
        public DeezerService(HttpClient httpClient)
        {
            _httpClient=httpClient;
        }

        public async Task<ArtistSearchResponseDto> SearchArtistByNameAsync(string artistName)
        {
            var requestUri = $"search/artist?q={artistName}";

            var response = await _httpClient.GetFromJsonAsync<ArtistSearchResponseDto>(requestUri);

            return response ?? new ArtistSearchResponseDto();
        }
    }
}
