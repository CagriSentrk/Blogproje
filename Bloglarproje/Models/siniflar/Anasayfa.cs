using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bloglarproje.Models.siniflar;

namespace Bloglarproje.Models.siniflar
{
    public class Anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}