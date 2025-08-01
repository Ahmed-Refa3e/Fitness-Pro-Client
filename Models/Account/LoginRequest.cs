﻿using System.ComponentModel.DataAnnotations;

namespace Fitness_Pro_Client.Models.Account
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
