using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevOpsLucasNavarro.Models;

namespace DevOpsLucasNavarro.Data
{
    public class DevOpsLucasNavarroContext : DbContext
    {
        public DevOpsLucasNavarroContext (DbContextOptions<DevOpsLucasNavarroContext> options)
            : base(options)
        {
        }

        public DbSet<DevOpsLucasNavarro.Models.Aluno> Aluno { get; set; } = default!;
    }
}
