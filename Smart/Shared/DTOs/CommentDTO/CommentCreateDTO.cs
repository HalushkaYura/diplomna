﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.Shared.DTOs.CommentDTO
{
    public class CommentCreateDTO
    {
        public int TaskId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
    }
}