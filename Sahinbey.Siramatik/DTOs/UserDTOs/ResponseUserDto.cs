using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.DTOs.UserDTOs
{
    public class ResponseUserDto
    {
        public int No { get; set; }
        public string TcKimlikNo { get; set; }
        public string AdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public int? KioskPages { get; set; }
    }
}
