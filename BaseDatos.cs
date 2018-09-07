/// <author>Daniel Morato Baudi</author>
using System.Data.OleDb;
using System.Windows.Forms;

namespace BibliotecaJuegos
{
    class BaseDatos
    {
        #region Atributos
        private OleDbConnection conexion;
        private OleDbCommand orden;
        private OleDbDataReader lector;
        #endregion

        #region Constructor
        public BaseDatos()
        {
            conexion = new OleDbConnection();
            orden = new OleDbCommand();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Permite insertar datos en la DB.
        /// </summary>
        /// <param name="insercion">Sentencia SQL inserción.</param>
        /// <returns>Estado de la inserción.</returns>
        public string Insertar(string insercion)
        {
            if (insercion.StartsWith("INSERT"))
            {
                IniciarConexion();

                orden.CommandText = insercion;
                orden.Connection = conexion;

            } else {

                return "La instrucción introducida no es "
                       + "una instrucción INSERT válida.";
            }

            try {

                if (orden.ExecuteNonQuery() < 1)
                    return "No se ha podido insertar.";
                else
                    return "Juego añadido correctamente.";

            } catch (OleDbException ErrorDB) {
                return "Error: " + ErrorDB.Message;

            } finally {
                CerrarConexion();
            }
        }

        /// <summary>
        /// Permite consultar datos de la DB.
        /// </summary>
        /// <param name="consulta">Sentencia SQL consulta.</param>
        /// <returns>Datos leídos de la DB.</returns>
        public OleDbDataReader Consultar(string consulta)
        {
            if (consulta.StartsWith("SELECT"))
            {
                IniciarConexion();
                orden = new OleDbCommand(consulta, conexion);
            
            } else {

                MessageBox.Show("La instrucción introducida no es " +
                                "una instrucción SELECT válida.");
            }

            try {

                lector = orden.ExecuteReader();

            } catch (OleDbException ErrorDB) {
                MessageBox.Show("Error: " + ErrorDB.Message);
            }

            return lector;
        }

        /// <summary>
        /// Permite editar los datos de la DB.
        /// </summary>
        /// <param name="editado">Sentencia SQL editado.</param>
        public void Modificar(string editado)
        {
            if (editado.StartsWith("UPDATE"))
            {
                IniciarConexion();

                orden.CommandText = editado;
                orden.Connection = conexion;
            
            } else {

                MessageBox.Show("La instrucción introducida no es" +
                                "una instrucción UPDATE válida.");
            }

            try {

                if (orden.ExecuteNonQuery() < 1) {
                    // return "No se ha podido editar.";
                } else {
                    // return "Juego editado correctamente.";
                }

            } catch (OleDbException ErrorDB) {
                MessageBox.Show("Error: " + ErrorDB.Message);

            } finally {
                CerrarConexion();
            }
        }

        /// <summary>
        /// Permite borrar datos de la DB.
        /// </summary>
        /// <param name="borrado"></param>
        public void Borrar(string borrado)
        {
            if (borrado.StartsWith("DELETE"))
            {
                IniciarConexion();

                orden.CommandText = borrado;
                orden.Connection = conexion;

            } else {

                MessageBox.Show("La instrucción introducida no es " +
                                "una instrucción DELETE válida.");
            }

            try {

                if (orden.ExecuteNonQuery() < 1) {
                    // return "No se ha podido borrar.";
                } else {
                    // return "Juego borrado correctamente.";
                }

            } catch (OleDbException ErrorDB) {
                MessageBox.Show("Error: " + ErrorDB.Message);

            } finally {
                CerrarConexion();
            }
        }

        /// <summary>
        /// Inicia la conexión con la DB.
        /// </summary>
        public void IniciarConexion()
        {
            try {

                conexion = new OleDbConnection(
                    "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=|DataDirectory|\\BibliotecaJuegos.accdb;" +
                    "Persist Security Info=True");

                conexion.Open();

            } catch (OleDbException ex) {

                MessageBox.Show("Error: " + ex.Message);
                CerrarConexion();
            }
        }

        /// <summary>
        /// Cierra la conexión con la DB.
        /// </summary>
        public void CerrarConexion()
        {
            if (!(conexion == null))
                conexion.Close();
            if (!(lector == null))
                lector.Close();
        }
        #endregion

        #region Propiedades
        public OleDbCommand Orden
        { 
            get {return this.orden;}
            set {this.orden = value;}
        }
        #endregion
    }
}