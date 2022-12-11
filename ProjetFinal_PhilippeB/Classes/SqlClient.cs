using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProjetFinal_PhilippeB
{
    internal class SqlClient
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataSet dsBibliotheque;
        private DataTable dtClient;

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }
        public DataSet DsBibliotheque { get => dsBibliotheque; set => dsBibliotheque = value; }
        public DataTable DtClient { get => dtClient; set => dtClient = value; }
        

        public SqlClient()
        {
            connectionString = "Data Source=C-I5CGJJSJR5LS7;Initial Catalog=Bibliotheque;User ID=sa;Password=sql";
            adapter = new SqlDataAdapter();
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            dsBibliotheque = new DataSet();
            dtClient = new DataTable();
        }
    }
}
