namespace Library.DAL.Entities;

public class User : Entity
{
    public string Login { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
}
