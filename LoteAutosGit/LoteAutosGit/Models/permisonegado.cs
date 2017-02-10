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
    class permisonegado
    {
        public int idpermisonegadonivel { get; set; }

        public Boolean status { get; set; }
        
        //TODO: Llave Permisos

        //TODO: llave Nivel
    }
}
