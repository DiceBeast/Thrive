﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolAPI.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject { get; set; }

        [NotMapped]
        public List<Class>  Classes { get; set; }
    }
}