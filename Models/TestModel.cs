using System;
using System.ComponentModel.DataAnnotations;
using RESTAPI;

namespace dotnetapi.Models {
    public class Test : RESTAPI.BaseModel
    {
        public int id { get; set; }
        
        
        public Test(){
            this.contextString = "MySqlEFDBContext";
        }
        

        // [Required]
        // public string text { get; set; }
    }
}