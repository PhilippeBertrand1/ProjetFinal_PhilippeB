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
        public bool VerifierRadioButton(RadioButton rb1, RadioButton rb2, Label lb)
        {
            //Si l'utilisateur a coché un genre  
            if (rb1.Checked || rb2.Checked) { lb.Text = ""; return true; }
            else // Sinon afficher un message d'erreur
            { lb.ForeColor = Color.Red; lb.Text = "Selectionnez un sexe"; return false; }
        }
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

        public char SexeButton(RadioButton rb1, RadioButton rb2)
        {
            //Si la radioButton 1 est coché le genre est féminin
            if (rb1.Checked == true) return 'H';
            else return 'F'; // Sinon il est masculin

        }

        private void btnCreerEmploye_Click(object sender, EventArgs e)
        {
            if (VerifierTous())
            {
                Employe emp = new Employe(txtIdentifiantEmploye.Text, txtPrenomEmploye.Text, txtNomEmploye.Text, txtTelEmploye.Text,
                    dateTimePickerEmploye.Value.Date, SexeButton(rbHomme, rbFemme), int.Parse(txtTauxHoraire.Text));
                StaticListes.LsEmployes.Add(emp);
                
                MessageBox.Show("L'employé a été ajouté avec succès.", "Bienvenue parmi nous !");
                SupprimerChamps();
            }      
           
        }

        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            if (VerifierTous())
            foreach (Employe emp in StaticListes.LsEmployes)
                    if(emp.NumIdentifiant == txtIdentifiantEmploye.Text)
                    {
                        StaticListes.LsEmployes.Remove(emp);
                        Employe NewEmp = new Employe(txtIdentifiantEmploye.Text, txtPrenomEmploye.Text, txtNomEmploye.Text, txtTelEmploye.Text, 
                            dateTimePickerEmploye.Value.Date, SexeButton(rbHomme, rbFemme), int.Parse(txtTauxHoraire.Text));
                        StaticListes.LsEmployes.Add(NewEmp);
                        SupprimerChamps();
                        MessageBox.Show("L'employé a été modifié avec succès." + "\n" + "Voici les informations modifiées :" + "\n" + NewEmp.Nom + "\n" +
                        NewEmp.Prenom + "\n" + NewEmp.DateNaissance + "\n" + NewEmp.NumTelephone + "\n" + NewEmp.TauxHoraire + "\n" + NewEmp.Sexe);

                    }
        }

        private void btnSupprimerEmploye_Click(object sender, EventArgs e)
        {
            if (txtMdpAdmin2.Text == "Admin")
                foreach (Employe emp in StaticListes.LsEmployes)
                if (emp.NumIdentifiant == txtIdentifiantEmploye.Text)
                {
                    StaticListes.LsEmployes.Remove(emp);
                    SupprimerChamps();
                    MessageBox.Show("L'employé a été supprimé avec succès." + "\n" + "Voici les informations supprimées :" + "\n" + emp.Nom + "\n" +
                        emp.Prenom + "\n" + emp.DateNaissance + "\n" + emp.NumTelephone + "\n" + emp.TauxHoraire + "\n" + emp.Sexe, "Message");
                }
                else
                {
                    MessageBox.Show("L'employé n'existe pas !", "Attention !");
                }
            else
            {
                MessageBox.Show("Mot de passe admin incorrect! Veuillez re-essayez", "Erreur, attention");
            }
        }

      

        
        
    }
}
