using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoteAutosGit.Models;
using System.Data.Entity;
using LoteAutosGit.Models;

namespace LoteAutosGit.Controllers
{
    class clsComprador
    {
        public static comprador searchIne(string Ine)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.compradores.Where(r => r.Ine == Ine).FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw;
            }
        }
        public static void SaveComprador(comprador ine)
        {
            try
            {
                var ctx = new DataModel();
                //propietario datos = clsManejoPropietarios.returnPropietario(propietario);
                //ctx.propietarios.Attach(datos);
                //dauto.propietarios = datos;

                if (ine.idcomprador > 0) //Actualizar
                {
                    ctx.Entry(ine).State = EntityState.Modified;
                }
                else // Agregar
                {
                    ctx.Entry(ine).State = EntityState.Added;
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
