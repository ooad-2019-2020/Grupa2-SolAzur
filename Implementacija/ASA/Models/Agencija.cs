﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authTest.Models
{
    public class Agencija
    {
        public int Id { get; set; }
        public virtual ICollection<Rezervacija> Ponude { get; set; }
        public virtual ICollection<Korisnik> Korisnici { get; set; }
        public virtual ICollection<Putovanje> Kodovi { get; set; }

        public string Info { get; set; }
        public string Naziv { get; set; }
        public string UsloviPutovanja { get; set; }
        public int RacunId { get; set; }
        public virtual Racun Racun { get; set; }


        public Agencija()
        {
        }
    }
}
