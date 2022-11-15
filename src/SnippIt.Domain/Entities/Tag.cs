namespace SnippIt.Domain.Entities;

public class Tag
{
    public Guid ParentId { get; set; }
    public Tag Parent { get; set; }
    public List<Tag> Children { get; set; }
}