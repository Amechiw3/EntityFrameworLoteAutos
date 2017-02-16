using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;

namespace LoteAutosGit.Controllers
{
    class clsManejoAutos
    {

        public static auto searchNSerie(string NSerie)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.autos.Where(r => r.nserie == NSerie).FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw;
            }
        }

        public static void SaveAuto(auto dauto)
        {
            try
            {
                var ctx = new DataModel();
                //propietario datos = clsManejoPropietarios.returnPropietario(propietario);
                //ctx.propietarios.Attach(datos);
                //dauto.propietarios = datos;
                
                if (dauto.idauto > 0) //Actualizar
                {
                    ctx.Entry(dauto).State = EntityState.Modified;
                }
                else // Agregar
                {
                    ctx.Entry(dauto).State = EntityState.Added;
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
