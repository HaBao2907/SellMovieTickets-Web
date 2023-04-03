namespace eTickets.Models
{
    public class Actors_Movies
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int Id { get; set; }  
        public Actor Actor { get; set; }
    }
}
