using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Bloglarproje.Models.siniflar
{
    public class Context:DbContext
    {
      public DbSet <Admin> Admins { get; set; }
      public DbSet <Kullanici> kullanicis { get; set; }
        public DbSet<blog> blogs { get; set; }
        public DbSet<Hakkimizda> hakkimizdas { get; set; }
        public DbSet<Yorumlar> yorumlars { get; set; }
    }
}