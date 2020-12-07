using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoChart.Models;

namespace ProjetoChart.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=GoogleChart;Integrated Security=True");
        }
        public DbSet<ProjetoChart.Models.Produto> Produto { get; set; }
    }
}
