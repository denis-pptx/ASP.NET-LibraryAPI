using FluentValidation;
using Library.API.Models;
using Library.BLL.Models.DTO;
using Library.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;
    private Response _response;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
        _response = new Response();
    }

    // POST api/<AuthorController>
    [HttpPost]
    public async Task<object> Post([FromBody] AuthorDto authorDto)
    {
        _response.Result = await _authorService.CreateAuthorAsync(authorDto);
        return _response;
    }

    // GET: api/<AuthorController>
    [HttpGet]
    public async Task<object> Get()
    {
        _response.Result = await _authorService.GetAuthorsAsync();
        return _response;
    }

    //// GET api/<AuthorController>/5
    //[HttpGet("{id}")]
    //public string Get(int id)
    //{
    //    return "value";
    //}

    //// POST api/<AuthorController>
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT api/<AuthorController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<AuthorController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}
