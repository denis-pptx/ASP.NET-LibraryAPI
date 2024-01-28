namespace Library.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenreController(IGenreService genreService) : ControllerBase
{
    private readonly IGenreService _genreService = genreService;

    // POST api/<GenreController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] GenreDto genreDto)
    {
        var result = await _genreService.CreateGenreAsync(genreDto);

        return CreatedAtAction(nameof(Post), new { id = result.Id }, result);
    }

    // GET: api/<GenreController>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _genreService.GetGenresAsync();

        return Ok(result);
    }

    // GET api/<GenreController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _genreService.GetGenreByIdAsync(id);

        return Ok(result);
    }

    // PUT api/<GenreController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] GenreDto genreDto)
    {
        var result = await _genreService.UpdateGenreAsync(id, genreDto);

        return Ok(result);
    }

    // DELETE api/<GenreController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _genreService.DeleteGenreByIdAsync(id);

        return Ok(result);
    }
}
