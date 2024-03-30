using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AgendaDataBase
{
    public class DataAccess
    {
        private SqlConnection sqlConnection;

        /// <summary>
        /// Connexion à la base de données
        /// </summary>
        /// <returns> Retourne un booléen indiquant si la connexion est ouverte ou fermée</returns>
        private bool OpenConnection()
        {
            try
            {
                this.sqlConnection = new SqlConnection();
                this.sqlConnection.ConnectionString = " a changer " ;                
                this.sqlConnection.Open();
                return this.sqlConnection.State.Equals(System.Data.ConnectionState.Open);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// Déconnexion de la base de données
        /// </summary>
        private void CloseConnection()
        {
            if (this.sqlConnection.State.Equals(System.Data.ConnectionState.Open))
            {
                this.sqlConnection.Close();
            }
        }

        /// <summary>
        /// Accès à des données en lecture
        /// </summary>
        /// <param name="getQuery">Requête SELECT de sélection de données</param>
        /// <returns>Retourne un DataTable contenant les lignes renvoyées par le SELECT</returns>
        public DataTable GetData(string getQuery)
        {
            try
            {
                if (this.OpenConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(getQuery, this.sqlConnection);
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter();
                    sqlAdapter.SelectCommand = sqlCommand;
                    DataTable dataTable = new DataTable();
                    sqlAdapter.Fill(dataTable);
                    this.CloseConnection();
                    return dataTable;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
				Console.WriteLine(e);
                this.CloseConnection();
                return null;
            }
        }

        /// <summary>
        /// Permet d'insérer, supprimer ou modifier des données
        /// </summary>
        /// <param name="setQuery">Requête SQL permettant d'insérer (INSERT), supprimer (DELETE) ou modifier des données (UPDATE)</param>
        /// <returns>Retourne un entier contenant le nombre de lignes ajoutées/supprimées/modifiées</returns>
        public int SetData(string setQuery)
        {
            try
            {
                if (this.OpenConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand(setQuery, this.sqlConnection);
                    int modifiedLines = sqlCommand.ExecuteNonQuery();
                    this.CloseConnection();
                    return modifiedLines;
                }
                else
                    return 0;
            }
            catch (Exception e)
            {
				Console.WriteLine(e);
                this.CloseConnection();
                return 0;
            }
        }
    }
}
