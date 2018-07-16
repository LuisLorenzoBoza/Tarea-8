using RegistroLibros.DAL;
using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibros.BLL
{
    public class LibrosBLL
    { 
     public static bool Guardar(Libros libro)
     {
        bool paso = false;
        Contexto contexto = new Contexto();
        try
        {
            if (contexto.Libros.Add(libro) != null)
            {
                contexto.SaveChanges();
                paso = true;
            }
            contexto.Dispose();
        }
        catch (Exception)
        {
            throw;
        }
        return paso;
    }

    public static bool Modificar(Libros libro)
    {
        bool paso = false;

        Contexto contexto = new Contexto();
        try
        {
            contexto.Entry(libro).State = EntityState.Modified;
            if (contexto.SaveChanges() > 0)
            {
                paso = true;
            }
            contexto.Dispose();
        }
        catch (Exception)
        {
            MessageBox.Show("El libro no se ha modificado");
        }
        return paso;
    }

    public static bool Eliminar(int id)
    {
        bool paso = false;

        Contexto contexto = new Contexto();
        try
        {
            Libros libros = contexto.Libros.Find(id);

            contexto.Libros.Remove(libros);

            if (contexto.SaveChanges() > 0)
            {
                paso = true;
            }
            contexto.Dispose();
        }
        catch (Exception)
        {
            MessageBox.Show("No se encuentran libros registrados");
        }
        return paso;
    }

    public static Libros Buscar(int id)
    {
        Contexto contexto = new Contexto();
        Libros libros = new Libros();
        try
        {
            libros = contexto.Libros.Find(id);
            contexto.Dispose();
        }
        catch (Exception)
        {
            MessageBox.Show("No se encuentran libros registrados");
        }
        return libros;
    }

    public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
    {
        List<Libros> libros = new List<Libros>();
        Contexto contexto = new Contexto();
        try
        {
            libros = contexto.Libros.Where(expression).ToList();
            contexto.Dispose();
        }
        catch (Exception)
        {
            MessageBox.Show("No se encuentran libros registrados");
        }
        return libros;
    }
        }
}
