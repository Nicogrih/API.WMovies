using System.ComponentModel.DataAnnotations;

namespace API.WMovies.DAL.Models
{
    public class Category:AuditBase
    {
        [Required]
        public string Name { get; set; }
    }
}
