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
    [Table("Niveles")]
    class nivel
    {
        public int idnivel { get; set; }

        public String nombre { get; set; }

        public Boolean status { get; set; }

        public String descripcion { get; set; }

        //Llave de usuario
    }
}
