﻿using System.ComponentModel.DataAnnotations;

namespace FIAP_MVC_PZ.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        [Compare("UserPassword", ErrorMessage = "As Senhas não são iguais!!")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string UserPhone { get; set; } = string.Empty;
    }
}
