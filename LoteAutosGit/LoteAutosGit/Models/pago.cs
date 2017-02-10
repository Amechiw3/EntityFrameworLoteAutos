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
    class pago
    {
        public int idpago { get; set; }

        public DateTime fecha { get; set; }

        //TODO: Llave foranea hacia autos
        //TODO: Llave foranea hacia propietarios
    }
}
