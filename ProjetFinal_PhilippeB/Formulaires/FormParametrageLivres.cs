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

        /// <summary>
        /// Méthode pour vider tous les champs du formulaire
        /// </summary>        
        public void ViderChamps()
        {
            txtTitre.Text = "";
            txtIdLivre.Text = "";
            txtAnneParution.Text = "";
            txtAuteur.Text = "";
            txtMdpAdmin.Text = "";

        }
        /// <summary>
        /// Méthode vérifie si la valeur donnée est conforme à l'expression régulière attribuée
        /// La méthode demande 4 paramètres, ces paramètres on chacun un fonctionnement précis:
        /// *Bout de code pris et modifié de l'exercise GestElection de Hasna Hocini*
        /// </summary>
        /// <param name="modele"></param> L'expression régulière voulue
        /// <param name="txt"></param> Le text box à analyser
        /// <param name="lbl"></param> Un label qui va afficher un message d'erreur
        /// <param name="messageErreur"></param> La chaine de caractère du message d'erreur
        /// <returns></returns>  
        public bool VerifierRegex(string modele, TextBox txt, Label lbl, string messageErreur) //Paramètres voulus lorsqu'on appelle la fonction
        {
            //Création du Regex reg 
            Regex reg = new Regex(modele);

            if (!reg.IsMatch(txt.Text))
            {
                //Afficher un message d'erreur
                lbl.ForeColor = Color.Red;
                lbl.Text = messageErreur;
                //Effacer la TextBox en question
                txt.Clear();
                return false;
            }
            else lbl.Text = ""; //Effacer le label si le champ entré est valide
            return true;
        }
        /// <summary>
        /// Méthode booléene qui va être demandé à chaque ajout d'un livre
        /// Si toutes la validations sont acceptées, on laisse ajouter le nouveau livre, sinon une erreur s'affiche selon la validation non-conforme
        /// *Bout de code pris, modifié et adapter de l'exercice "GestElection" par Hasna Hocini*
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Au chargement de la page,on instancie un nouvel object (SqlBibliotheque) on va chercher les données de la table Livre dans la base de données (Bibliotheque).
        /// Ensuite, on alimente le dataGridView avec les données récupérées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Bouton qui ajoute un livre dans la base de données, il ne faut pas oublier de sauvegarder les modifications 
        /// pour que le livre reste dans la base de données, sinon il est supprimé lors de la fermuture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            //Appel de la fonction des Regex pour valider les données entrées
            if (VerificationTous())
            {
                // Ajouter le livre dans le dataGridView
                DataRow UnLivre = Livres.DtLivre.NewRow();
                UnLivre[0] = txtIdLivre.Text.Trim();
                UnLivre[1] = txtTitre.Text.Trim();
                UnLivre[2] = txtAuteur.Text.Trim();
                UnLivre[3] = txtAnneParution.Text.Trim();
                Livres.DtLivre.Rows.Add(UnLivre);

                // Ajouter le livre également dans la liste lsInventaire
                Livre liv = new Livre(txtIdLivre.Text,txtTitre.Text,txtAuteur.Text, int.Parse(txtAnneParution.Text), DateTime.Now,DateTime.Now);
                StaticListes.LsInventaire.Add(liv);
                // Afficher un message afin d'informer la confirmation de l'ajout d'un livre
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
        /// <summary>
        /// Bouton qui supprime un livre selon l'identifiant entré. Il ne faut pas oublier de sauvegarder les modifications 
        /// pour que le livre soit retiré de la base de données, sinon il demeure dans la table lors de la fermuture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerLivre_Click(object sender, EventArgs e)
        {
            //Si le textBox en question est égal à Admin
            if (txtMdpAdmin.Text == "Admin")
            {
                // On parcous la table Livre
                foreach (DataRow row in Livres.DtLivre.Rows)
                {
                //Si dans la table on trouve le ID qui correspond à celui donné dans le textbox, on le supprime
                    if (row[0].ToString().Equals(txtIdLivre.Text.Trim()))
                        row.Delete();

                }
                // On parcours également la liste de l'inventaire pour supprimer le livre de la liste
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
        /// <summary>
        /// Bouton qui permet la sauvegarde de la table Livre
        /// Code pris et modifier de l'exercise : Labo mode déconnecté
        /// De: Hasna Hocini
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        // Déclaration d'une variable navigation
        int navigation = 0;
        /// <summary>
        /// Bouton qui sélectionne la ligne suivante de la table
        /// ** Code inspiré de Labo déconnecté par Hasna Hocini
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (dataGridViewLivreCreation.Rows.Count > 0)
            {
                dataGridViewLivreCreation.ClearSelection();
                dataGridViewLivreCreation.Rows[navigation + 1].Selected = true;
                navigation++;
            }
        }
        /// <summary>
        /// Bouton qui sélectionne la ligne précédente de la table
        /// ** Code inspiré de Labo déconnecté par Hasna Hocini
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
