using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  USING  */
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LoteAutosGit.Models
{
    [Table("Autos")]
    public class auto
    {
        [Key]
        public int idauto { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la marca del auto")]
        public String marca { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el modelo del auto")]
        public String modelo { get; set; }

        [StringLength(32)]
        [Required(ErrorMessage = "Se requiere el modelo del auto")]
        public String nserie { get; set; }
        
        [Required(ErrorMessage = "Se requiere el precio del auto")]
        public Double precio { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere conocer el color del auto")]
        public String color { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la nacionalidad del auto")]
        public String nacionalidad { get; set; }

        [StringLength(64)]
        public String Observacion { get; set; }

        public propietario propietarios { get; set; }

        public virtual ICollection<galeria> galerias { get; set; }

        public virtual ICollection<pago> pagos { get; set; }

        public virtual ICollection<venta> ventas { get; set; }


    }
}
