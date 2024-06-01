namespace Domain.Entities
{
  public class UserRole : BaseEntity<Ulid>
  {
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required ICollection<User> Users { get; set; }
  }
}
