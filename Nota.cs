/// <author>Daniel Morato Baudi</author>
using System;
using System.Collections.Generic;

namespace AnalizeNotebook
{
    class Nota
    {
        #region Atributos
        private string nombre;
        #endregion

        #region Constructores
        public Nota()
        {
            nombre = "";
        }

        public Nota(string nombre)
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
