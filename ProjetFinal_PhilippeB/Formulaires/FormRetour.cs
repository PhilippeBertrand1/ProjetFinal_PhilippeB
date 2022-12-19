using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal_PhilippeB
{
    public partial class RetourLivre : Form
    {
        public RetourLivre()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Bouton pour retourner un livre, il est supprimer de la liste des livres en cours d'emprunt pour être ajouté dans la liste de l'inventaire
        /// ** Le bouton n'est pas fonctionnel malheureusement ** (Blocage)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // On parcours la liste des livres empruntés
            foreach (Livre liv in StaticListes.LsLivresEmpruntes)
                // Si le livre est égal à la valeur entrée par l'utilisateur
                if (liv.LivreID == txtIdRetour.Text)
                {
                    foreach (Client client in StaticListes.LsClients)
                        if (client.NumIdentifiant == txtIdClientRetour.Text)
                        {
                            StaticListes.LsInventaire.Add(liv);
                            StaticListes.LsLivresEmpruntes.Remove(liv);

                            //Message qui confirme le retour d'un livre
                            MessageBox.Show("Le livre sélectionné a été retourné", "Merci pour votre retour !");
                        }
                }
        }

        private void RetourLivre_Load(object sender, EventArgs e)
        {
            // On parcours la liste des employés pour ensuite les afficher
            // dans la listView grâce à la fonction "AfficherEmployeListView"
            foreach (Livre livres in StaticListes.LsLivresEmpruntes)
                AfficherLivreListView(livres);
        }
        /// <summary>
        /// Méthode d'affichage en tableau pour les employés dans la listView
        /// Chaque index du tableau représente un attribut de l'employé
        /// **Bout de code tiré de l'exercice GestElection de Hasna Hocini**
        /// </summary>
        /// <param name="emp"></param>
        public void AfficherLivreListView(Livre liv) //On va chercher les attributs de la classe Livre pour créer le tableau
        {
            //Création d'un tableau pour l'affichage dans la listView
            string[] arr = new string[5];
            ListViewItem item;
            //Assignation de chaque attributs à un index du tableau
            arr[0] = liv.LivreID;
            arr[1] = liv.Titre;
            arr[2] = liv.Auteur;
            arr[3] = liv.AnneeParution.ToString();
            item = new ListViewItem(arr);
            //Ajouter l'item dans la listView en question
            listViewRetour.Items.Add(item);
        }
    }
}
