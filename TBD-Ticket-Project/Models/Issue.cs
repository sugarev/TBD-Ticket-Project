using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TBD_Ticket_Project.Models
{
    public class Issue
    {
        public Issue()
        {
            this.Date = DateTime.Now; 
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [Required]  
        public DateTime Date { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        [Required]
        public string Priority { get; set; }

        public ApplicationUser Author { get; set; }

        public ApplicationUser Assignee { get; set; }
    }
}