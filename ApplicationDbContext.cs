using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Eveniment> Evenimente { get; set; }
    public DbSet<Participant> Participanti { get; set; }
    public DbSet<ParticipaEveniment> ParticipaEveniment { get; set; }
}