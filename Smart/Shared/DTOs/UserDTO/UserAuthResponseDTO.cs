﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.Shared.DTOs.UserDTO
{
    public class UserAuthResponseDTO
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
