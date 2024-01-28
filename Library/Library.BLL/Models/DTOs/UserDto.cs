namespace Library.BLL.Models.DTOs;

public class UserDto : EntityDto
{
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
