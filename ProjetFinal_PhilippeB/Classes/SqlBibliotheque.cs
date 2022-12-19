using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProjetFinal_PhilippeB
{
    // Création de la classe Ado.Net "SqlBibliotheque" afin de communiquer avec la base de données
    internal class SqlBibliotheque
    {
        // Création des attributs de la classe

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataSet dsBibliotheque;
        private DataTable dtLivre;
        private DataTable dtClient;

        //Propriétés des attributs

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DataSet DsBibliotheque { get => dsBibliotheque; set => dsBibliotheque = value; }
        public DataTable DtLivre { get => dtLivre; set => dtLivre = value; }
        public DataTable DtClient { get => dtClient; set => dtClient = value; }

        // Constructeur de la classe SqlBibliotheque
        public SqlBibliotheque()
        {
            connectionString = "Data Source=C-JUMLM81NI4BIK;Initial Catalog=Bibliotheque;User ID=sa;Password=sql";
            adapter = new SqlDataAdapter();
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            dsBibliotheque = new DataSet();
            dtLivre = new DataTable();
            dtClient = new DataTable();
        }
    }
}
