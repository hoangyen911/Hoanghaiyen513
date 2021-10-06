using System;
using System.ComponentModel.DataAnnotations;

namespace Hoanghaiyen513.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonGender {get;set;}
        
    }
}