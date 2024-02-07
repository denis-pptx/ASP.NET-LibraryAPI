namespace Library.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class GenreController(IGenreService genreService) : ControllerBase
{
    private readonly IGenreService _genreService = genreService;

    // POST api/<GenreController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] GenreDto genreDto, CancellationToken cancellationToken)
    {
        var result = await _genreService.CreateAsync(genreDto, cancellationToken);

        return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    // GET: api/<GenreController>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var result = await _genreService.GetAsync(cancellationToken);

        return Ok(result);
    }

    // GET api/<GenreController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var result = await _genreService.GetByIdAsync(id, cancellationToken);

        return Ok(result);
    }

    // PUT api/<GenreController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] GenreDto genreDto, CancellationToken cancellationToken)
    {
        var result = await _genreService.UpdateAsync(id, genreDto, cancellationToken);

        return Ok(result);
    }

    // DELETE api/<GenreController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var result = await _genreService.DeleteByIdAsync(id, cancellationToken);

        return Ok(result);
    }
}
