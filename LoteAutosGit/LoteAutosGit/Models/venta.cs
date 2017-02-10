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
        public int idventa { get; set; }

        public DateTime fecha { get; set; }

        //TODO: Llave foranea de autos
        //TODO: Llave foranea de comprador
        //TODO: Llave foranea de usuario
    }
}
