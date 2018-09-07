/// <author>Daniel Morato Baudi</author>
using System;
using System.Collections.Generic;

namespace AnalizeNotebook
{
    class Atajo
    {
        #region Atributos
        private string nombre;
        #endregion

        #region Constructores
        public Atajo()
        {
            nombre = "";
        }

        public Atajo(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Métodos
        #endregion

        #region Propiedades
        public string Nombre
        {
            get { return nombre;  }
            set { nombre = value; }
        }
        #endregion
    }
}
