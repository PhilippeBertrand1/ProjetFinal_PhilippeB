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
            if (txtMdpAdmin.Text == "Admin")
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
               
            }

            else
            {
                MessageBox.Show("Attention le mot de passe admin est incorrect, veuillez re-essayez");
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
    }
}
