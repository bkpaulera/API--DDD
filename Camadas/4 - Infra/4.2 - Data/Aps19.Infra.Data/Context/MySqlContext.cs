﻿using Aps19.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Aps19.Infra.Data.Context
{
    public class MySqlContext : DbContext

    {
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

                optionsBuilder.UseMySql("Server=[SERVIDOR];Port=[PORTA];Database=modelo;Uid=[USUARIO];Pwd=[SENHA]");

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Usuario>(new UserMap().Configure);

        }

    }
}
