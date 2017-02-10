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
    [Table("Autos")]
    public class auto
    {
        public int idauto { get; set; }

        public String marca { get; set; }

        public String modelo { get; set; }

        public String nserie { get; set; }

        public Double precio { get; set; }

        public String color { get; set; }

        public String nacionalidad { get; set; }

        public String Observacion { get; set; }

        //TODO: Llave Foranea para propietario
    }
}
