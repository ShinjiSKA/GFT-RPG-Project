using System;
using ProjetoRPG.src.Entities;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 469, 72);
            Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 89);
            WhiteWizard jennica = new WhiteWizard("Jennica", 23, "White Wizard", 325, 474);
            BlackWizard blackwizard = new BlackWizard("Topapa", 42, "Black Wizard", 106, 611);

            Console.WriteLine(arus);
            Console.WriteLine(wedge);
            Console.WriteLine(jennica);
            Console.WriteLine(blackwizard);
        }
    }
}
