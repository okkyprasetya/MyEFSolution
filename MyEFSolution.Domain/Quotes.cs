namespace MyEFSolution.Domain
{
    public class Quotes
    {
        public int QuoteId { get; set; }
        public string? Text { get; set; }
        public int SamuraiId { get; set; }
        public Samurai? Samurai { get; set; }
    }
}
