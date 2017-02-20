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

        public static List<comprador> searchName(string Ine)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.compradores.Where(r => r.nombre.Contains(Ine)).ToList();
            }
            catch (Exception exc)
            {
                throw;
            }
        }

        public static List<comprador> GetAllComprador()
        {
            try
            {

                var ctx = new DataModel();
                return (from r in ctx.compradores.ToList()
                        select new comprador
                        {
                            idcomprador = r.idcomprador,
                            nombre = $"{r.nombre} {r.appaterno} {r.apmaterno}"
                        }).ToList();

            }
            catch (Exception exc)
            {
                throw;
            }
        }

        public static comprador searchComprador(int idcomprador)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.compradores.Where(r => r.idcomprador == idcomprador).FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw;
            }
        }
    }
}
