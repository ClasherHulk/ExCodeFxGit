using ExCodeFxGIT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExCodeFxGIT.Context
{
    public class EmpContext : DbContext
    {
        public DbSet<Emp> Emp { get; set; }
    }
}