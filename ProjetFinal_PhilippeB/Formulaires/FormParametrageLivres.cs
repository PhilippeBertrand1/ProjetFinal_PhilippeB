using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ProjetFinal_PhilippeB
{
    public partial class AjouterSupprimerModifierLivres : Form
    {
        SqlBibliotheque Livres;
        public AjouterSupprimerModifierLivres()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void ViderChamps()
        {
            txtTitre.Text = "";
            txtIdLivre.Text = "";
            txtAnneParution.Text = "";
            txtAuteur.Text = "";
            txtMdpAdmin.Text = "";

        }
            
        public bool VerifierRegex(string modele, TextBox txt, Label lbl, string messageErreur) //Paramètres voulus lorsqu'on appelle la fonction
        {
            //Création du Regex reg 
            Regex reg = new Regex(modele);

            if (!reg.IsMatch(txt.Text))
            {
                //Afficher un message d'erreur
                lbl.ForeColor = Color.Red;
                lbl.Text = messageErreur;
                //Effacer la TextBox 
                txt.Clear();
                return false;
            }
            else lbl.Text = ""; //Effacer le label si le champ entré est valide
            return true;
        }

        public bool VerificationTous()
        {
            bool b_id, b_titre, b_auteur, b_anneeparution, b_mdpAdmin;

            b_id = VerifierRegex("^[0-9]{2}$", txtIdLivre, lblErreurLivreID, "2 chiffres obligatoire");
            b_titre = VerifierRegex("^[A-Z]{1}[a-z]{1,40}", txtTitre, lblErreurTitre, "Une lettre majuscule en premier obligatoire, 40 caractères maximum");
            b_auteur = VerifierRegex("^[A-Z]{1}[a-z]{1,40}", txtAuteur, lblErreurAuteur, "Il faut un espace entre le nom et le prénom");
            b_anneeparution = VerifierRegex("^[1900-2022]{4}$", txtAnneParution, lblErreurAnneeParution, "L'année de parution doit être de 4 caractères obligatoire et entre 1900 et 2022");
            b_mdpAdmin = VerifierRegex("Admin", txtMdpAdmin, lblErreurMdpAdminLivre, "Mot de passe admin incorrect");

            if (b_id && b_titre && b_auteur && b_anneeparution && b_mdpAdmin)
                return true;
            else return false;
        }
        private void AjouterSupprimerModifierLivres_Load(object sender, EventArgs e)
        {
            Livres = new SqlBibliotheque();
            string Query = "Select * from Livre;";
            Livres.Command.CommandText = Query;
            Livres.Command.Connection = Livres.Connection;
            Livres.Adapter.SelectCommand = Livres.Command;
            Livres.Adapter.Fill(Livres.DsBibliotheque);
            Livres.DtLivre = Livres.DsBibliotheque.Tables[0];
            this.dataGridViewLivreCreation.DataSource = Livres.DtLivre;
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            if (VerificationTous())
            {
                DataRow UnLivre = Livres.DtLivre.NewRow();
                UnLivre[0] = txtIdLivre.Text.Trim();
                UnLivre[1] = txtTitre.Text.Trim();
                UnLivre[2] = txtAuteur.Text.Trim();
                UnLivre[3] = txtAnneParution.Text.Trim();
                Livres.DtLivre.Rows.Add(UnLivre);

                Livre liv = new Livre(txtIdLivre.Text,txtTitre.Text,txtAuteur.Text, int.Parse(txtAnneParution.Text), DateTime.Now,DateTime.Now);
                StaticListes.LsInventaire.Add(liv);
                MessageBox.Show("Le livre a été ajouté avec succès !", "Message");
                ViderChamps();
               
            }
        }

        private void btnModifierLivre_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Livres.DtLivre.Rows)
            {
                //Trouver la ligne qui correspond au numéro étudiant entré par l'utilisateur
                if (row[0].ToString() == txtIdLivre.Text)
                {
                    //Apporter toutes les modifications sur tous les champs de la ligne
                    row[0] = txtIdLivre.Text.Trim();
                    row[1] = txtTitre.Text.Trim();
                    row[2] = txtAuteur.Text.Trim();
                    row[3] = txtAnneParution.Text.Trim();
                }

            }
        }

        private void btnSupprimerLivre_Click(object sender, EventArgs e)
        {
            if (txtMdpAdmin.Text == "Admin")
            {
                foreach (DataRow row in Livres.DtLivre.Rows)
                {

                    if (row[0].ToString().Equals(txtIdLivre.Text.Trim()))
                        row.Delete();

                }

                foreach (Livre liv in StaticListes.LsInventaire)
                    if (liv.LivreID == txtIdLivre.Text)
                    {
                        StaticListes.LsInventaire.Remove(liv);

                        MessageBox.Show("L'employé a été supprimé avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("L'employé n'existe pas !", "Attention !");
                    }
            }
               
            else
            {
                MessageBox.Show("Mot de passe admin incorrect! Veuillez re-essayez", "Erreur, attention");
            }
        }

        private void btnSaveInventaire_Click(object sender, EventArgs e)
        {
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder       // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter. 
                SqlCommandBuilder builder = new SqlCommandBuilder(Livres.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.	
                Livres.Adapter.Update(Livres.DsBibliotheque, Livres.DtLivre.ToString());
                MessageBox.Show("L'inventaire a été sauvegarder avec succès !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int navigation = 0;
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (dataGridViewLivreCreation.Rows.Count > 0)
            {
                dataGridViewLivreCreation.ClearSelection();
                dataGridViewLivreCreation.Rows[navigation + 1].Selected = true;
                navigation++;
            }
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (navigation > 0)
            {
                dataGridViewLivreCreation.ClearSelection();
                dataGridViewLivreCreation.Rows[navigation - 1].Selected = true;
                navigation--;
            }
        }

       
    }
}
