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
    [Table("Usuarios")]
    public class usuario
    {
        [Key]
        public int idusuario { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del usuario")]
        public String nombre { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el apellido paterno del usuario")]
        public String appaterno { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el apellido materno del usuario")]
        public String apmaterno { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la calle del usuario")]
        public String calle { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la colonia del usuario")]
        public String colonia { get; set; }

        [StringLength(8)]
        [Required(ErrorMessage = "Se requiere el numero de casa del usuario")]
        public String ncasa { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la avenida del usuario")]
        public String avenida { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la ciudad del usuario")]
        public String ciudad { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el pais del usuario")]
        public String pais { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el correo del usuario")]
        public String email { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nickname del usuario")]
        public String nickname { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la contraseña del usuario")]
        public String password { get; set; }

        public virtual ICollection<venta> ventas { get; set; }

        public virtual nivel niveles { get; set; }
    }
}
