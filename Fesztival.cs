using System;
using System.Collections.Generic;
using System.Text;

namespace FesztivalGUI
{
    internal class Fesztival
    {
        public Fesztival(string l)
        {
            var r = l.Split("\t");
            Id = int.Parse(r[0]);
            Nev = r[1];
            Varos = r[2];
            Megye = r[3];
            Alapitas = int.Parse(r[4]);
            Latogato = int.Parse(r[5]);
            Jegyar = int.Parse(r[6]);
        }

        public int Id { get; set; }
        public string Nev { get; set; }
        public string Varos { get; set; }
        public string Megye { get; set; }
        public int Alapitas { get; set; }
        public int Latogato { get; set; }
        public int Jegyar { get; set; }


    }
}
