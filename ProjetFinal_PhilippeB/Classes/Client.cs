using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_PhilippeB
{

    
    public class Client : Personne 
    {
        private string adresse;


        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public Client()
        {
            adresse = "";
        }

        public Client(string p_numIdentifiant, string p_prenom, string p_nom, string p_NumTel, DateTime p_dateNaissance, char p_sexe, string p_adresse)
            :base(p_numIdentifiant, p_prenom, p_nom, p_NumTel, p_dateNaissance, p_sexe)
        {
            this.adresse = p_adresse;
        }

        public string Afficher()
        {
            
            return "Numéro d'identifiant :" + base.NumIdentifiant + "Prénom :" + base.Prenom + "Nom :" + base.Prenom + "Numéro de téléphone :" + base.NumTelephone
                    + "Date de naissance :" + this.DateNaissance + "Sexe :" + this.Sexe + "Adresse :" + this.adresse;
            
        }
    }
}
