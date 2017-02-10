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
    [Table("Galerias")]
    class galeria
    {
        public int idgaleria { get; set; }

        public String fotografia { get; set; }

        //TODO: llave foranea para autos
    }
}
