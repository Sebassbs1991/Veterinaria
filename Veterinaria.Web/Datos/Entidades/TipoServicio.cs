using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace Veterinaria.Web.Datos.Entidades
{
    public class TipoServicio 
    {
        public int Id { get; set; }

        [Display(Name = "Tipo de Servicio")]
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }

        public ICollection<HistoriaC> HistoriaCs { get; set; }

    }
}