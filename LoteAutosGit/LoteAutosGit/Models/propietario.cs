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
    class propietario
    {
        public int idpropietario { get; set; }

        public String nombre { get; set; }

        public String appaterno { get; set; }

        public String apmaterno { get; set; }

        public String calle { get; set; }

        public String colonia { get; set; }

        public String ncasa { get; set; }

        public String avenida { get; set; }

        public String ciudad { get; set; }

        public String pais { get; set; }

        public String telefono { get; set; }

        public String correo { get; set; }

        public String ine { get; set; }

        public String fotografia { get; set; }

        //TODO: Llave foranea de autos:propietarios
    }
}
