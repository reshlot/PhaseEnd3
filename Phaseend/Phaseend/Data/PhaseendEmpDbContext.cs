using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Phaseend.Model;

namespace Phaseend.Data
{
    public class PhaseendEmpDbContext : DbContext
    {
        public PhaseendEmpDbContext (DbContextOptions<PhaseendEmpDbContext> options)
            : base(options)
        {
        }

        public DbSet<Phaseend.Model.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
