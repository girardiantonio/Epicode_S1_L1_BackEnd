using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_S1_L1_BackEnd.Class
{
    internal class Animale
    {
        private string Nome { get; set; }
        private int Eta { get; set; }
        private string Tipo { get; set;}
        private string Peso { get; set;}
        private string Habitat { get; set;}

        private void Riprodursi()
        {
            Console.WriteLine($"{Nome} è in grado di riprodursi");
        }
        private void Muoversi()
        {
            Console.WriteLine($"{Nome} si muove a 4 zampe");
        }
        private void Mangiare()
        {
            Console.WriteLine($"{Nome} mangia fieno");
        }
        private void Invecchiare()
        {
            Console.WriteLine($"{Nome} invecchia molto facilmente");
        }
        private void VisualizzaInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Eta: {Eta}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Habitat: {Habitat}");
        }

        public void StartAnimale()
        {
            Animale cavallo = new Animale();

            cavallo.Nome = "Black";
            cavallo.Eta = 7;
            cavallo.Tipo = "mammifero perissodattilo";
            cavallo.Peso = "700 – 1.000 kg";
            cavallo.Habitat = "ambienti di pianura dell‛Eurasia temperata. Abitudini: gregario, vive in branchi di massimo 20 esemplari, dominati da uno stallone. Erbivoro.";

            cavallo.Riprodursi();
            cavallo.Muoversi();
            cavallo.Mangiare();
            cavallo.Invecchiare();
            cavallo.VisualizzaInfo();
            Console.ReadLine();
        }

    }
}
