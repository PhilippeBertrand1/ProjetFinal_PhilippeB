using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetFinal_PhilippeB
{
    public partial class EmpruntLivre : Form
    {
        SqlBibliotheque Livres;
        public EmpruntLivre()
        {
            InitializeComponent();
        }

        private void listViewEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Au chargement de la page,on instancie un nouvel object (SqlBibliotheque) on va chercher les données de la table Livres dans la base de données (Bibliotheque).
        /// Ensuite, on alimente le dataGridView avec les données récupérées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmpruntLivre_Load(object sender, EventArgs e)
        {
            Livres = new SqlBibliotheque();
            string Query = "Select * from Livre;";
            Livres.Command.CommandText = Query;
            Livres.Command.Connection = Livres.Connection;
            Livres.Adapter.SelectCommand = Livres.Command;
            Livres.Adapter.Fill(Livres.DsBibliotheque);
            Livres.DtLivre = Livres.DsBibliotheque.Tables[0];
            this.dataGridViewLivre.DataSource = Livres.DtLivre;
        }

        /// <summary>
        /// Bouton pour emprunter un livre, il est supprimer de la liste de l'inventaire pour être ajouté dans la liste des livres en cours d'emprunt
        /// ** Le bouton n'est pas fonctionnel malheureusement ** (Blocage)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmprunter_Click(object sender, EventArgs e)
        {
            // On parcours la liste de l'inventaire des livres
            foreach(Livre liv in StaticListes.LsInventaire)
            
                // Si le livre est égal à la valeur entrée par l'utilisateur
                if (liv.LivreID == txtIdEmprunt.Text)
                {
                    //foreach (Client client in StaticListes.LsClients)
                    //if (client.NumIdentifiant == txtIdEmprunt.Text)
                    // {

                    StaticListes.LsInventaire.Remove(liv);
                    StaticListes.LsLivresEmpruntes.Add(liv);

                    // Message qui informe la confirmation de l'emprunt
                    MessageBox.Show("Le livre sélectionné est à vous !", "Bonne lecture");
                    //}
                }
                else
                {
                    // Message qui informe la non-existance du livre 
                    MessageBox.Show("Le livre n'existe pas.", "Attention !");
                }
        }
    }
}
