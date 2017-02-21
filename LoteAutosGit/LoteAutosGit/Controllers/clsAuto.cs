using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;
using System.Drawing;
using System.IO;

namespace LoteAutosGit.Controllers
{
    class clsAuto
    {
        public static List<auto> getAll()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.autos.ToList();
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

        public int idauto { get; set; }
        public Image fotografia { get; set; }

        public static List<clsAuto> getfoto(int auto)
        {
            try
            {
                var ctx = new DataModel();
                return (from r in ctx.galerias.Where(t => t.autos.idauto == auto).ToList()
                        select new clsAuto
                        {
                            idauto = r.idgaleria,
                            fotografia = Image.FromFile(Directory.GetCurrentDirectory() + @"\Propietario\" + r.fotografia)
                        }).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
