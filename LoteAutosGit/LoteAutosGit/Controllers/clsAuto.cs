using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;

namespace LoteAutosGit.Controllers
{
    class clsAuto
    {
        public static List<auto> getAll()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.autos.Include("galerias").Include("pagos").Include("ventas").ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<auto> getAllSearch(string dato)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.autos.Include("propietarios").Where(r => r.marca.Contains(dato) || r.modelo.Contains(dato)).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<pago> getAllPago(int idauto)
        {
            try
            {
                var ctx = new DataModel();
                return
                ctx.pagos
                .Include("autos")
                .Include("autos.propietarios")
                .Where(r => r.autos.propietarios.idpropietario == idauto).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<auto> getAllPagoA(int idauto)
        {
            try
            {
                var ctx = new DataModel();
                return
                ctx.autos
                .Include("propietarios")
                .Where(r => r.propietarios.idpropietario == idauto).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<auto> SearchPagoA(int idauto, string auto)
        {
            try
            {
                var ctx = new DataModel();
                return
                ctx.autos
                .Include("propietarios")
                .Where(r => r.propietarios.idpropietario == idauto && r.marca.Contains(auto) || r.modelo.Contains(auto)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static pago searchPago(int idcarro)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.pagos.Where(r => r.autos.idauto == idcarro).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
