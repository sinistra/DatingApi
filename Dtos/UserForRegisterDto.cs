using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApi.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }
        
        [Required]
        
        public string KnownAs { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            CreatedAt = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}