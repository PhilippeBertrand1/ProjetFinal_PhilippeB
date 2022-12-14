using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_PhilippeB
{
    public class Personne
    {
        private string numIdentifiant;
        private string prenom;
        private string nom;
        private string numTelephone;
        private DateTime dateNaissance;
        private char sexe;

        public string NumIdentifiant
        {
            get { return numIdentifiant; }
            set { numIdentifiant = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string NumTelephone
        {
            get { return numTelephone; }
            set { numTelephone = value; }
        }
        public DateTime DateNaissance
        {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }
        public char Sexe
        {
            get { return sexe; }
            set { sexe = value; }         
        }

        public Personne()
        {
            numIdentifiant = "";
            prenom = "";
            nom = "";
            numTelephone = "";
            dateNaissance = DateTime.Now;
            sexe = '\0';
        }

        public Personne(string p_numIdentifiant, string p_prenom, string p_nom, string p_NumTel, DateTime p_dateNaissance, char p_sexe)
        {
            this.NumIdentifiant = p_numIdentifiant;
            this.Prenom = p_prenom;
            this.Nom = p_nom;
            this.numTelephone = p_NumTel;
            this.dateNaissance = p_dateNaissance;
            this.sexe = p_sexe;
        }
    }
}
