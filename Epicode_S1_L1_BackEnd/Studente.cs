﻿using System;

namespace Epicode_S1_L1_BackEnd
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public int Matricola { get; set; }
        public string CorsoDiStudi { get; set; }

        public void CorsoStudi(string correnteStudi)
        {
            Console.WriteLine($"{Nome} sta studiando per il suo percorso di studi: {correnteStudi}");
        }
        public void Studia(int nuovoOrario)
        {
            Console.WriteLine($"{Nome} studia almeno: {nuovoOrario} ore al giorno");
        }
        public void PrendiVoti(string nuovoVoto)
        {
            Console.WriteLine($"{Nome} al suo ultimo esame, ha preso {nuovoVoto} come voto");
        }
        public void CambiaCorso(string nuovoCorso)
        {
            Console.WriteLine($"{Nome} ha cambiato corso di studi, ora studia: {nuovoCorso} ");
        }
        public void VisualizzaInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cognome: {Cognome}");
            Console.WriteLine($"Età: {Eta} anni");
            Console.WriteLine($"Matricola: {Matricola}");
            Console.WriteLine($"Corso di studi: {CorsoDiStudi}");
        }


        internal class ProgrammaStudente
        {
            static void Main(string[] args)
            {

                Studente studente = new Studente();

                studente.Nome = "Mario";
                studente.Cognome = "Rossi";
                studente.Eta = 22;
                studente.Matricola = 82002;
                studente.CorsoDiStudi = "Economia Aziendale";

                studente.CorsoStudi(studente.CorsoDiStudi);
                studente.Studia(8);
                studente.PrendiVoti("30 e lode");
                studente.CambiaCorso("Ingegneria Informatica");
                studente.VisualizzaInfo();
            }
        }
    }
}


