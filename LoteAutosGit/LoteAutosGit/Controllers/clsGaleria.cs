using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;

namespace LoteAutosGit.Controllers
{
    class clsGaleria
    {
        public static void saveGaleria(galeria datos, int Idauto)
        {
            try
            {
                var ctx = new DataModel();
                auto auto = ctx.autos.Where(r => r.idauto == Idauto).FirstOrDefault();
                ctx.autos.Attach(auto);
                datos.autos = auto;
                ctx.Entry(datos).State = EntityState.Added;
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        } 
    }
}
