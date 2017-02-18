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
                        using (var ctx = new DataModel())
                        {
                            permisonegado pNegado = usuario.niveles.permisosnegados.Where(r => r.permisos.idpermiso == ValidarPermiso).FirstOrDefault();
                            if (pNegado == null)
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
        //Vendedor
        Venta_Nueva = 1,

       //Gerente

        ventita = 1,
        propieta = 2,
        aut = 3,
        reg = 4,


        //administrador
        venta = 1,
        propietarios = 2,
        autos = 3,
        registro = 4,

    }
}
