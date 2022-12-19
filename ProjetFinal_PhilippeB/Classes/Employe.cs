using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_PhilippeB
{
    // Création de la classe enfant Employe qui hérite de la classe Personne
    public class Employe : Personne
    {
        // Création des attributs
        private int tauxHoraire;
        
        // Propriétés des attributs
        public int TauxHoraire
        {
            get { return tauxHoraire; }
            set { tauxHoraire = value; }
        }
    
        // Valeur par défaut 
        public Employe()
        {
            tauxHoraire = 0;
           
        }

        // Constructeur de la classe Employe qui hérite des attributs de la classe Personne
        public Employe(string p_numIdentifiant, string p_prenom, string p_nom, string p_NumTel, DateTime p_dateNaissance, char p_sexe, int p_tauxHoraire)
            : base(p_numIdentifiant, p_prenom, p_nom, p_NumTel, p_dateNaissance, p_sexe)
        {
            this.TauxHoraire = p_tauxHoraire;
            
        }

        // Méthode d'affichage
        public string Afficher()
        {
            return "Numéro d'identifiant :" + base.NumIdentifiant + "Prénom :" + base.Prenom + "Nom :" + base.Prenom + "Numéro de téléphone :" + base.NumTelephone
                + "Date de naissance :" + this.DateNaissance + "Sexe :" + this.Sexe + "Taux horaire :" + this.tauxHoraire; 
        }


    }

    
}
