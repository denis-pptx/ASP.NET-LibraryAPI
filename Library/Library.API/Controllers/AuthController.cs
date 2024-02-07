using Library.API.Options;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Library.API.Controllers;

[Route("api")]
[ApiController]
public class AuthController(IUserService userService, IOptions<AuthOptions> options) 
    : Controller
{
    private readonly IUserService _userService = userService;
    private readonly AuthOptions _authOptions = options.Value;

    // POST api/<AuthController>/register
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto, CancellationToken cancellationToken)
    {
        var userDto = new UserDto()
        {
            Login = registerDto.Login,
            Password = BCrypt.Net.BCrypt.HashPassword(registerDto.Password)
        };

        await _userService.CreateAsync(userDto, cancellationToken);

        return Ok();
    }

    // POST api/<AuthController>/login
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto, CancellationToken cancellationToken)
    {
        var user = await _userService.GetByLoginAsync(loginDto.Login, cancellationToken);

        if (!BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
        {
            return BadRequest("Invalid login or password");
        }

        return Ok(CreateToken(user));
    }

    private string CreateToken(User user)
    {
        List<Claim> claims = new List<Claim> { new Claim(ClaimTypes.Name, user.Login) };

        var jwt = new JwtSecurityToken(
            issuer: _authOptions.Issuer,
            audience: _authOptions.Audience,
            claims: claims,
            expires: DateTime.UtcNow.Add(TimeSpan.FromHours(1)),
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authOptions.SecretKey)), 
                SecurityAlgorithms.HmacSha256)
            );
        
        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }
}
