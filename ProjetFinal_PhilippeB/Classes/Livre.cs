using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_PhilippeB
{
    // Création de la classe Livre
    public class Livre
    {
        //Création des attributs

        private string livreID;
        private string titre;
        private string auteur;
        private int anneeParution;
        private DateTime dateRetour;
        private DateTime dateEmprunt;

        //Propriétés des attributs
        public string LivreID
        {
            get { return livreID; }
            set { livreID = value; }
        }
        public string Titre
        {
            get { return Titre; }
            set { titre = value; }
        }
        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        public int AnneeParution
        {
            get { return anneeParution; }
            set { anneeParution = value; }
        }
        public DateTime DateRetour
        {
            get { return dateRetour; }
            set { dateRetour = value; }
        }
        public DateTime DateEmprunt
        {
            get { return DateEmprunt; }
            set { dateEmprunt = value; }
        }

        // Valeur par défaut des attributs
        public Livre()
        {
            livreID = "";
            titre = "";
            auteur = "";
            anneeParution = 0;
            dateRetour = DateTime.Now;
            dateEmprunt = DateTime.Now;
        }

        // Constructeur de la classe Livre
        public Livre(string p_livreID, string p_titre, string p_auteur, int p_anneeParution, DateTime p_dateRetour, DateTime p_dateEmprunt)
        {
            this.LivreID = p_livreID;
            this.Titre = p_titre;
            this.Auteur = p_auteur;
            this.AnneeParution = p_anneeParution;
            this.DateRetour = p_dateRetour;
            this.DateEmprunt = p_dateEmprunt;
        }

        /*public DateTime CalculerDureeEmprunt(DateTime p_dateRetour, DateTime p_dateEmprunt)
        {
            DateTime duree = dateEmprunt - dateRetour;
        }
        */
    }
}
