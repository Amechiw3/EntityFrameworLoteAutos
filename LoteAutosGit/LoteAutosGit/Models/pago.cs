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
    [Table("Pagos")]
    public class pago
    {
        [Key]
        public int idpago { get; set; }

        [Required(ErrorMessage = "Se requiere la fecha de pago")]
        public DateTime fecha { get; set; }

        public Boolean status { get; set; }
        
        public auto autos { get; set; }

        public propietario propietarios { get; set; }

        public pago()
        {
            this.status = true;
        }
    }
}
