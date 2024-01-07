using System.ComponentModel.DataAnnotations;
using eTicket.Models.Bases;

namespace eTicket.Models
{
    public class Producer : Person
    {
        [Key]
        public int Id { get; set; }

    }
}
