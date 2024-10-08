public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public string? Title { get; set; }
    public DateTime? PublicationDate { get; set; }
    public string? Content { get; set; }
    public User? User { get; set; }
    public Category? Category { get; set; }
    public List<Tag> Tags { get; set; }
}