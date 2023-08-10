using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Person.Models
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //[BindProperty(Name = "hobby")]
        public string Hobbies { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
