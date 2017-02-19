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

    class clsPago
    {
        public static void savePago(int idauto, int idprop)
        {
            try
            {
                var ctx = new DataModel();
                pago pg = new pago();

                auto au = ctx.autos.Where(r => r.idauto == idauto).FirstOrDefault();
                ctx.autos.Attach(au);
                pg.autos = au;

                propietario pr = ctx.propietarios.Where(r => r.idpropietario == idprop).FirstOrDefault();
                ctx.propietarios.Attach(pr);
                pg.propietarios = pr;

                pg.fecha = DateTime.Now;
                ctx.Entry(pg).State = EntityState.Added;
                ctx.SaveChanges();

                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
