using ConsumirDeezer.Domain.Dtos.Response;

namespace ConsumirDeezer.Domain.Repositories.Services
{
    public interface IDeezerService
    {
        Task<ArtistSearchResponseDto> SearchArtistByNameAsync(string artistName);
        Task<TracklistResponseDto> GetArtistTopTracksAsync(long artistId);
    }
}
