using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Veterinaria.Web.Datos.Entidades
{
    public class Agenda 
    {
        public int Id { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [MaxLength(200)]
        public string Comentarios { get; set; }


        [Display (Name ="Está Disponible?")]
        public bool EstaDisponible { get; set; }


        
        [Display(Name= "Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}")]
        public DateTime FechaLocal => Fecha.ToLocalTime();

        public Propietario Propietario { get; set; }

        public Mascota Mascota { get; set; }







    }
}