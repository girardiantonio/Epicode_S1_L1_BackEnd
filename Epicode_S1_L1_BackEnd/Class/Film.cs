using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_S1_L1_BackEnd.Class
{
    internal class Film
    {
        private string Titolo { get; set; }
        private string Regista { get; set; }
        private string AnnoDiUscita { get; set; }
        private string Genere { get; set; }
        private string Durata { get; set; }

        private void Riproduci()
        {
            Console.WriteLine($"Premi Play per riprendere la visione del film {Titolo}");
        }
        private void Pausa()
        {
            Console.WriteLine($"Premi Stop per stoppare la visione del film {Titolo}");
        }
        private void Avanti()
        {
            Console.WriteLine($"Premi Avanti per andare di 30 secondi in avanti il film {Titolo}");
        }
        private void Indietro()
        {
            Console.WriteLine($"Premi Indietro per andare di 30 secondi in indietro il film {Titolo}");
        }
        private void MostraDettagli()
        {
            Console.WriteLine($"Titolo: {Titolo}");
            Console.WriteLine($"Regista: {Regista}");
            Console.WriteLine($"Anno di uscita: {AnnoDiUscita}");
            Console.WriteLine($"Genere: {Genere}");
            Console.WriteLine($"Durata: {Durata}");
        }

        public void StartFilm()
        {
            Film film = new Film();

            film.Titolo = "Il Signore degli Anelli: La Compagnia dell'Anello";
            film.Regista = "Peter Jackson";
            film.AnnoDiUscita = "2001";
            film.Genere = "Fantasy";
            film.Durata = "178 minuti";

            film.Riproduci();
            film.Pausa();
            film.Avanti();
            film.Indietro();
            film.MostraDettagli();
            Console.ReadLine();
        }
    }
}
