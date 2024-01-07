using System.ComponentModel.DataAnnotations;
using eTicket.Models.Bases;

namespace eTicket.Models
{
    public class Actor : Person
    {
        [Key]
        public int Id { get; set; }

        public List<Actor_Movie> Actors_Movie { get; set; }

    }
}
