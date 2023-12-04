using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroExamen.Servicios
{
    /// <summary>
    /// clase que se encarga del menu principal de nuestra aplicación
    /// <author>CMR - 4-12-23</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// metodo que muestra el menu principal al usuario para realizar las diferentes acciones.
        /// <author>CMR - 4-12-23</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        /// <summary>
        /// metodo que pide al usuario el nombre del elemento.
        /// <author>CMR - 4-12-23</author>
        /// </summary>
        /// <returns></returns>
        public int pedirNombreCubierto();
    }
}
