/*Source : www.exelib.net / POO / Les classes abstraites - Véhicule
OBJECTIF :
 * Créer une classe abstraite.
 * Dériver une classe abstraite.
 * Implémenter une méthode abstraite.

ENNONCE :
 * Un parc auto se compose des voitures et des camions qui ont des caractéristiques communes regroupées dans la classe Véhicule.
 * Chaque véhicule est caractérisé par son matricule, l’année de son modèle, son prix.
 * Lors de la création d’un véhicule, son matricule est incrémenté selon le nombre de véhicules créés.
 * Tous les attributs de la classe véhicule sont supposés privés. ce qui oblige la création des accesseurs (get…) et des mutateurs (set….) ou les propriétés.
 * La classe Véhicule possède également deux méthodes abstraites démarrer() et accélérer() qui seront définies dans les classes dérivées et qui afficheront des messages personnalisés.
 * La méthode ToString() de la classe Véhicule retourne une chaîne de caractères qui contient les valeurs du matricule, de l’année du modèle et du prix.
 * Les classes Voiture et Camion étendent la classe Véhicule en définissant concrètement les méthodes accélérer() et démarrer() en affichant des messages personnalisés.

TRAVAIL A FAIRE :
 * Créer la classe abstraite Véhicule.
 * Créer les classes Camion et Voiture.
 * Créer une classe Test  qui permet de tester la classe Voiture et la classe Camion
*/

using System;
using System.Collections.Generic;

namespace TP_Véhicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule voiture1 = new Voiture("2012", "6500");
            Véhicule voiture2 = new Voiture("2017", "12500");
            Véhicule camion1 = new Camion("2014", "8650");
          
            Console.WriteLine(voiture1.ToString());
            voiture1.Accélerrer();
            voiture1.Démarrer();

            Console.WriteLine(voiture2.ToString());
            voiture2.Accélerrer();
            voiture2.Démarrer();

            Console.WriteLine(camion1.ToString());
            camion1.Accélerrer();
            camion1.Démarrer();

        }
    }
}
