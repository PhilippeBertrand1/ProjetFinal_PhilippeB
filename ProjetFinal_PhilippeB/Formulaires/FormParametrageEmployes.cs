using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetFinal_PhilippeB
{
    public partial class AjouterSupprimerModifierEmployes : Form
    {
        List<Employe> LsEmployes = new List<Employe>();
          
        public AjouterSupprimerModifierEmployes()
        {
            InitializeComponent();
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
                //Effacer la TextBox 
                txt.Clear();
                return false;
            }
            else lbl.Text = ""; //Effacer le label si le champ entré est valide
            return true;
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
            //Si l'utilisateur a coché un genre  
            if (rb1.Checked || rb2.Checked) { lb.Text = ""; return true; }
            else // Sinon afficher un message d'erreur
            { lb.ForeColor = Color.Red; lb.Text = "Selectionnez un sexe"; return false; }
        }
        /// <summary>
        /// Méthode booléene qui va être demandé à chaque ajout d'un employé
        /// Si toutes la validations sont acceptées, on laisse ajouter le nouveau employé, sinon une erreur s'affiche selon la validation non-conforme
        /// *Bout de code pris, modifié et adapter de l'exercice "GestElection" par Hasna Hocini*
        /// </summary>
        /// <returns></returns>
        public bool VerifierTous()
        {
            //Déclaration des booléens de validation des informations entrées
            bool b_id, b_nom, b_prenom, b_telephone, b_tauxhoraire, b_admin, b_sexe;
            //Appel de la méthode VerifierRegex pour tous les champs et récupération des valeurs retournées dans les variables bouléennes
            b_id = VerifierRegex("^[0-9]{3}$", txtIdentifiantEmploye, lblErreurID, "3 chiffres entre 0 et 9 obligatoire");
            b_nom = VerifierRegex("^[A-Z]{1}[a-z]{3,20}$", txtNomEmploye, lblErreurNomEmp, "Lettre majuscule suivie de 3 à 20 lettres minuscules");
            b_prenom = VerifierRegex("^[A-Z]{1}[a-z]{3,20}$", txtPrenomEmploye, lblErreurPrenomEmp, "Lettre majuscule suivie de 3 à 20 lettres minuscules");
            b_admin = VerifierRegex("Admin", txtMdpAdmin2, lblErreurMdpAdminEmp, "Mot de passe admin incorrect");
            b_telephone = VerifierRegex(@"(^\d{3}\-\d{3}\-\d{4})$", txtTelEmploye, lblErreurTelEmp, "Veuillez écrire votre numéro de cette manière --> ccc-ccc-cccc");
            b_tauxhoraire = VerifierRegex("^[0-9]{1,3}$", txtTauxHoraire, lblErreurTauxHoraire, "Taux horaire incorrect, veuillez entrer une valeur numérique, (Maximum 3 chiffres)");
          
            
            //Vérifier que l'une des deux radioButton est cochée
            b_sexe = VerifierRadioButton(rbHomme, rbFemme, lblErreurSexeEmp);
            // Si toutes les vérifications sont valides retourner vrai
            if (b_id && b_nom && b_prenom && b_telephone && b_admin && b_sexe && b_tauxhoraire)
                return true;
            else return false; //Sinon retourner faux
        }
        /// <summary>
        /// Méthode qui vide tous les champs du formulaire
        /// </summary>
        public void SupprimerChamps()
        {
            txtIdentifiantEmploye.Text = "";
            txtMdpAdmin2.Text = "";
            txtNomEmploye.Text = "";
            txtPrenomEmploye.Text = "";
            txtTauxHoraire.Text = "0";
            txtTelEmploye.Text = "";
            dateTimePickerEmploye.Value = DateTime.Now;
            rbFemme.Checked = false;
            rbHomme.Checked = false;
        }
        /// <summary>
        /// Méthode de type char qui renvoie un charactère soit 'H' ou 'F' qui correspond à Homme ou Femme
        /// </summary>
        /// <param name="rb1"></param> Définie un bouton radio et renvoie la valeur H ou F
        /// <param name="rb2"></param> Définie un second bouton radio et renvoie la valeur H ou F
        /// <returns></returns>
        public char SexeButton(RadioButton rb1, RadioButton rb2)
        {
            //Si la radioButton 1 est coché le genre est masculin
            if (rb1.Checked == true) return 'H';
            else return 'F'; // Sinon il est féminin

        }
        /// <summary>
        /// Bouton qui ajoute un employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerEmploye_Click(object sender, EventArgs e)
        {
            //Appel de la fonction des Regex pour valider les données entrées
            if (VerifierTous())
            {
                // Ajouter l'employé dans la liste lsEmployes
                Employe emp = new Employe(txtIdentifiantEmploye.Text, txtPrenomEmploye.Text, txtNomEmploye.Text, txtTelEmploye.Text,
                    dateTimePickerEmploye.Value.Date, SexeButton(rbHomme, rbFemme), int.Parse(txtTauxHoraire.Text));
                StaticListes.LsEmployes.Add(emp);
                
                // Message qui informe la confirmation de l'ajout de l'employé
                MessageBox.Show("L'employé a été ajouté avec succès.", "Bienvenue parmi nous !");
                
                // On supprime tous les champs suite à l'ajout
                SupprimerChamps();
            }      
           
        }
        /// <summary>
        /// Bouton qui permet la modification d'un employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            //Appel de la fonction des Regex pour valider les données entrées
            if (VerifierTous())
            foreach (Employe emp in StaticListes.LsEmployes)
                    if(emp.NumIdentifiant == txtIdentifiantEmploye.Text)
                    {
                        StaticListes.LsEmployes.Remove(emp);
                        Employe NewEmp = new Employe(txtIdentifiantEmploye.Text, txtPrenomEmploye.Text, txtNomEmploye.Text, txtTelEmploye.Text, 
                            dateTimePickerEmploye.Value.Date, SexeButton(rbHomme, rbFemme), int.Parse(txtTauxHoraire.Text));
                        StaticListes.LsEmployes.Add(NewEmp);
                        SupprimerChamps();
                        
                        // Afficher à l'utilisateur toutes les nouvelles informations de l'employé

                        MessageBox.Show("L'employé a été modifié avec succès." + "\n" + "Voici les informations modifiées :" + "\n" + NewEmp.Nom + "\n" +
                        NewEmp.Prenom + "\n" + NewEmp.DateNaissance + "\n" + NewEmp.NumTelephone + "\n" + NewEmp.TauxHoraire + "\n" + NewEmp.Sexe);

                    }
        }
        /// <summary>
        /// Bouton qui supprime un employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerEmploye_Click(object sender, EventArgs e)
        {
            //Si la valeur du champ en question est égal à admin, on continue le code
            if (txtMdpAdmin2.Text == "Admin")
                foreach (Employe emp in StaticListes.LsEmployes)
                if (emp.NumIdentifiant == txtIdentifiantEmploye.Text)
                {
                    StaticListes.LsEmployes.Remove(emp);
                    SupprimerChamps();

                    //Message qui montre les informations de l'employé supprimé
                    MessageBox.Show("L'employé a été supprimé avec succès." + "\n" + "Voici les informations supprimées :" + "\n" + emp.Nom + "\n" +
                        emp.Prenom + "\n" + emp.DateNaissance + "\n" + emp.NumTelephone + "\n" + emp.TauxHoraire + "\n" + emp.Sexe, "Message");
                }
                else
                {
                    //Message qui informe d'une erreur rencontrée
                    MessageBox.Show("L'employé n'existe pas !", "Attention !");
                }
            else
            {
                // Message qui informe une erreur pour le mot de passe admin
                MessageBox.Show("Mot de passe admin incorrect! Veuillez re-essayez", "Erreur, attention");
            }
        }

      

        
        
    }
}
