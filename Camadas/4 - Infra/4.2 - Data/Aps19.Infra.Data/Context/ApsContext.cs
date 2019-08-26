using Aps19.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Aps19.Infra.Data.Context
{
    public class ApsConstext : DbContext
    {
        public ApsConstext() : base("ApiDDD") {

        }

        public DbSet<User> Usuarios { get; set; }
    }
}
