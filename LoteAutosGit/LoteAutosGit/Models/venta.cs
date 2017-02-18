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
    [Table("Ventas")]
    public class venta
    {
        [Key]
        public int idventa { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la fecha de venta")]
        public DateTime fecha { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere status")]
        public Boolean status { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del auto")]
        public auto autos { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del comprador")]
        public comprador compradores { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del usuario")]
        public usuario usuarios { get; set; }

        
        public venta()
        {
            this.status = true;
        }
    }
}
