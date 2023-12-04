using edu.CMejeroExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroExamen.Servicios
{
    /// <summary>
    /// Clase que se encarga de la operativa de nuestra aplicación
    /// <author>CMR - 4-12-23</author>
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de añadir nuevos elementos a lista
        /// <author>CMR - 4-12-23</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void añadirElemento(List<VajillaDto> listaAntigua);

        /// <summary>
        /// Metodo que se encarga de crear nuevos elementos
        /// <author>CMR - 4-12-23</author>
        /// </summary>
        /// <returns></returns>
        public void crearNuevoElemento();

        /// <summary>
        /// Metodo que se encarga de modificar los elementos de nuestra lista
        /// <author>CMR - 4-12-23</author>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void modificarElemento(List<VajillaDto> listaAntigua);
        
    }
}
