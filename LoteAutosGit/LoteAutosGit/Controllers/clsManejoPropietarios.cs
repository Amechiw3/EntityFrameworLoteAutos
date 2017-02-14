using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;

namespace LoteAutosGit.Controllers
{
    class clsManejoPropietarios
    {
        public static propietario searchINE(string INE)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.propietarios.Where(r => r.ine == INE).FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw;
            }
        }

        public static void SavePropietario(propietario propietario)
        {
            try
            {
                var ctx = new DataModel();
                if (propietario.idpropietario > 0) //Actualizar
                {
                    ctx.Entry(propietario).State = EntityState.Modified;
                }
                else // Agregar
                {
                    ctx.Entry(propietario).State = EntityState.Added;
                }
                ctx.SaveChanges();

            }
            catch (Exception exc)
            {

                throw;
            }
        }
    }
}
