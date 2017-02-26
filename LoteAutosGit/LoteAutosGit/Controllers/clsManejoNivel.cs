using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;


namespace LoteAutosGit.Controllers
{
    public class clsManejoNivel
    {
        public static nivel getNivel(int id)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.niveles.Where(r => r.idnivel == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
