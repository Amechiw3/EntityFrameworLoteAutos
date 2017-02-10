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
    [Table("Permisos")]
    public class permiso
    {
        public int idpermiso { get; set; }

        public String modulo { get; set; }

        public String descripcion { get; set; }
    }
}
