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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Livre liv in StaticListes.LsLivresEmpruntes)
                if (liv.LivreID == txtIdRetour.Text)
                {
                    foreach (Client client in StaticListes.LsClients)
                        if (client.NumIdentifiant == txtIdClientRetour.Text)
                        {
                            StaticListes.LsInventaire.Add(liv);
                            StaticListes.LsLivresEmpruntes.Remove(liv);

                            MessageBox.Show("Le livre sélectionné a été retourné", "Merci pour votre retour !");
                        }
                }
        }

        private void RetourLivre_Load(object sender, EventArgs e)
        {
            foreach (Livre livres in StaticListes.LsLivresEmpruntes)
                AfficherEmployeListView(livres);
        }
        public void AfficherEmployeListView(Livre liv) //On va chercher les attributs de la classe Etudiant pour créer le tableau
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
        private void listViewRetour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
