using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    class Studente
    {
        public string Nome { get; private set; }
        public string Cognome { get; private set; }
        public DateTime DataNascita { get; set; }

        public List<Votazione> Voti { get; private set; }

        public Studente(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }

        public void AddVoto(Votazione v)
        {
            Voti.Add(v);
        }

        public Votazione TrovaVotoMassimo()
        {
            double max = 0;
            Materia maxm = new Materia("");
            Studente maxs = new Studente(" ", " ");

            Votazione massimo = new Votazione(maxm, maxs, 0);

            for (int i = 0; i < Voti.Count; i++)
            {
                if (Voti[i].Valutazione > max)
                {
                    max = Voti[i].Valutazione;
                    massimo = Voti[i];

                }

            }
            return massimo;
        }
    }
}
