using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_S1_L1_BackEnd.Class
{
    internal class Dipendente
    {
        private string Nome { get; set; }
        private int Eta { get; set; }
        private string Ruolo { get; set; }
        private int Stipendio { get; set; }
        private string Dipartimento { get; set; }

        private void Lavorare(int nuovoOrario)
        {
            Console.WriteLine($"{Nome} lavora {nuovoOrario} al giorno");
        }
        private void Ferie(string nuovoFerie)
        {
            Console.WriteLine($"{Nome} va in ferie il {nuovoFerie} agosto");
        }
        private void CalcolaBonus(int nuovoBonus)
        {
            int stipendioBonus = Stipendio + nuovoBonus;
            Console.WriteLine($"{Nome} ha preso un bonus quest'anno il suo stipendio è {stipendioBonus}");
        }

        private void Promuovi()
        {
            Console.WriteLine($"{Nome} è stato bravo ed è stato promosso a Capo Reparto");
        }
        private void VisualizzaInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Eta: {Eta}");
            Console.WriteLine($"Ruolo: {Ruolo}");
            Console.WriteLine($"Stipendio: {Stipendio}");
            Console.WriteLine($"Dipartimento: {Dipartimento}");
        }

        public void StartDipendente()
        {
            Dipendente dipendente = new Dipendente();

            dipendente.Nome = "Mario";
            dipendente.Eta = 30;
            dipendente.Ruolo = "Addetto al reparto";
            dipendente.Stipendio = 2000;
            dipendente.Dipartimento = "Teconologia";

            dipendente.Lavorare(8);
            dipendente.Ferie("12");
            dipendente.CalcolaBonus(200);
            dipendente.Promuovi();
            dipendente.VisualizzaInfo();
            Console.ReadLine();
        }
    }
}
