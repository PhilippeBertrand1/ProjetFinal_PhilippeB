using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_PhilippeB
{
    // Création de la classe statique StaticListes
    public static class StaticListes
    {
        //Création des attributs

        private static List<Employe> lsEmployes;
        private static List<Client> lsClients;
        private static List<Livre> lsInventaire;
        private static List<Livre> lsLivresEmpruntes;

        // Propriétés des attributs

        public static List<Employe> LsEmployes
        {
            get { return lsEmployes; }
            set { lsEmployes = value; }
        }
        public static List<Client> LsClients
        {
            get { return lsClients; }
            set { lsClients = value; }
        }
        public static List<Livre> LsInventaire
        {
            get { return lsInventaire; }
            set { lsInventaire = value; }
        }
        public static List<Livre > LsLivresEmpruntes
        {
            get { return lsLivresEmpruntes; }
            set { lsLivresEmpruntes = value; }
        }

        static StaticListes()
        {
            lsEmployes = new List<Employe>();
            lsClients = new List<Client> ();
            lsInventaire = new List<Livre> ();
            lsLivresEmpruntes = new List<Livre> ();
        }

       
    }


}
