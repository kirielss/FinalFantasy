namespace FinalFantasy.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
        public string? Description { get; set; }
    }
}
