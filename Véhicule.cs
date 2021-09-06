using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Véhicule
{   // Définit un véhicule
    public abstract class Véhicule
    {
        private static int nb_véhicules = 0;
        private int matricule;
        private string année;
        private string prix;

        public Véhicule(string _année, string _prix)
        {
            nb_véhicules++;
            matricule = nb_véhicules;
            année = _année;
            prix = _prix;
        }

        public int m_matricule
        {
            get { return matricule; }
        }

        public string m_année
        {
            get { return année; }
            set { année = value; }
        }

        public string m_prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public static int m_nb_véhicules
        {
            get { return nb_véhicules; }
        }
        // Constructeur 
        public abstract void Démarrer();
        public abstract void Accélerrer();

        // Renvoie la déscription du véhicule ajouté
        public virtual string ToString()
        {
            return "(" + matricule + ". | Année : " + année + ". | Valeur = " + prix + ").";
        }
    }
}