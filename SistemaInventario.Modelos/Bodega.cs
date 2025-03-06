using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60, ErrorMessage = "El Nombre debe ser con un máximo de 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Descripción es Requerido")]
        [MaxLength(100, ErrorMessage = "La Descripción No debe tener más de 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es requerdio")]
        public bool Estado { get; set; }
    }
}
