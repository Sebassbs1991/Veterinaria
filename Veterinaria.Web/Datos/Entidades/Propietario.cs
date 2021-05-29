using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Veterinaria.Web.Datos.Entidades
{
    public class Propietario 
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Documento{ get; set; }

        [Required]
        [MaxLength (50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength (50)]
        public string Apellido { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(20)]
        public string Celular { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }

        [Display(Name ="Owner")]
        public string NombreCompleto => $"{Nombre} {Apellido}";

        public ICollection<Mascota> Mascotas { get; set; }

        public ICollection<Agenda> Agendas { get; set; }








    }
}