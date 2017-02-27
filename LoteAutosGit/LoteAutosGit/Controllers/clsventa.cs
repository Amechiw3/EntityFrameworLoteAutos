using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoteAutosGit.Controllers
{
    class clsventa
    {
        public static void Venta(int idAuto, int usuario, int comprador, venta Venta)
        {
            try
            {
                var ctx = new DataModel();
                auto aut = ctx.autos.Where(r => r.idauto == idAuto).FirstOrDefault();
                ctx.autos.Attach(aut);
                Venta.autos = aut;

                usuario usu = ctx.usuarios.Where(r => r.idusuario == usuario).FirstOrDefault();
                ctx.usuarios.Attach(usu);
                Venta.usuarios = usu;

                comprador com = ctx.compradores.Where(r => r.idcomprador == idAuto).FirstOrDefault();
                ctx.compradores.Attach(com);
                Venta.compradores = com;

                ctx.Entry(Venta).State = EntityState.Added;
                ctx.SaveChanges();

            }
            catch (Exception ex)
            {
            }
        }

        public List<auto> getallAuto()
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

        public List<usuario> getallUsuario()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.usuarios.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<comprador> getallComprador()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.compradores.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public int idventa { get; set; }
        public string fecha { get; set; }
        public string nombreempleado { get; set; }
        public string auto { get; set; }
        public string cliente { get; set; }

        public static List<clsventa> getallventaGr()
        {
            try
            {
                var ctx = new DataModel();
                return (from r in ctx.ventas.Include("autos").Include("compradores").Include("usuarios").ToList()
                        select new clsventa
                        {
                            idventa = r.idventa,
                            fecha = r.fecha.ToShortDateString(),
                            nombreempleado = $"{r.usuarios.nombre} {r.usuarios.appaterno} {r.usuarios.apmaterno}",
                            auto = $"{r.autos.modelo} {r.autos.nserie}",
                            cliente = $"{r.compradores.nombre} {r.compradores.appaterno} {r.compradores.apmaterno}"
                        }).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}

