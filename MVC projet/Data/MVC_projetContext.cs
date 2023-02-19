using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_projet.Models;

namespace MVC_projet.Data
{
    public class MVC_projetContext : DbContext
    {
        public MVC_projetContext (DbContextOptions<MVC_projetContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_projet.Models.Panier> Panier { get; set; } = default!;

        public DbSet<MVC_projet.Models.Produit> Produit { get; set; }

        public DbSet<MVC_projet.Models.LignePanier> LignePanier { get; set; }
    }
}
