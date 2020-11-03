using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    public class Studente
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

        public Votazione TrovaVotoMinimo()
        {
            double min = 0;
            Materia minm = new Materia("");
            Studente mins = new Studente(" ", " ");

            Votazione minimo = new Votazione(minm, mins, 0);

            for (int i = 0; i < Voti.Count; i++)
            {
                if (Voti[i].Valutazione > min)
                {
                    min = Voti[i].Valutazione;
                    minimo = Voti[i];

                }

            }
            return minimo;
        }
        public string NomeCompleto(Studente s)
        {
            return $"{s.Cognome}{s.Nome}, nato il {s.DataNascita}";
        }
    }
}
