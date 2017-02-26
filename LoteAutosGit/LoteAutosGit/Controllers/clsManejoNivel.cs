using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using LoteAutosGit.Models;
using System.Data.Entity;

namespace LoteAutosGit.Controllers
{
    public class clsManejoNivel
    {
        public static nivel getNivel(int id)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.niveles.Where(r => r.idnivel == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<nivel> getNivelAll()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.niveles.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<permiso> getPermisosAll()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.permisos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void saveNivel(nivel datosnivel)
        {
            try
            {
                var ctx = new DataModel();
                if (datosnivel.idnivel > 0)
                {
                    ctx.Entry(datosnivel).State = EntityState.Modified;
                }
                else
                {
                    ctx.Entry(datosnivel).State = EntityState.Added;
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
