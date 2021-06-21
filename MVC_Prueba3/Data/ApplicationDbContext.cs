using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVC_Prueba3.Models;

namespace MVC_Prueba3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVC_Prueba3.Models.Producto> Producto { get; set; }
        public DbSet<MVC_Prueba3.Models.Local> Local { get; set; }
    }
}
