using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    public class Votazione
    {
        public double Valutazione;
        public DateTime Data { get; private set; }

        private Studente Studente;
        public Materia M { get; private set; }


        public Votazione(Materia m, Studente studente, double valutazione)
        {
            this.Valutazione = valutazione;
            this.Studente = studente;
            this.M = m;

        }

        public bool IsSufficiente()
        {
            if (Valutazione >= 6)
            {
                return true;
            }
            else
                return false;
        }

        public double GetVoto()
        {
            return Valutazione;
        }
        public string Descrizione(Votazione v)
        {
            return $"{v.Valutazione}, Valutazione del {v.Data} di {v.Studente} in {v.M}";
        }
    }
}