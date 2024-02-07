namespace Library.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class AuthorController(IAuthorService authorService) : ControllerBase
{
    private readonly IAuthorService _authorService = authorService;

    // POST api/<AuthorController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AuthorDto authorDto, CancellationToken cancellationToken)
    {
        var result = await _authorService.CreateAsync(authorDto, cancellationToken);

        return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    // GET: api/<AuthorController>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var result = await _authorService.GetAsync(cancellationToken);

        return Ok(result);
    }

    // GET api/<AuthorController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var result = await _authorService.GetByIdAsync(id, cancellationToken);

        return Ok(result);
    }

    // PUT api/<AuthorController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] AuthorDto authorDto, CancellationToken cancellationToken)
    {
        var result = await _authorService.UpdateAsync(id, authorDto, cancellationToken);

        return Ok(result);
    }

    // DELETE api/<AuthorController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var result = await _authorService.DeleteByIdAsync(id, cancellationToken);

        return Ok(result);
    }
}
