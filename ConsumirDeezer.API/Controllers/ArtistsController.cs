using ConsumirDeezer.Domain.Repositories.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConsumirDeezer.Api.Controllers
{
    [ApiController] 
    [Route("api/[controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly IDeezerService _deezerService;                
        public ArtistsController(IDeezerService deezerService)
        {
            _deezerService = deezerService;
        }
            
        [HttpGet("search/{artistName}")] // rota GET /api/artists/search/NOME_DO_ARTISTA
        [ProducesResponseType(StatusCodes.Status200OK)] 
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] 
        public async Task<IActionResult> SearchArtists(string artistName)
        {            
            var result = await _deezerService.SearchArtistByNameAsync(artistName);
                     
            return Ok(result);
        }
    }
}