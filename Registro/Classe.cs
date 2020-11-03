﻿using System;
using System.Collections.Generic;


namespace Registro
{
    public class Classe
    {
        private int Anno;
        private string Sezione;
        List<Studente> studenti = new List<Studente>();

        public Classe(int anno, string sezione)
        {
            this.Anno = anno;
            this.Sezione = sezione;
        }

        public string GetNome()
        {
            string annostring = Anno.ToString();
            return annostring + Sezione;

        }


        public Votazione TrovaVotoMassimo()
        {
            double max = -1;
            int c = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Votazione votomax = studenti[i].TrovaVotoMassimo();
                if (votomax.GetVoto() > max)
                {
                    max = votomax.GetVoto();
                    c = i;
                }
            }
            return studenti[c].TrovaVotoMassimo();
        }
        public Votazione TrovaVotoMinimo()
        {
            double min = 11;
            int c = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                Votazione votomin = studenti[i].TrovaVotoMinimo();
                if (votomin.GetVoto() < min)
                {
                    min = votomin.GetVoto();
                    c = i;
                }
            }
            return studenti[c].TrovaVotoMinimo();

        }

    }
}
