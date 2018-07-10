using System;
using System.ComponentModel.DataAnnotations;

namespace dotnetapi.Models{
    public class Test{
        public int id { get; set; }

        [Required]
        public string text { get; set; }
    }
}