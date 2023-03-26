using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberUyg.BusinessLayer
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public int TC { get; set; }
        public string Departman { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Ad"></param>
        /// <param name="Soyad"></param>
        /// <param name="Email"></param>
        /// <param name="TC"></param>
        /// <param name="Departman"></param>

        public Personel(string Ad, string Soyad, string Email, int TC, string Departman)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.Email = Email;
            this.TC = TC;
            this.Departman = Departman;
        }

        public Personel() { }


    }
}
