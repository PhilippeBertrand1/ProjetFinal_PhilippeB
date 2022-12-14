using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProjetFinal_PhilippeB
{
    internal class SqlBibliotheque
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataSet dsBibliotheque;
        private DataTable dtLivre;

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public DataSet DsBibliotheque { get => dsBibliotheque; set => dsBibliotheque = value; }
        public DataTable DtLivre { get => dtLivre; set => dtLivre = value; }


        public SqlBibliotheque()
        {
            connectionString = "Data Source=C-I5CGJJSJR5LS7;Initial Catalog=Bibliotheque;User ID=sa;Password=sql";
            adapter = new SqlDataAdapter();
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            dsBibliotheque = new DataSet();
            dtLivre = new DataTable();
        }

        
    }
}
