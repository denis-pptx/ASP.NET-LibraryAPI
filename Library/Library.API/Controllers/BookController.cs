namespace Library.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookController(IBookService bookService) : ControllerBase
{
    private readonly IBookService _bookService = bookService;

    // POST api/<BookController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] BookDto bookDto)
    {
        var result = await _bookService.CreateAsync(bookDto);

        return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
    }

    // GET: api/<BookController>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _bookService.GetAsync();

        return Ok(result);
    }

    // GET api/<BookController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _bookService.GetByIdAsync(id);

        return Ok(result);
    }

    // PUT api/<BookController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] BookDto bookDto)
    {
        var result = await _bookService.UpdateAsync(id, bookDto);

        return Ok(result);
    }

    // DELETE api/<BookController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _bookService.DeleteByIdAsync(id);

        return Ok(result);
    }
}