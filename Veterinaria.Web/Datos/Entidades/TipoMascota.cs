using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace Veterinaria.Web.Datos.Entidades
{
    public class TipoMascota 
    {
        public int Id { get; set; }

        [Display (Name = "Tipo de Mascota")]
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        public  ICollection<Mascota> Mascotas{ get; set; }
    }


}