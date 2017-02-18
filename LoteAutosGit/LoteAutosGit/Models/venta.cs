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
        
        [Required(ErrorMessage = "Se requiere la fecha de venta")]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "Se requiere status")]
        public Boolean status { get; set; }
        
        public auto autos { get; set; }
        
        public comprador compradores { get; set; }
        
        public usuario usuarios { get; set; }
        
        public venta()
        {
            this.status = true;
        }
    }
}
