﻿namespace Library.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class AuthorController(IAuthorService authorService) : ControllerBase
{
    private readonly IAuthorService _authorService = authorService;

    // POST api/<AuthorController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AuthorDto authorDto)
    {
        var result = await _authorService.CreateAsync(authorDto);

        return CreatedAtAction(nameof(Post), new { id = result.Id }, result);
    }

    // GET: api/<AuthorController>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _authorService.GetAsync();

        return Ok(result);
    }

    // GET api/<AuthorController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _authorService.GetByIdAsync(id);

        return Ok(result);
    }

    // PUT api/<AuthorController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] AuthorDto authorDto)
    {
        var result = await _authorService.UpdateAsync(id, authorDto);

        return Ok(result);
    }

    // DELETE api/<AuthorController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _authorService.DeleteByIdAsync(id);

        return Ok(result);
    }
}
