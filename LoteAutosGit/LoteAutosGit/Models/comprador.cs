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
    [Table("Compradores")]
    public class comprador
    {
        [Key]
        public int idcomprador { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el nombre del comprador")]
        public String nombre { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el apellido paterno del comprador")]
        public String appaterno { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el apellido materno del comprador")]
        public String apmaterno { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere número identificador")]
        public String Ine { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la calle del comprador")]
        public String calle { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la colonia del comprador")]
        public String colonia { get; set; }

        [StringLength(8)]
        [Required(ErrorMessage = "Se requiere el numero de casa del comprador")]
        public String ncasa { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la avenida del comprador")]
        public String avenida { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere la ciudad del comprador")]
        public String ciudad { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere el pais del comprador")]
        public String pais { get; set; }
        
        public virtual ICollection<venta> ventas { get; set; }
    }
}
