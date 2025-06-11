using App_produit.Models.Entities;
using Microsoft.EntityFrameworkCore; 

namespace App_produit.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Produit> Produits { get; set; }

    }
    
    
}
