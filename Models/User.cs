using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SqlClientBackend.Models
{
    public class User
    {
        [Required]
        public required string id { get; set; }
        public required string email { get; set; }

        [StringLength(50)]
        public string? username { get; set; }

        [Required]
        public required string password { get; set; }
        public DateTime? date_created { get; set; }

    }
}