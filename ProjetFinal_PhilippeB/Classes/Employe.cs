using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_PhilippeB
{
    public class Employe : Personne
    {
        private int tauxHoraire;


        public int TauxHoraire
        {
            get { return tauxHoraire; }
            set { tauxHoraire = value; }
        }

        public Employe()
        {
            tauxHoraire = 0;
        }

        public Employe(string p_numEtudiant, string p_prenom, string p_nom, string p_NumTel, DateTime p_dateNaissance, string p_sexe, int p_tauxHoraire)
            : base(p_numEtudiant, p_prenom, p_nom, p_NumTel, p_dateNaissance, p_sexe)
        {
            this.TauxHoraire = p_tauxHoraire;
        }

        public string Afficher()
        {
            return "Numéro d'identifiant :" + base.NumIdentifiant + "Prénom :" + base.Prenom + "Nom :" + base.Prenom + "Numéro de téléphone :" + base.NumTelephone
                + "Date de naissance :" + this.DateNaissance + "Sexe :" + this.Sexe + "Taux horaire :" + this.tauxHoraire; 
        }


    }

    
}
