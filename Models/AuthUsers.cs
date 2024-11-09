using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TryndadeApi.Models 
{
    
    public class AuthUsers
    {   
        [Required]
        [MaxLength(50)]
        public required string Username {get;  set;}

        [Required]
        [MaxLength(255)]
        public required string Password {get;  set;}
    }
}