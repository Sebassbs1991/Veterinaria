using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Veterinaria.Web.Datos.Entidades;

namespace Veterinaria.Web.Datos
{
    public class ContextoDatos : DbContext
    {
        public ContextoDatos(DbContextOptions<ContextoDatos> options) : base(options)
        {

        }

        public DbSet<Propietario> Propietarios { get; set; }
    }
} 
