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

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<HistoriaC> HistoriaCs { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<TipoMascota> TipoMascotas { get; set; }
        public DbSet<TipoServicio> TipoServicios { get; set; }
    }
} 
