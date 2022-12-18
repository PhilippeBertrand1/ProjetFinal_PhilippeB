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
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void emprunterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpruntLivre formEmprunt = new EmpruntLivre(); // Création d'une instance 
            formEmprunt.MdiParent = this; // définir le formulaire parent
            formEmprunt.Show(); // affichage du formulaire enfant
            label1.Hide();
        }

        private void retoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetourLivre formRetour = new RetourLivre(); // Création d'une instance 
            formRetour.MdiParent = this; // définir le formulaire parent
            formRetour.Show(); // affichage du formulaire enfant
            label1.Hide();
        }

        private void créationDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreationClient formCreationClient = new CreationClient(); // Création d'une instance 
            formCreationClient.MdiParent = this; // définir le formulaire parent
            formCreationClient.Size = new Size(1100, 600);
            formCreationClient.Show(); // affichage du formulaire enfant
            label1.Hide();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterSupprimerModifierUnLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterSupprimerModifierLivres formLivre = new AjouterSupprimerModifierLivres (); // Création d'une instance 
            formLivre.MdiParent = this; // définir le formulaire parent
            formLivre.Show(); // affichage du formulaire enfant
            label1.Hide();
        }

        private void ajouterSupprimerModifierUnEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterSupprimerModifierEmployes formEmployes = new AjouterSupprimerModifierEmployes(); // Création d'une instance 
            formEmployes.MdiParent = this; // définir le formulaire parent
            formEmployes.Show(); // affichage du formulaire enfant
            label1.Hide();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClients formListeClients = new ListeClients(); // Création d'une instance 
            formListeClients.MdiParent = this; // définir le formulaire parent
            formListeClients.Show(); // affichage du formulaire enfant
            label1.Hide();
        }

        private void listesDesEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeEmployes formListeEmployes = new ListeEmployes(); // Création d'une instance 
            formListeEmployes.MdiParent = this; // définir le formulaire parent
            formListeEmployes.Show(); // affichage du formulaire enfant
            label1.Hide();
        }
    }
}
