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
    [Table("PermisosNegados")]
    public class permisonegado
    {
        [Key]
        public int idpermisonegadonivel { get; set; }
        
        public Boolean status { get; set; }
        
        public virtual permiso permisos { get; set; }

        public virtual nivel niveles { get; set; }

        public permisonegado()
        {
            this.status = true;
        }
    }
}
