using CRD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRD.Data
{
    public class MensagensContext : DbContext
    {

        public MensagensContext(DbContextOptions<MensagensContext> opt) : base(opt)
        {

        }

        public DbSet<Mensagem> Mensagens { get; set; }
    }
}
