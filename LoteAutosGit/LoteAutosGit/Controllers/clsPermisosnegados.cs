using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;

namespace LoteAutosGit.Controllers
{
    public class clsPermisosnegados
    {

        public static void savePermisos(permisonegado datos, int idnivel, int idpermiso)
        {
            try
            {
                var ctx = new DataModel();

                nivel nvl = ctx.niveles.Where(r => r.idnivel == idnivel).FirstOrDefault();
                ctx.niveles.Attach(nvl);
                datos.niveles = nvl;

                permiso perm = ctx.permisos.Where(r => r.idpermiso == idpermiso).FirstOrDefault();
                ctx.permisos.Attach(perm);
                datos.permisos = perm;

                if (datos.idpermisonegadonivel > 0) //Realiza una actualizacion
                {
                    ctx.Entry(datos).State = EntityState.Modified;
                }
                else
                {    // Agregar
                    ctx.Entry(datos).State = EntityState.Added;
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int id { get; set; }
        public string permiso { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        public static List<clsPermisosnegados> GetAllPermisosNegados(int idnivel)
        {
            try
            {
                var ctx = new DataModel();
                //return ctx.permisosnegados.Where(r => r.niveles.idnivel == idnivel && r.status == true).ToList();
                return (from r in ctx.permisosnegados.Include("niveles").Where(r => r.niveles.idnivel == idnivel && r.status == true).ToList()
                        select new clsPermisosnegados
                        {
                            id = r.idpermisonegadonivel,
                            permiso = r.permisos.modulo,
                            descripcion = r.permisos.descripcion,
                            estado = r.status
                        }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
