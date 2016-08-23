using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TBD_Ticket_Project.Models
{
    public class Note
    {
        public Note()
        {
            this.Date = DateTime.Now; 
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int IssueId { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [Required]  
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }
    }
}