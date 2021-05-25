using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace Veterinaria.Web.Datos.Entidades
{
    public class Mascota 
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }

        [MaxLength(50)]
        public string Raza { get; set; }

        [Display(Name = "Fecha Nacimiento")]
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:yyyy:MM:dd}", ApplyFormatInEditMode =true)]
        public DateTime Nacimiento { get; set; }

        
        [MaxLength(200)]
        public string Comentarios { get; set; }


        // Reemplaza el Url Correto para la imagen
        public string RutaImagen => string.IsNullOrEmpty(UrlImagen)
            ? null
            : $"https//TBD.azurewebsites.net{UrlImagen.Substring(1)}";


        [Display (Name = "Nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy:MM:dd}"]
        public DateTime NacimientoLocal => Nacimiento.ToLocalTime();










    }
}