using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace Veterinaria.Web.Datos.Entidades
{
    public class HistoriaC
    {
        public int Id { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(100)]
        [Required]
        public string Descripcion { get; set; }

        [Display(Name ="Fecha")]
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode =true)]
        public  DateTime Date { get; set; }

        [MaxLength(200)]
        [Required]
        public string Comentarios { get; set; }

        [Display(Name ="Fecha")]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}", ApplyFormatInEditMode =true)]
        public DateTime FechaLocal => Date.ToLocalTime(); // Garantiza que muestre la hora correcta de cada localidad

        public TipoServicio TipoServicio { get; set; }

        public Mascota Mascota { get; set; }



    }
}