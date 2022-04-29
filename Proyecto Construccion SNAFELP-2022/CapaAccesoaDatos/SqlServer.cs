using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones_SNAFELP;

namespace CapaAccesoaDatos {
    /// <summary>
    /// Encapsula la manipulacion del tipo de almacenamiento
    /// </summary>
    class SqlServer {
        protected String _connectionString = "";
        protected SqlConnection _conexion = new SqlConnection();
        /// <summary>
        /// Bob construye; ¿Podrán hacerlo?; Bob construye; ¡Sí podremos!
        /// Se configura mi cadena, aun no manejamos bien git para programar que cada programador tenga su cadena propia
        /// </summary>
        public SqlServer() {
            _connectionString = "Data Source=CGEPROGRAMADOR\\SQLEXPRESS;Initial Catalog=SNAFELP;Integrated Security=True";
        }
        /// <summary>
        /// Bob construye; ¿Podrán hacerlo?; Bob construye; ¡Sí podremos!
        /// Se configura mi cadena, aun no manejamos bien git para programar que cada programador tenga su cadena propia
        /// </summary>
        /// <param name="ConnectionString">se le pasa la cadena de coneccion</param>
        public SqlServer(String ConnectionString) {
            this.ConnectionString = ConnectionString;
        }

        /// <summary>
        /// Cadena de coneccion que permite generar una conexion a la base de datos SQL Server 
        /// </summary>
        public String ConnectionString { get => _connectionString; set => _connectionString = value; }
        
        /// <summary>
        /// Acceso a la conexion para realozar operaciones sobre la base de datos
        /// </summary>
        public  SqlConnection Conexion { get => _conexion; }

        public void Abrir_conexion() {
            _conexion.ConnectionString = _connectionString;
            try {
                _conexion.Open();
            } catch (InvalidOperationException) {
                throw new OpenError_SQL_Server_SNAFELP_Exception();
            } catch (SqlException) {
                throw new OpenError_SQL_Server_SNAFELP_Exception();
            }
        }

        public void Cerrar_conexion() {
            try {
                _conexion.Close();
            } catch (SqlException) {
                throw new CloseError_SQL_Server_SNAFELP_Exception();
            }
        }


    }
}
