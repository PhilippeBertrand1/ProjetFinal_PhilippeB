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
    public partial class AjouterSupprimerModifierEmployes : Form
    {

        List<Employe> lsEmployes = new List<Employe>();

        public AjouterSupprimerModifierEmployes()
        {
            InitializeComponent();
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
            if (txtMdpAdmin2.Text == "Admin")
            {
                Employe emp = new Employe(txtIdentifiantEmploye.Text, txtPrenomEmploye.Text, txtNomEmploye.Text, txtTelEmploye.Text, 
                    dateTimePickerEmploye.Value.Date, SexeButton(rbHomme, rbFemme), int.Parse(txtTauxHoraire.Text));
                StaticListes.LsEmployes.Add(emp);
                MessageBox.Show("L'employé a été ajouté avec succès.", "Bienvenue parmi nous !");
                SupprimerChamps();
            }
            else
            {
                MessageBox.Show("Mot de passe admin incorrect ! Veuillez re-essayez", "Erreur, attention");
            }
        }

        private void btnModifierEmploye_Click(object sender, EventArgs e)
        {
            if (txtMdpAdmin2.Text == "Admin")
            foreach (Employe emp in StaticListes.LsEmployes)
                    if(emp.NumIdentifiant == txtIdentifiantEmploye.Text)
                    {
                        StaticListes.LsEmployes.Remove(emp);
                        Employe NewEmp = new Employe(txtIdentifiantEmploye.Text, txtPrenomEmploye.Text, txtNomEmploye.Text, txtTelEmploye.Text, 
                            dateTimePickerEmploye.Value.Date, SexeButton(rbHomme, rbFemme), int.Parse(txtTauxHoraire.Text));
                        StaticListes.LsEmployes.Add(NewEmp);
                        SupprimerChamps();
                        MessageBox.Show("L'employé a été modifié avec succès." + "\n" + "Voici les informations modifiées :" + "\n" + NewEmp.NumIdentifiant + "\n" + NewEmp.Nom + "\n" +
                        NewEmp.Prenom + "\n" + NewEmp.DateNaissance + "\n" + NewEmp.NumTelephone + "\n" + NewEmp.TauxHoraire + "\n" + NewEmp.Sexe);

                    }
            else
                    {
                        MessageBox.Show("Mot de passe admin incorrect! Veuillez re - essayez", "Erreur, attention");
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
                    MessageBox.Show("L'employé a été supprimé avec succès." + "\n" + "Voici les informations supprimées :" + "\n" + emp.NumIdentifiant + "\n" + emp.Nom + "\n" +
                        emp.Prenom + "\n" + emp.DateNaissance + "\n" + emp.NumTelephone + "\n" + emp.TauxHoraire + "\n" + emp.Sexe, "Message");
                }
                else
                {
                    MessageBox.Show("L'employé n'existe pas !", "Attention !");
                }
            else
            {
                MessageBox.Show("Mot de passe admin incorrect! Veuillez re - essayez", "Erreur, attention");
            }
        }
    }
}
