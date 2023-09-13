public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Avatar { get; set; } = default!;
    public string Bio { get; set; } = default!;
    public DateTime BirthDate { get; set; }
    public IEnumerable<Note> Notes { get; set; } = new List<Note>();
}
