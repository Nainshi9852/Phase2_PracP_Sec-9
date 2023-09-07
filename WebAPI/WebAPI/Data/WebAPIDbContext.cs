using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class WebAPIDbContext : DbContext
    {
        public WebAPIDbContext (DbContextOptions<WebAPIDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAPI.Models.Marks> Marks { get; set; } = default!;
    }
}
