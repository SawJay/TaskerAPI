using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using TaskerAPI.Models;

namespace TaskerAPI.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        IdentityDbContext<IdentityUser>(options)
    {
        public DbSet<TaskerItem> TaskerItems { get; set; }
    }
}
