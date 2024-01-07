using System.ComponentModel.DataAnnotations;
using eTicket.Models.Bases;

namespace eTicket.Models
{
    public class Actor : Person
    {
        [Key]
        public int Id { get; set; }
        
    }
}
