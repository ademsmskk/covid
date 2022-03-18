public class Account
{
    public int Id { get; set; }
    public int RoleId { get; set; }
    public string? Email { get; set; }
    public string Password { get; set; }
    public bool Visibility { get; set; }
    public Role? Role { get; set; }
    public virtual IEnumerable <User>? Users {get; set; }
}

