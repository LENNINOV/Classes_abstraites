using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Véhicule
{
    public class Voiture : Véhicule
    {
        public Voiture(string _année, string _prix)
            : base(_année, _prix) { }
            // appel du constructeur de la classe Véhicule
            // le mot-clé "base" permet d'accéder à la classe parente 
        
        // Ajoute une voiture au parc auto
        public override void Démarrer()
        {
            Console.WriteLine("La voiture démarre ...");
            Console.WriteLine();
        }

        public override void Accélerrer()
        {
            Console.WriteLine("La voiture accélère ...");
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "La voiture " + base.ToString();
        }
    }
}