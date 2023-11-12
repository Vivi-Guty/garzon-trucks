﻿using System.ComponentModel.DataAnnotations;

namespace GarzonTrucksApi.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string LoginName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
