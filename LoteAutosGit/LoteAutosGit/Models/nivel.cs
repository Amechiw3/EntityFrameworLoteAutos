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
    public class nivel
    {
        [Key]
        public int idnivel { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del nivel")]
        public String nombre { get; set; }
        
        public Boolean status { get; set; }

        [StringLength(128)]
        public String descripcion { get; set; }

        public virtual ICollection<usuario> usuarios { get; set; }

        public virtual ICollection<permisonegado> permisosnegados { get; set; }

        public nivel()
        {
            this.status = true;
        }
    }
}
