using System;
using System.Collections.Generic;
using System.Text;

namespace Registro
{
    class Scuola
    {
         public string Nome { get; private set; }

        public List<Classe> Classi { get; private set; }
        public List<Materia>Materie { get; private set; }

        public Scuola(string nome)
        {
            this.Nome = nome;
            Classi = new List<Classe>();
        }
        public Classe CreaClasse(int anno, string sezione)
        {
            Classe c = new Classe(anno, sezione);
            Classi.Add(c);
            return c;
        }
        public Materia CreaMateria(string nome)
        {
            Materia m = new Materia(nome);
            Materie.Add(m);
            return m;
        }

        public Votazione TrovaVotoMassimo()
        {
            double max = -1;
            int c = 0;
            for (int i = 0; i < Classi.Count; i++)
            {
                Votazione votomax = Classi[i].TrovaVotoMassimo();
                if (votomax.GetVoto() > max)
                {
                    max = votomax.GetVoto();
                    c = i;
                }
            }
            return Classi[c].TrovaVotoMassimo();
        }
    }
}
