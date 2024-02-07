namespace Library.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class BookController(IBookService bookService) : ControllerBase
{
    private readonly IBookService _bookService = bookService;

    // POST api/<BookController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] BookDto bookDto, CancellationToken cancellationToken)
    {
        var result = await _bookService.CreateAsync(bookDto, cancellationToken);

        return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    // GET: api/<BookController>
    [HttpGet]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        var result = await _bookService.GetAsync(cancellationToken);

        return Ok(result);
    }

    // GET api/<BookController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
    {
        var result = await _bookService.GetByIdAsync(id, cancellationToken);

        return Ok(result);
    }

    // GET api/<BookController>/isbn/1234567890
    [HttpGet("isbn/{isbn}")]
    public async Task<IActionResult> Get(string isbn, CancellationToken cancellationToken)
    {
        var result = await _bookService.GetByIsbnAsync(isbn, cancellationToken);

        return Ok(result);
    }

    // PUT api/<BookController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] BookDto bookDto, CancellationToken cancellationToken)
    {
        var result = await _bookService.UpdateAsync(id, bookDto, cancellationToken);

        return Ok(result);
    }

    // DELETE api/<BookController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        var result = await _bookService.DeleteByIdAsync(id, cancellationToken);

        return Ok(result);
    }
}