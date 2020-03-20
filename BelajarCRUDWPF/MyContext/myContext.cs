using BelajarCRUDWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BelajarCRUDWPF.MyContext
{
    public class myContext : DbContext
    {
        public myContext() : base("BelajarCRUDWPF") { }
        public DbSet<supplier> Suppliers { get; set; }
        public DbSet<item> Items { get; set; }
    }
}
