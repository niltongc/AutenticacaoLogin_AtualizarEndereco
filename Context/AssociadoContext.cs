using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProAuto.Models;

namespace ProAuto.Context
{
    public class AssociadoContext : DbContext
    {
        public AssociadoContext(DbContextOptions<AssociadoContext> options) : base(options)
        {

        }
        public DbSet<AssociadoModel> Associados { get; set; }

    }
}