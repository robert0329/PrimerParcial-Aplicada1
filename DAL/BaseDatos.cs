using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class BaseDatos : DbContext
    {
        public BaseDatos() : base("name=ConStr")
        {

        }

        public virtual DbSet<Clientes> Usuario { get; set; }
    }
}
