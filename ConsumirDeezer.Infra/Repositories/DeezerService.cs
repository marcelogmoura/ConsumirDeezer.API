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
        public async Task<TracklistResponseDto> GetArtistTopTracksAsync(long artistId)
        {
            var requestUri = $"artist/{artistId}/top?limit=5";
            var response = await _httpClient.GetFromJsonAsync<TracklistResponseDto>(requestUri);
            return response ?? new TracklistResponseDto();
        }

        public async Task<ArtistSearchResponseDto> SearchArtistByNameAsync(string artistName)
        {
            var requestUri = $"search/artist?q={artistName}";
            var response = await _httpClient.GetFromJsonAsync<ArtistSearchResponseDto>(requestUri);
            return response ?? new ArtistSearchResponseDto();
        }
    }
}
