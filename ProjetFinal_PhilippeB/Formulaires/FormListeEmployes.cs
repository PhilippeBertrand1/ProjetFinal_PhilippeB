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
    public partial class ListeEmployes : Form
    {
        
        public ListeEmployes()
        {
            InitializeComponent();
        }

        private void ListeEmployes_Load(object sender, EventArgs e)
        {
            foreach (Employe emps in StaticListes.LsEmployes)
                AfficherEmployeListView(emps);

            cbxRecherche.Items.Add("ID");
            cbxRecherche.Items.Add("Prénom");
            cbxRecherche.Items.Add("Nom");
            cbxRecherche.Items.Add("Sexe");

        }
        public char SexeButton(RadioButton rb1, RadioButton rb2)
        {
            //Si la radioButton 1 est coché le genre est féminin
            if (rb1.Checked == true) return 'H';
            else return 'F'; // Sinon il est masculin

        }
        public void AfficherEmployeListView(Employe emp) //On va chercher les attributs de la classe Etudiant pour créer le tableau
        {
            //Création d'un tableau pour l'affichage dans la listView
            string[] arr = new string[6];
            ListViewItem i;
            //Assignation de chaque attributs à un index du tableau
            arr[0] = emp.NumIdentifiant;
            arr[1] = emp.Prenom;
            arr[2] = emp.Nom;
            arr[3] = emp.NumTelephone;
            arr[4] = emp.Sexe.ToString();
            arr[5] = emp.TauxHoraire.ToString();
            i = new ListViewItem(arr);
            //Ajouter l'item dans la listView en question
            listViewEmp.Items.Add(i);
            lblResultat.Text = listViewEmp.Items.Count.ToString();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            listViewEmp.Items.Clear();
            bool resultat = false;

            if (cbxRecherche.Text == "ID")
                foreach (Employe emps in StaticListes.LsEmployes)
                {
                    if (emps.NumIdentifiant == txtRecherche.Text)
                    {
                        AfficherEmployeListView(emps);
                        resultat = true;
                    }
                }
            if (cbxRecherche.Text == "Prénom")
                foreach (Employe emps in StaticListes.LsEmployes)
                {
                    if (emps.Prenom == txtRecherche.Text)
                    {
                        AfficherEmployeListView(emps);
                        resultat = true;
                    }
                }
            if (cbxRecherche.Text == "Nom")
                foreach (Employe emps in StaticListes.LsEmployes)
                {
                    if (emps.Nom == txtRecherche.Text)
                    {
                        AfficherEmployeListView(emps);
                        resultat = true;
                    }
                }
            if (cbxRecherche.Text == "Sexe")
                foreach (Employe emps in StaticListes.LsEmployes)
                {
                    if (emps.Sexe.ToString() == txtRecherche.Text)
                    {
                        AfficherEmployeListView(emps);
                        resultat = true;
                    }
                }

            if (resultat == false)
                MessageBox.Show("Aucun employé trouvé avec la valeur donnée : " + "\n" + txtRecherche.Text, "Attention !");
        }
    }
}
