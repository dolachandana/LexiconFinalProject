namespace LexiconFinalProject.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Synopsis { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Music { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string RunTime { get; set; }
       public int ActorId { get; set; }
        public Actor? Actor  { get; set; }
        public int OpinionId { get; set; }
        public Opinion? Opinion { get; set; }
    }
}
