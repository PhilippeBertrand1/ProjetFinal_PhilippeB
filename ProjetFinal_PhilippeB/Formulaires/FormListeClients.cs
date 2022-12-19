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
    public partial class ListeClients : Form
    {
        SqlBibliotheque Clients;
        public ListeClients()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Au chargement de la page,on instancie un nouvel object (SqlBibliotheque) on va chercher les données de la table client dans la base de données (Bibliotheque).
        /// Ensuite, on alimente le dataGridView avec les données récupérées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeClients_Load(object sender, EventArgs e)
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
        /// Bouton qui sélectionne tous les clients dans l'ordre croissant selon l'id du client grâce à une requête Sql sur la table Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCroissant_Click(object sender, EventArgs e)
        {
            
            string OrdreCroissant = "Select * from Client order by ID;";
            Clients.Command.CommandText = OrdreCroissant;
            Clients.Command.Connection = Clients.Connection;
            Clients.Adapter.SelectCommand = Clients.Command;
            Clients.Adapter.Fill(Clients.DsBibliotheque);
            Clients.DtClient = Clients.DsBibliotheque.Tables[0];
            this.dataGridViewClients.DataSource = Clients.DtClient;
        }
        /// <summary>
        /// Bouton qui sélectionne tous les clients dans l'ordre décroissant selon l'id du client grâce à une requête Sql sur la table Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecroissant_Click(object sender, EventArgs e)
        {
            string OrdreDecroissant = "Select * from Client order by ID desc;";
            Clients.Command.CommandText = OrdreDecroissant;
            Clients.Command.Connection = Clients.Connection;
            Clients.Adapter.SelectCommand = Clients.Command;
            Clients.Adapter.Fill(Clients.DsBibliotheque);
            Clients.DtClient = Clients.DsBibliotheque.Tables[0];
            this.dataGridViewClients.DataSource = Clients.DtClient;
        }
        /// <summary>
        /// Bouton qui sélectionne tous les clients du sexe masculin grâce à une requête Sql sur la table Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHomme_Click(object sender, EventArgs e)
        {
            string Homme = "Select * from Client where sexe = 'H' order by ID;";
            Clients.Command.CommandText = Homme;
            Clients.Command.Connection = Clients.Connection;
            Clients.Adapter.SelectCommand = Clients.Command;
            Clients.Adapter.Fill(Clients.DsBibliotheque);
            Clients.DtClient = Clients.DsBibliotheque.Tables[0];
            this.dataGridViewClients.DataSource = Clients.DtClient;
        }

        /// <summary>
        /// Bouton qui sélectionne tous les clients du sexe féminin grâce à une requête Sql sur la table Client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFemme_Click(object sender, EventArgs e)
        {
            string Femme = "Select * from Client where sexe = 'F' order by ID;";
            Clients.Command.CommandText = Femme;
            Clients.Command.Connection = Clients.Connection;
            Clients.Adapter.SelectCommand = Clients.Command;
            Clients.Adapter.Fill(Clients.DsBibliotheque);
            Clients.DtClient = Clients.DsBibliotheque.Tables[0];
            this.dataGridViewClients.DataSource = Clients.DtClient;
        }
    }
}
