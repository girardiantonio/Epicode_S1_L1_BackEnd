using Epicode_S1_L1_BackEnd.Class;
using System;

namespace Epicode_S1_L1_BackEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta = new Atleta();
            atleta.StartAtleta();

            Studente studente = new Studente();
            studente.StartStudente();

            Animale cavallo = new Animale();
            cavallo.StartAnimale();

            Dipendente dipendente = new Dipendente();
            dipendente.StartDipendente();

            Film film = new Film();
            film.StartFilm();

            Console.ReadLine();
        }
    }
}