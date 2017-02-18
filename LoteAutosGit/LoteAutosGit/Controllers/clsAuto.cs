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
                return ctx.autos.Where(r => r.marca.Contains(dato) || r.modelo.Contains(dato)).ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
