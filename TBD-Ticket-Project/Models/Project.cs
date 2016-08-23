using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TBD_Ticket_Project.Models
{
    public class Project
    {
        public Project()
        {
            this.Date = DateTime.Now; 
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]  
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }


    }
}