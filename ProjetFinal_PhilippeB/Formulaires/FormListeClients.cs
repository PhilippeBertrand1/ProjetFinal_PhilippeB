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
