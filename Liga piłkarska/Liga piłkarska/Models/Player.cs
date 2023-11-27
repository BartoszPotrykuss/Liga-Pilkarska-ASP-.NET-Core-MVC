namespace Liga_piłkarska.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Team Team { get; set; }
    }
}
