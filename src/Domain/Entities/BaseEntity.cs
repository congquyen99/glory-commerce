namespace Domain.Entities
{
  public abstract class BaseEntity : BaseEntity<Ulid> { }

  public abstract class BaseEntity<T>
  {
    public required virtual T Id { get; set; }

    public bool Deleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public virtual DateTime? UpdatedDate { get; set; }
  }
}
