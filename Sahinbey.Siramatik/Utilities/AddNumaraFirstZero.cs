using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahinbey.Siramatik.Utilities
{
    public static class AddNumaraFirstZero
    {
        public static string SifirEkle(int sayi, int rakam = 2)
        {
            if (rakam == 2)
            {
                if (sayi < 10)
                {
                    string newNumber = "0" + sayi;
                    return newNumber;
                }
                else
                    return sayi.ToString();
            }
            if (rakam == 3)
            {
                if (sayi < 10)
                {
                    string newNumber = "00" + sayi;
                    return newNumber;
                }
                else if (sayi < 100)
                {
                    string newNumber = "0" + sayi;
                    return newNumber;
                }
                else
                    return sayi.ToString();
            }
            if (rakam == 4)
            {
                if (sayi < 10)
                {
                    string newNumber = "000" + sayi;
                    return newNumber;
                }
                else if (sayi < 100)
                {
                    string newNumber = "00" + sayi;
                    return newNumber;
                }
                else if (sayi < 1000)
                {
                    string newNumber = "000" + sayi;
                    return newNumber;
                }
                else
                    return sayi.ToString();
            }
            else
                return sayi + "";
        }
    }
}
