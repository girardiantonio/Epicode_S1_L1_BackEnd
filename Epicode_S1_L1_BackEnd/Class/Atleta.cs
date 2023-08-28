using System;

namespace Epicode_S1_L1_BackEnd
{
    internal class Atleta
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string Sport { get; set; }
        public string Nazionalita { get; set; }

        private void Allenarsi(string correnteSport)
        {
            Console.WriteLine($"{Nome} si sta allenando per il suo sport: {correnteSport}");
        }
        private void PartecipaCompetizione(string competizione)
        {
            Console.WriteLine($"{Nome} partecipa alla competizione: {competizione}");
        }
        private void CambioSport(string nuovoSport)
        {
            Console.WriteLine($"{Nome} ha cambiato sport, ora gioca a {nuovoSport}");
        }
        private void Stipendio(int nuovoStipendio)
        {
            Console.WriteLine($"{Nome} il suo stipendio è {nuovoStipendio} al mese");
        }
        private void VisualizzaInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cognome: {Cognome}");
            Console.WriteLine($"Età: {Eta} anni");
            Console.WriteLine($"Sport: {Sport}");
            Console.WriteLine($"Nazionalità: {Nazionalita}");
        }

        public void StartAtleta()
        {
            Atleta calciatore = new Atleta();

            calciatore.Nome = "Mario";
            calciatore.Cognome = "Rossi";
            calciatore.Eta = 25;
            calciatore.Sport = "Calciatore";
            calciatore.Nazionalita = "Italiana";

            calciatore.Allenarsi(calciatore.Sport);
            calciatore.PartecipaCompetizione("Campionato Italiano");
            calciatore.Stipendio(2000);
            calciatore.CambioSport("Tennis");
            calciatore.VisualizzaInfo();
            Console.ReadLine();
        }
    }


}