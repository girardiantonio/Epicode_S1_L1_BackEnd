using System;
using static Epicode_S1_L1_BackEnd.Atleta;
using static Epicode_S1_L1_BackEnd.Studente;

namespace Epicode_S1_L1_BackEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta = new Atleta();
            atleta.StartAtleta();
        }
    }
}