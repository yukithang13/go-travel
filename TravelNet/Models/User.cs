﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelNet.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }


        public string UserName { get; set; }


        public string Password { get; set; }


        public string Email { get; set; }
    }

    public class Jwt
    {
        public string key { get; set; }
        public string Issuser { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }
    }
}