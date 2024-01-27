using FluentValidation;
using Library.BLL.Models.DTOs;
using Library.BLL.Services.Interfaces;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController(IAuthorService authorService) : ControllerBase
{
    private readonly IAuthorService _authorService = authorService;

    // POST api/<AuthorController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] AuthorDto authorDto)
    {
        var result = await _authorService.CreateAuthorAsync(authorDto);

        return CreatedAtAction(nameof(Post), new { id = result.Id }, result);
    }

    // GET: api/<AuthorController>
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _authorService.GetAuthorsAsync();

        return Ok(result);
    }

    // GET api/<AuthorController>/5
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _authorService.GetAuthorByIdAsync(id);

        return Ok(result);
    }

    // PUT api/<AuthorController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] AuthorDto authorDto)
    {
        var result = await _authorService.UpdateAuthorAsync(id, authorDto);

        return Ok(result);
    }

    // DELETE api/<AuthorController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _authorService.DeleteAuthorByIdAsync(id);

        return Ok(result);
    }
}
