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
        SqlClient Livre;
        public AjouterSupprimerModifierLivres()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AjouterSupprimerModifierLivres_Load(object sender, EventArgs e)
        {
            Livre = new SqlClient();
            string Query = "Select * from Livre;";
            Livre.Command.CommandText = Query;
            Livre.Command.Connection = Livre.Connection;
            Livre.Adapter.SelectCommand = Livre.Command;
            Livre.Adapter.Fill(Livre.DsBibliotheque);
            Livre.DtLivre = Livre.DsBibliotheque.Tables[0];
            this.dataGridViewLivreCreation.DataSource = Livre.DtLivre;
        }

        private void btnAjouterLivre_Click(object sender, EventArgs e)
        {
            if (txtMdpAdmin.Text == "Admin")
            {
                DataRow UnLivre = Livre.DtLivre.NewRow();
                UnLivre[0] = txtIdLivre.Text.Trim();
                UnLivre[1] = txtTitre.Text.Trim();
                UnLivre[2] = txtAuteur.Text.Trim();
                UnLivre[3] = txtAnneParution.Text.Trim();
                Livre.DtLivre.Rows.Add(UnLivre);
            }

            else
            {
                MessageBox.Show("Attention le mot de passe admin est incorrect, veuillez re-essayez");
            }

        }

        private void btnModifierLivre_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in Livre.DtLivre.Rows)
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
            foreach (DataRow row in Livre.DtLivre.Rows)
            {
                
                if (row[0].ToString().Equals(txtIdLivre.Text.Trim()))
                    row.Delete();
              
            }
        }

        private void btnSaveInventaire_Click(object sender, EventArgs e)
        {
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder       // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter. 
                SqlCommandBuilder builder = new SqlCommandBuilder(Livre.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.	
                Livre.Adapter.Update(Livre.DsBibliotheque, Livre.DtLivre.ToString());
                MessageBox.Show("L'inventaire a été sauvegarder avec succès !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
