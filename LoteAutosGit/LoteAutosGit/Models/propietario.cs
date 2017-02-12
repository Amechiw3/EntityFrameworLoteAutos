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
    [Table("Propietarios")]
    public class propietario
    {
        [Key]
        public int idpropietario { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del propietario")]
        public String nombre { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el apellido paterno del propietario")]
        public String appaterno { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el apellido materno del propietario")]
        public String apmaterno { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la calle del propietario")]
        public String calle { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la colonia del propietario")]
        public String colonia { get; set; }

        [StringLength(8)]
        [Required(ErrorMessage = "Se requiere el numero de casa del propietario")]
        public String ncasa { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la avenida del propietario")]
        public String avenida { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la ciudad del propietario")]
        public String ciudad { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el pais del propietario")]
        public String pais { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el telefono del propietario")]
        public String telefono { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "Se requiere el correo del propietario")]
        public String correo { get; set; }

        [StringLength(128)]
        [Required(ErrorMessage = "Se requiere el correo del propietario")]
        public String ine { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere una fotografia para el propietario")]
        public String fotografia { get; set; }
        
        public virtual ICollection<auto> autos { get; set; }

        public virtual ICollection<pago> pagos { get; set; }

    }
}
