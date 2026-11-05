using Microsoft.EntityFrameworkCore;
using MYAcademy_PortfolioProject.Entities;

namespace MYAcademy_PortfolioProject.Context
{
    public class PortfolioContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Desktop-SF14T; Database=PortfolioDb;Integrated Security=True; TrustServerCertificate=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }


    }
}
