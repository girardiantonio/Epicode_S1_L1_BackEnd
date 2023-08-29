using System;

namespace Epicode_S1_L1_BackEnd
{
    internal class Studente
    {
        private string Nome { get; set; }
        private string Cognome { get; set; }
        private int Eta { get; set; }
        private int Matricola { get; set; }
        private string CorsoDiStudi { get; set; }

        private void CorsoStudi()
        {
            Console.WriteLine($"{Nome} sta studiando per il suo percorso di studi: {CorsoDiStudi}");
        }
        private void Studia(int nuovoOrario)
        {
            Console.WriteLine($"{Nome} studia almeno: {nuovoOrario} ore al giorno");
        }
        private void PrendiVoti(string nuovoVoto)
        {
            Console.WriteLine($"{Nome} al suo ultimo esame, ha preso {nuovoVoto} come voto");
        }
        private void CambiaCorso(string nuovoCorso)
        {
            Console.WriteLine($"{Nome} ha cambiato corso di studi, ora studia: {nuovoCorso} ");
        }
        private void VisualizzaInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cognome: {Cognome}");
            Console.WriteLine($"Età: {Eta} anni");
            Console.WriteLine($"Matricola: {Matricola}");
            Console.WriteLine($"Corso di studi: {CorsoDiStudi}");
        }

        public void StartStudente()
        {
            Studente studente = new Studente();

            studente.Nome = "Luca";
            studente.Cognome = "Deep";
            studente.Eta = 25;
            studente.Matricola = 11166;
            studente.CorsoDiStudi = "Economia Aziendale";

            studente.CorsoStudi();
            studente.Studia(8);
            studente.PrendiVoti("30 e lode");
            studente.CambiaCorso("Ingegneria Informatica");
            studente.VisualizzaInfo();
            Console.ReadLine();
        }
    }
}


