using System.ComponentModel.DataAnnotations;

namespace API.WMovies.DAL.Models
{
    public class Category:AuditBase
    {
        internal DateTime UpdatedDate;

        [Required]
        public string Name { get; set; }
    }
}
