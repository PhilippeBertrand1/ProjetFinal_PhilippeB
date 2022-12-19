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
using System.Text.RegularExpressions; // Ajout des expressions régulières 


namespace ProjetFinal_PhilippeB
{
    public partial class CreationClient : Form
    {
        SqlBibliotheque Clients;
        public CreationClient()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Au chargement de la page,on instancie un nouvel object (SqlBibliotheque) on va chercher les données de la table client dans la base de données (Bibliotheque).
        /// Ensuite, on alimente le dataGridView avec les données récupérées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            //Si le regex n'est pas accepté
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
        /// Méthode de type char qui renvoie un charactère soit 'H' ou 'F' qui correspond à Homme ou Femme
        /// </summary>
        /// <param name="rb1"></param> Définie un bouton radio et renvoie la valeur H ou F
        /// <param name="rb2"></param> Définie un second bouton radio et renvoie la valeur H ou F
        /// <returns></returns>
        public char SexeButton(RadioButton rb1, RadioButton rb2)
        {
            //Si la radioButton 1 est coché le genre est Masculin
            if (rb1.Checked == true) return 'H';
            else return 'F'; // Sinon il est féminin

        }
        /// <summary>
        /// Méthode booléenne qui vérifie si l'utilisateur à bien coché l'un des deux bouton radio
        /// Sinon, on affiche un message d'erreur
        /// *Bout de code pris et modifié de l'exercise GestElection de Hasna Hocini*
        /// </summary>
        /// <param name="rb1"></param> Représente un bouton radio
        /// <param name="rb2"></param> Représente un second bouton radio
        /// <param name="lb"></param> Représente un label qui contient le message d'erreur
        /// <returns></returns>
        public bool VerifierRadioButton(RadioButton rb1, RadioButton rb2, Label lb)
        {
            //Si l'utilisateur a coché un sexe 
            if (rb1.Checked || rb2.Checked) { lb.Text = ""; return true; }
            else // Sinon afficher un message d'erreur
            { lb.ForeColor = Color.Red; lb.Text = "Selectionnez un sexe"; return false; }
        }

        /// <summary>
        /// Méthode qui fait simplement vider tous les champs de la page
        /// </summary>
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
        /// <summary>
        /// Méthode booléene qui va être demandé à chaque ajout d'un client
        /// Si toutes la validations sont acceptées, on laisse ajouter le nouveau client, sinon une erreur s'affiche selon la validation non-conforme
        /// *Bout de code pris, modifié et adapter de l'exercice "GestElection" par Hasna Hocini*
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Bouton qui ajoute un client dans la base de données, il ne faut pas oublier de sauvegarder les modifications 
        /// pour que le client reste dans la base de données, sinon il est supprimé lors de la fermuture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerClient_Click(object sender, EventArgs e)
        {
            //Appel de la fonction des Regex pour valider les données entrées
            if (VerifierTous())
            {
                // Ajouter le client dans le dataGridView
                DataRow UnClient = Clients.DtClient.NewRow();
                UnClient[0] = txtIdentifiantClient.Text.Trim();
                UnClient[1] = txtPrenomClient.Text.Trim();
                UnClient[2] = txtNomClient.Text.Trim();
                UnClient[3] = txtTelClient.Text.Trim();
                UnClient[4] = SexeButton(rbHommeClient, rbFemmeClient);
                UnClient[5] = txtAdresseClient.Text.Trim();
                Clients.DtClient.Rows.Add(UnClient);
                    
                // Ajouter le client également dans la liste lsClients

                Client client = new Client(txtIdentifiantClient.Text, txtPrenomClient.Text, txtNomClient.Text, txtTelClient.Text,
                    dateTimePickerClient.Value.Date, SexeButton(rbHommeClient, rbFemmeClient), txtAdresseClient.Text);
                StaticListes.LsClients.Add(client);

                // Afficher un message afin d'informer la confirmation de l'ajout d'un client

                MessageBox.Show("Vous êtes maintenant inscrit à la bibliothèque.", "Félicitations !");

                // Appel de la fonction pour supprimer les champs après l'ajout

                SupprimerChamps();

            }
                
        }
        /// <summary>
        /// Bouton qui supprime un client selon l'identifiant entré. Il ne faut pas oublier de sauvegarder les modifications 
        /// pour que le client soit retiré de la base de données, sinon il demeure dans la table lors de la fermuture de l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //Si le textBox en question est égal à Admin

            if (txtMdpAdmin.Text == "Admin")
            {
                // On parcours la table Clients
                foreach (DataRow row in Clients.DtClient.Rows)
                {
                //Si dans la table on trouve le ID qui correspond à celui donné dans le textbox, on le supprime
                    if (row[0].ToString().Equals(txtIdentifiantClient.Text.Trim()))
                        row.Delete();

                }

                // On parcours également la liste des clients pour supprimer le client de la liste
                foreach (Client client in StaticListes.LsClients)
                    
                    if (client.NumIdentifiant == txtIdentifiantClient.Text)
                    {
                        StaticListes.LsClients.Remove(client);

                        // Message pour confirmer la suppression du client
                        MessageBox.Show("Le client a été supprimé avec succès.");
                    }
                    else
                    {
                        // Message pour avertir que le client est introuvable
                        MessageBox.Show("Le client n'existe pas !", "Attention !");
                    }
            }

            else
            {
                MessageBox.Show("Mot de passe admin incorrect! Veuillez re-essayez", "Erreur, attention");
            }
        }
        /// <summary>
        /// Bouton qui permet la sauvegarde de la table Client
        /// Code pris et modifier de l'exercise : Labo mode déconnecté
        /// De: Hasna Hocini
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Bouton qui permet la modification d'un client dans la table Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Appel de la méthode des Regex qui valide les champs remplis par l'utilisateur

            if (VerifierTous())
            {
                // On parcourt la table des clients
                foreach (DataRow row in Clients.DtClient.Rows)
                {
                    // Si l'id est trouvé, on autorise la modification du client en question
                    if (row[0].ToString() == txtIdentifiantClient.Text)
                    {
                        row[0] = txtIdentifiantClient.Text.Trim();
                        row[1] = txtPrenomClient.Text.Trim();
                        row[2] = txtNomClient.Text.Trim();
                        row[3] = txtTelClient.Text.Trim();
                        row[4] = SexeButton(rbFemmeClient, rbHommeClient);
                        row[5] = txtAdresseClient.Text.Trim();

                        // Message pour informer la modification du client
                        MessageBox.Show("Le client a été modifié avec succès");
                    }
                    else
                    {
                        // Message pour informer que l'utilisateur n'existe pas dans la table
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
