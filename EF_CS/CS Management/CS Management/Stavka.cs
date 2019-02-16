using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Management
{
    class Stavka
    {

        public Stavka(Stavka_servisa stavkaServisa)
        {
            Kolicina = stavkaServisa.Kolicina;
            Servis = stavkaServisa.Servis.ToString();

            if (stavkaServisa.Dijelovi != null)
                Dijelovi = stavkaServisa.Dijelovi.ToString();


            if (stavkaServisa.Usluge != null)
                Usluge = stavkaServisa.Usluge.ToString();
        }

        public double Kolicina { get; set; }

        public string Dijelovi { get; set; }

        public string Servis { get; set; }

        public string Usluge { get; set; }
    }
}
