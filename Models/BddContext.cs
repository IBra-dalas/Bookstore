using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewResto.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Louer> Louers { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
