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
    public partial class CreationClient : Form
    {
        SqlBibliotheque Clients;
        public CreationClient()
        {
            InitializeComponent();
        }
        private void CreationClient_Load(object sender, EventArgs e)
        {
            Clients = new SqlBibliotheque();
            string Query = "Select * from Client;";           
            Clients.Command.CommandText = Query;          
            Clients.Command.Connection = Clients.Connection;
            Clients.Adapter.SelectCommand = Clients.Command;
            Clients.Adapter.Fill(Clients.DsBibliotheque);
            Clients.DtClient = Clients.DsBibliotheque.Tables[0];
            this.dataGridViewClients.DataSource = Clients.DtClient;
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
        public char SexeButton(RadioButton rb1, RadioButton rb2)
        {
            //Si la radioButton 1 est coché le genre est féminin
            if (rb1.Checked == true) return 'H';
            else return 'F'; // Sinon il est masculin

        }
        public bool VerifierRadioButton(RadioButton rb1, RadioButton rb2, Label lb)
        {
            //Si l'utilisateur a coché un genre  
            if (rb1.Checked || rb2.Checked) { lb.Text = ""; return true; }
            else // Sinon afficher un message d'erreur
            { lb.ForeColor = Color.Red; lb.Text = "Selectionnez un sexe"; return false; }
        }

        public void SupprimerChamps()
        {
            txtIdentifiantClient.Text = "";
            txtPrenomClient.Text = "";
            txtNomClient.Text = "";
            txtTelClient.Text = "";
            txtAdresseClient.Text = "";
            rbHommeClient.Checked = false;
            rbFemmeClient.Checked = false;
        }
        public bool VerifierTous()
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_id, b_nom, b_prenom, b_telephone, b_sexe;
            //Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_id = VerifierRegex("^[0-9]{5}$", txtIdentifiantClient, lblErreurIDClient, "5 chiffres entre 0 et 9 obligatoire");
            b_nom = VerifierRegex("^[A-Z]{1}[a-z]{3,20}$", txtNomClient, lblErreurNomClient, "Lettre majuscule suivie de 3 à 20 lettres minuscules");
            b_prenom = VerifierRegex("^[A-Z]{1}[a-z]{3,20}$", txtPrenomClient, lblErreurPrenomClient, "Lettre majuscule suivie de 3 à 20 lettres minuscules");
            b_telephone = VerifierRegex(@"(^\d{3}\-\d{3}\-\d{4})$", txtTelClient, lblErreurTelClient, "Veuillez écrire votre numéro de cette manière --> ccc-ccc-cccc");
           

            //Vérifier que l'une des deux radioButton est cochée
            b_sexe = VerifierRadioButton(rbHommeClient, rbFemmeClient, lblErreurSexeClients);
            // Si toutes les vérifications sont valides retourner vrai
            if (b_id && b_nom && b_prenom && b_telephone && b_sexe)
                return true;
            else return false; //Sinon retourner faux
        }
        private void btnCreerClient_Click(object sender, EventArgs e)
        {
            if (VerifierTous())
            {
                DataRow UnClient = Clients.DtClient.NewRow();
                UnClient[0] = txtIdentifiantClient.Text.Trim();
                UnClient[1] = txtPrenomClient.Text.Trim();
                UnClient[2] = txtNomClient.Text.Trim();
                UnClient[3] = txtTelClient.Text.Trim();
                UnClient[4] = SexeButton(rbHommeClient, rbFemmeClient);
                UnClient[5] = txtAdresseClient.Text.Trim();
                Clients.DtClient.Rows.Add(UnClient);
                    
                Client client = new Client(txtIdentifiantClient.Text, txtPrenomClient.Text, txtNomClient.Text, txtTelClient.Text,
                    dateTimePickerClient.Value.Date, SexeButton(rbHommeClient, rbFemmeClient), txtAdresseClient.Text);
                StaticListes.LsClients.Add(client);

                MessageBox.Show("Vous êtes maintenant inscrit à la bibliothèque.", "Félicitations !");

                SupprimerChamps();

            }
                
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (txtMdpAdmin.Text == "Admin")
            {
                foreach (DataRow row in Clients.DtClient.Rows)
                {

                    if (row[0].ToString().Equals(txtIdentifiantClient.Text.Trim()))
                        row.Delete();

                }

                foreach (Client client in StaticListes.LsClients)
                    
                    if (client.NumIdentifiant == txtIdentifiantClient.Text)
                    {
                        StaticListes.LsClients.Remove(client);

                        MessageBox.Show("Le client a été supprimé avec succès.");
                    }
                    else
                    {
                        MessageBox.Show("Le client n'existe pas !", "Attention !");
                    }
            }

            else
            {
                MessageBox.Show("Mot de passe admin incorrect! Veuillez re-essayez", "Erreur, attention");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder       // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter. 
                SqlCommandBuilder builder = new SqlCommandBuilder(Clients.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.	
                Clients.Adapter.Update(Clients.DsBibliotheque, Clients.DtClient.ToString());
                MessageBox.Show("Les clients ont été sauvegarder avec succès !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (VerifierTous())
            {
                foreach (DataRow row in Clients.DtClient.Rows)
                {
                    if (row[0].ToString() == txtIdentifiantClient.Text)
                    {
                        row[0] = txtIdentifiantClient.Text.Trim();
                        row[1] = txtPrenomClient.Text.Trim();
                        row[2] = txtNomClient.Text.Trim();
                        row[3] = txtTelClient.Text.Trim();
                        row[4] = SexeButton(rbFemmeClient, rbHommeClient);
                        row[5] = txtAdresseClient.Text.Trim();

                        MessageBox.Show("Le client a été modifié avec succès");
                    }
                    else
                    {
                        MessageBox.Show("L'utilisateur n'existe pas !", "Attention !");
                    }
                }
                
                /*foreach (Client clients in StaticListes.LsClients)

                  if (clients.NumIdentifiant == txtIdentifiantClient.Text)
                    {
                        StaticListes.LsClients.Remove(clients);
                        Client cli = new Client(txtIdentifiantClient.Text, txtPrenomClient.Text, txtNomClient.Text, txtTelClient.Text,
                        dateTimePickerClient.Value.Date, SexeButton(rbHommeClient, rbFemmeClient), txtAdresseClient.Text);
                        StaticListes.LsClients.Add(cli);
                        SupprimerChamps();
                    }*/
            }
            
        }
    }
}
