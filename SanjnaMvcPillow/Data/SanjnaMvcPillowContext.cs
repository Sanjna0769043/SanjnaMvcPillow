using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SanjnaMvcPillow.Models;

namespace SanjnaMvcPillow.Data
{
    public class SanjnaMvcPillowContext : DbContext
    {
        public SanjnaMvcPillowContext (DbContextOptions<SanjnaMvcPillowContext> options)
            : base(options)
        {
        }

        public DbSet<SanjnaMvcPillow.Models.Pillow> Pillow { get; set; }
    }
}
