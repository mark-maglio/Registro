
using Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroConsole
{
        class Program
        {
            static void Main(string[] args)
            {

            Scuola scuola = new Scuola("RosselliRasetti");

                Classe c = new Classe(4, "AI");
                Studente s1 = new Studente("Alessio", "Manieri");
                Studente s2 = new Studente("Filippo", "Pepe");

                Materia m1 = new Materia("Informatica");
                Materia m2 = new Materia("Italiano");
                Materia m3 = new Registro.Materia("Matematica");
                Materia m4 = new Materia("Religione");

                Votazione v1 = new Votazione(m1, s1, 8);
                Votazione v2 = new Votazione(m3, s1, 9);
                Votazione v3 = new Votazione(m2, s1, 6);
                Votazione v4 = new Votazione(m4, s1, 3);

                s1.AddVoto(v1);
                s1.AddVoto(v3);

                s2.AddVoto(v2);
                s2.AddVoto(v4);

                Console.WriteLine(s1.TrovaVotoMassimo());

            }
        }

    class Scuola
    {
    }
}