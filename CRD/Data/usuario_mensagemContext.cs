using CRD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Data
{
    public class Usuario_mensagemContext : DbContext
    {
        public Usuario_mensagemContext(DbContextOptions<Usuario_mensagemContext> opt) : base(opt)
        {

        }

        public DbSet<Usuario_mensagem> Usuario_mensagem { get; set; }

        internal Usuario_mensagem Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
