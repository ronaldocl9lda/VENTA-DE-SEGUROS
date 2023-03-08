using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace InsuranceProgram.Layers.Persistence
{
    public class Connection
    {
        /// <summary>
        /// atribute necessary to use the log4net
        /// </summary>
        private static readonly log4net.ILog _MyLogControlEventos =
            log4net.LogManager.GetLogger("MyControlEventos");

        /// <summary>
        /// atributes that we need to connect the database
        /// </summary>
        private string Base;
        private string Server;
        private string User;
        private string Password;
        private bool Security;
        private static Connection Con = null;

        /// <summary>
        /// Constructor Method that allow us to connect the database with the program
        /// </summary>
        private Connection()
        {
            this.Base = "InsuranceProgram";
            this.Server = "LAPTOP-D28HFAR7";
            this.User = "sa";
            this.Password = "ronaldocampos1";
            this.Security = true;
        }

        /// <summary>
        /// Method that will create the connection with the database
        /// </summary>
        /// <returns>Returns an SqlConnection</returns>
        public SqlConnection CreateConnection()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Server + "; Database=" + this.Base + ";";
                if (this.Security == true)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.User + ";Password =" + this.Password;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;

                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("\r\nMessage {0}\n", ex.Message);
                msg.AppendFormat("Source {0}\n", ex.Source);
                msg.AppendFormat("StackTrace {0}\n", ex.StackTrace);
                msg.AppendFormat("Data {0}\n", ex.Data);
                _MyLogControlEventos.Fatal(msg.ToString());
                MessageBox.Show("Se ha producido un error FORZADO:\n\nRevise el LOG\n\n" + ex.Message, "Error");
            }
            return Cadena;
        }

        /// <summary>
        /// Method that verify if there is already a connection to the database
        /// </summary>
        /// <returns>Returns a Connection with the database</returns>
        public static Connection getInstancia()
        {
            if (Con == null)
            {
                Con = new Connection();
            }
            return Con;
        }
    }
}
