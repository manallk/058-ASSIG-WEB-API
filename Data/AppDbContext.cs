using System;
using Microsoft.EntityFrameworkCore;
using portfolio_new.models;

namespace portfolio_new.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }
        public DbSet<login> person { get; set; }
    }
}
