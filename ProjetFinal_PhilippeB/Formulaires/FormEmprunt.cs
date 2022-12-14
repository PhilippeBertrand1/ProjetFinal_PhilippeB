using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetFinal_PhilippeB
{
    public partial class EmpruntLivre : Form
    {
        SqlBibliotheque Livres;
        public EmpruntLivre()
        {
            InitializeComponent();
        }

        private void listViewEmprunt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmpruntLivre_Load(object sender, EventArgs e)
        {
            Livres = new SqlBibliotheque();
            string Query = "Select * from Livre;";
            Livres.Command.CommandText = Query;
            Livres.Command.Connection = Livres.Connection;
            Livres.Adapter.SelectCommand = Livres.Command;
            Livres.Adapter.Fill(Livres.DsBibliotheque);
            Livres.DtLivre = Livres.DsBibliotheque.Tables[0];
            this.dataGridViewLivre.DataSource = Livres.DtLivre;
        }

        private void dataGridViewLivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEmprunter_Click(object sender, EventArgs e)
        {
            foreach(Livre liv in StaticListes.LsInventaire)
                if (liv.LivreID == txtIdEmprunt.Text)
                {
                    foreach (Client client in StaticListes.LsClients)
                        if (client.NumIdentifiant == txtIdEmprunt.Text)
                        {
                            StaticListes.LsInventaire.Remove(liv);
                            StaticListes.LsLivresEmpruntes.Add(liv);

                            MessageBox.Show("Le livre sélectionné est à vous !", "Bonne lecture");
                        }
                }
        }
    }
}
