using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;

namespace LoteAutosGit.Controllers
{
    public class ClsManejoSession
    {
        public static SessionHelper Login(string User, string Password)
        {
            SessionHelper objSession = new SessionHelper();
            try
            {
                using (var ctx = new DataModel())
                {
                    usuario user = ctx.usuarios.Include("niveles").Include("niveles.permisosnegados").Where(r => r.nickname == User && r.status == true).FirstOrDefault();
                    if (user!=null)
                    {
                        if (user.password == Password)
                        {
                            objSession.isValid = true;
                            objSession.usuario = user;
                        }
                    }
                }
                return objSession;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public class SessionHelper
        {
            public Boolean isValid { get; set; }
            public usuario usuario { get; set; }
            public String msgError { get; set; }

            public SessionHelper()
            {
                this.isValid = false;
                this.usuario = null;
                this.msgError = "Datos incorrectos, Favor de verificar";
            }

            public Boolean TienePermisos(int ValidarPermiso)
            {
                Boolean tiene = false;
                if (isValid)
                {
                    try
                    {
                        var ctx = new DataModel();
                        //permisonegado pNegado = usuario.niveles.permisosnegados.Where(r => r.permisos.idpermiso == ValidarPermiso).FirstOrDefault();
                        permisonegado pNegados = ctx.permisosnegados.Where(r => r.permisos.idpermiso == ValidarPermiso && r.niveles.idnivel == this.usuario.niveles.idnivel && r.status == true).FirstOrDefault();
                        if (pNegados == null)
                        {
                            tiene = true;
                        }
                        return tiene;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else { return tiene; }
            }
        }
    }

    public enum enumPermisosActivos
    {
        //administrador
        ventas_add = 1,
        propietarios_add = 2,
        autos_add = 3,
        comprador_add = 4,

        ventas_upd = 5,
        propietarios_upd = 6,
        autos_upd = 7,
        comprador_upd = 8,

        ventas_del = 9,
        propietarios_del = 10,
        autos_del = 11,
        comprador_del = 12,

        usuarios_add = 13,
        usuarios_upd = 14,
        usuarios_del = 15
        //Vendedor


        //Gerente




    }
}
