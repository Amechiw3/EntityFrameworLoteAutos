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
    class clsManejoPropietarios
    {
        public static propietario searchINE(string INE)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.propietarios.Where(r => r.ine == INE).FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw;
            }
        }

        public static void SavePropietario(propietario propietario)
        {
            try
            {
                var ctx = new DataModel();
                if (propietario.idpropietario > 0) //Actualizar
                {
                    ctx.Entry(propietario).State = EntityState.Modified;
                }
                else // Agregar
                {
                    ctx.Entry(propietario).State = EntityState.Added;
                }
                ctx.SaveChanges();

            }
            catch (Exception exc)
            {

                throw;
            }
        }

        public static propietario returnPropietario(int ID)
        {
            try
            {
                var ctx = new DataModel();
                return ctx.propietarios.Where(r => r.idpropietario == ID).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void getall(DataGridView datos)
        {
            try
            {
                var ctx = new DataModel();
                Image foto;
                int x = 0;
                foreach (var item in ctx.propietarios.ToList())
                {
                    DataGridViewRow nRow = (DataGridViewRow)datos.Rows[0].Clone();
                    nRow.Cells[0].Value = item.idpropietario.ToString();
                    nRow.Cells[1].Value = Image.FromFile(Directory.GetCurrentDirectory() + @"\Propietario\" + item.fotografia);
                    nRow.Cells[2].Value = $"{item.nombre} {item.appaterno} {item.apmaterno}";
                    nRow.Cells[3].Value = item.telefono;
                    nRow.Cells[4].Value = item.correo;

                    datos.Rows.Add(nRow);             
                }
                datos.AllowUserToAddRows = false;

                /*return (from r in ctx.propietarios.ToList()
                        select new propietario
                        {
                            idpropietario = r.idpropietario,
                            //fotografia = Image.FromFile(Directory.GetCurrentDirectory() + @"\Propietario\" + r.fotografia),
                            fotografia =  r.fotografia,
                            nombre = $"{r.nombre} {r.appaterno} {r.apmaterno}",
                            telefono = r.telefono,
                            correo = r.correo
                        }).ToList();*/
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static void searchPRopietario(DataGridView datos, string nombre)
        {
            try
            {
                var ctx = new DataModel();
                Image foto;
                int x = 0;
                foreach (var item in ctx.propietarios.Where(r => r.nombre.Contains(nombre) || r.appaterno.Contains(nombre) || r.apmaterno.Contains(nombre)).ToList())
                {
                    DataGridViewRow nRow = (DataGridViewRow)datos.Rows[0].Clone();
                    nRow.Cells[0].Value = item.idpropietario.ToString();
                    nRow.Cells[1].Value = Image.FromFile(Directory.GetCurrentDirectory() + @"\Propietario\" + item.fotografia);
                    nRow.Cells[2].Value = $"{item.nombre} {item.appaterno} {item.apmaterno}";
                    nRow.Cells[3].Value = item.telefono;
                    nRow.Cells[4].Value = item.correo;

                    datos.Rows.Add(nRow);
                }
                datos.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static List<propietario> getallCBO()
        {
            try
            {
                var ctx = new DataModel();
                return ctx.propietarios.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
