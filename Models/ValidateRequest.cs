using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class ValidateRequest
    {
        [Required]
        public string jwtToken { get; set; }
    }
}
