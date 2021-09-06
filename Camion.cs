using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Véhicule
{
    public class Camion : Véhicule
    {
        public Camion(string _année, string _prix)
            : base( _année, _prix) { }
            // Appel du constructeur de la classe Véhicule
            // Le mot -clé "base" permet d'accéder à la classe parente

        // Ajoute un camion au parc auto
        public override void Démarrer()
        {
            Console.WriteLine("Le camion démarre  ");
            Console.WriteLine();
        }

        public override void Accélerrer()
        {
            Console.WriteLine("Le camion accélère ...");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Le camion " + base.ToString();
        }
    }
}