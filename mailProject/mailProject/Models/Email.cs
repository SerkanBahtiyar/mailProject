using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mailProject.Models
{
    public class Email
    {
        public string baslik { get; set; }
        public string icerik { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
    }
}