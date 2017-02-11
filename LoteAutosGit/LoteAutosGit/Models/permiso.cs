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
        [Key]
        public int idpermiso { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del modulo")]
        public String modulo { get; set; }

        [StringLength(128)]
        public String descripcion { get; set; }

        public ICollection<permisonegado> permisosnegados { get; set; }
    }
}
