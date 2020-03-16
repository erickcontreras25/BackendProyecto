using Microsoft.EntityFrameworkCore;
using Reserva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reserva
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions opciones) : base(opciones)
        {

        }

        public virtual DbSet<Complejo> Complejo { get; set; }
        public virtual DbSet<Cancha> Cancha { get; set; }


        protected override void OnModelCreating(ModelBuilder modelB)
        {
            new Complejo.Map(modelB.Entity<Complejo>());
            new Cancha.Map(modelB.Entity<Cancha>());
            base.OnModelCreating(modelB);
        }


    }
}
