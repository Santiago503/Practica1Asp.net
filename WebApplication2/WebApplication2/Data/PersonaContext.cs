using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class PersonaContext : DbContext
    {
        public PersonaContext (DbContextOptions<PersonaContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication2.Models.Persona> Persona { get; set; }
    }
}
