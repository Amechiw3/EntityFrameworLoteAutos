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
        public static List<auto> getall()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.autos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
