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
    public class galeria
    {
        [Key]
        public int idgaleria { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Se requiere alguna fotografia")]
        public String fotografia { get; set; }

        public Boolean status { get; set; }
        
        public auto autos { get; set; }

        public galeria()
        {
            this.status = true;
        }
    }
}
