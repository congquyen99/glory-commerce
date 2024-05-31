namespace Domain.Entities
{
  public class User : BaseEntity<Ulid>
  {
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public string? Phone { get; set; }
  }
}
