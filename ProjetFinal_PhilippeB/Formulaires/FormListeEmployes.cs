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

        /// <summary>
        /// Lors du chargement du formulaire, on alimente le comboBox avec des attributs que chaque employé possède
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeEmployes_Load(object sender, EventArgs e)
        {
            // On parcours la liste des employés pour ensuite les afficher
            // dans la listView grâce à la fonction "AfficherEmployeListView"
            foreach (Employe emps in StaticListes.LsEmployes)
                AfficherEmployeListView(emps);

            cbxRecherche.Items.Add("ID");
            cbxRecherche.Items.Add("Prénom");
            cbxRecherche.Items.Add("Nom");
            cbxRecherche.Items.Add("Sexe");

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
        /// Méthode d'affichage en tableau pour les employés dans la listView
        /// Chaque index du tableau représente un attribut de l'employé
        /// **Bout de code tiré de l'exercice GestElection de Hasna Hocini**
        /// </summary>
        /// <param name="emp"></param>
        public void AfficherEmployeListView(Employe emp) //On va chercher les attributs de la classe Employe pour créer le tableau
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
            // Label qui affiche le nombre de résultat de recherche trouvé
            lblResultat.Text = listViewEmp.Items.Count.ToString();
        }

        /// <summary>
        /// Bouton qui fonctionne comme un moteur de recherche :
        /// - On sélectionne l'attribut qu'on souhaite rechercher grâce au comboBox
        /// - On entre la valeur recherché dans le textBox 
        /// - En appuyant sur le bouton, les résultats de recherche s'affiche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                // Message qui informe qu'aucun employé à été trouvé
                MessageBox.Show("Aucun employé trouvé avec la valeur donnée : " + "\n" + txtRecherche.Text, "Attention !");
        }
    }
}
