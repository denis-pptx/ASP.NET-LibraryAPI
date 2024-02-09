namespace Library.API.Controllers;

[Route("api")]
[ApiController]
public class AuthController : Controller
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

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

        var token = _userService.CreateToken(user);

        return Ok(token);
    }
}
