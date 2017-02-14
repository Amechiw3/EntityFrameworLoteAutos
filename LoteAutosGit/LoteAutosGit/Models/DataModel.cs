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
    class DataModel : DbContext
    {
        public DataModel() : base("DataModel")  {   }

        public virtual DbSet<auto> autos { get; set; }
        public virtual DbSet<comprador> compradores { get; set; }
        public virtual DbSet<galeria> galerias  { get; set; }
        public virtual DbSet<nivel> niveles { get; set; }
        public virtual DbSet<pago> pagos { get; set; }
        public virtual DbSet<permiso> permisos { get; set; }
        public virtual DbSet<permisonegado> permisosnegados { get; set; }
        public virtual DbSet<propietario> propietarios { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<venta> ventas { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
