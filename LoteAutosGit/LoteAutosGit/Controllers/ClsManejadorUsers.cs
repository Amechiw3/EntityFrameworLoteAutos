﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LoteAutosGit.Models;
using System.Data.Entity;

namespace LoteAutosGit.Controllers
{
    public class ClsManejadorUsers
    {
        public static List<usuario> getAll()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.status == true).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void SaveUsers(usuario nUser, int idnivel)
        {
            try
            {
                var ctx = new DataModel();
                nivel nvl = ctx.niveles.Where(r => r.idnivel == idnivel).FirstOrDefault();
                ctx.niveles.Attach(nvl);
                nUser.niveles = nvl;

                if (nUser.idusuario > 0) //Realiza una actualizacion
                {
                    ctx.Entry(nUser).State = EntityState.Modified;
                }
                else
                {    // Agregar
                    ctx.Entry(nUser).State = EntityState.Added;
                }
                ctx.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<usuario> search(FILTRAR searchfor, string valor)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (searchfor == FILTRAR.NOMBRE)
                    {
                        return ctx.usuarios.Where(r => r.nombre.Contains(valor)).ToList();
                    }
                    else
                    {
                        return ctx.usuarios.Where(r => r.appaterno.Contains(valor)).ToList();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<usuario> getallCBO()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.usuarios.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<usuario> getAllListar(string nombre)
        {
            try
            {
                var ctx = new DataModel();
                //return ctx.usuarios.Where(r => r.status == true).ToList();
                return (from r in ctx.usuarios.Where(r => r.status == true && r.nombre.Contains(nombre)).ToList()
                        select new usuario
                        {
                            idusuario = r.idusuario,
                            nombre = $"{r.nombre} {r.appaterno} {r.apmaterno}",
                            nickname = r.nickname,
                            email = r.email
                        }).ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static usuario returnUsuario(int id)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.usuarios.Where(r => r.idusuario == id).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public enum FILTRAR
        {
            APELLIDO=0,
            NOMBRE=1
        }
    }
}
