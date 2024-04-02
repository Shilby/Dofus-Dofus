namespace Dofus
{
    public class NewsDto
    {
        public int Id { get;  set; }
        public string Title { get; set; }
        public string Content { get; set; } // HTML content
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
    }
}
