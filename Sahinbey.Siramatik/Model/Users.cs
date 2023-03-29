using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Model
{
    public class Users
    {
        [Key]
        public int No { get; set; }
        public string TcKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int? KioskPages { get; set; }
    }
}
