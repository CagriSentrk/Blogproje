using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bloglarproje.Models.siniflar
{
    public class Blogyorum
    {
       public IEnumerable<blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar>Deger2 { get; set; }
        public IEnumerable<blog>Deger3 { get; set; }
    }
}