using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entidades;

namespace BLL
{
    public class ClientesBLL
    {
        public static bool Guardar(Clientes usuario)
        {
            bool retorno = false;

            try
            {
                BaseDatos Conn = new BaseDatos();

                Conn.Usuario.Add(usuario);

                Conn.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }
        public static void Eliminar(int id)
        {
            var db = new BaseDatos();

            Clientes usuario = new Clientes();

            db.Usuario.Remove(usuario);
            db.SaveChanges();
            
        }
        public static List<Clientes> GetLista(int usuarioId)
        {
            List<Clientes> listado = new List<Clientes>();

            var BaseDatos = new BaseDatos();

            listado = BaseDatos.Usuario.Where(Id => Id.UsuarioId == usuarioId).ToList();

            return listado;

        }

        public static List<Clientes> Eliminar(string text)
        {
            throw new NotImplementedException();
        }

        public static Clientes Buscar(int id)
        {
            var db = new BaseDatos();

            return db.Usuario.Find(id);

        }
        
    }
}
