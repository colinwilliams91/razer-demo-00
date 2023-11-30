using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razer_demo_00.Models;

namespace razer_demo_00.Data
{
    public class razer_demo_00Context : DbContext
    {
        public razer_demo_00Context (DbContextOptions<razer_demo_00Context> options)
            : base(options)
        {
        }

        public DbSet<razer_demo_00.Models.Fruit> Fruit { get; set; } = default!;
    }
}
