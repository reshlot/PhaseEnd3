using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phaseend.Model;

namespace Phaseend.Data
{
    public class PhaseendDbContext : DbContext
    {
        public PhaseendDbContext (DbContextOptions<PhaseendDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phaseend.Model.DeptMaster> DeptMaster { get; set; } = default!;
    }
}
