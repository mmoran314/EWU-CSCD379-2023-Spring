using Microsoft.AspNetCore.Mvc;
using Wordle.Api.Services;

namespace Wordle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly WordService _wordService;
        public WordController(WordService wordService)
        {
            _wordService = wordService;
        }
        [HttpGet]
        
        public string Get()
        {
            return _wordService.GetRandomWord();
        }
    }
}
