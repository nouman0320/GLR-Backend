﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GLR_Backend_API_NET_CORE.Models
{
    public class UserInfo
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
