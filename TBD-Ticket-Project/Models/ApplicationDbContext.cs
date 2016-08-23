using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TBD_Ticket_Project.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<TBD_Ticket_Project.Models.Project> Projects { get; set; }

        public System.Data.Entity.DbSet<TBD_Ticket_Project.Models.Note> Notes { get; set; }

        public System.Data.Entity.DbSet<TBD_Ticket_Project.Models.Issue> Issues { get; set; }
    }
}