using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroExamen.Dtos
{
    /// <summary>
    /// Clase que se encarga de la de los campos de nuestros elementos.
    /// <author>CMR - 4-12-23</author>
    /// </summary>
    internal class VajillaDto
    {

        long idElemento= 0 ;
        string codigoElemento = nombreElemento + " " + idElemento + " ";
        string nombreElemento = "aaaaaa";
        string descripcionElemento = "aaaaaa";
        int cantidadElemento = 0 ;

        public VajillaDto()
        {
        }

        public VajillaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }
    }

   
     override
     public string ToString()
    {
        string toString =  this.idElemento + " " + this.codigoElemento + " " +
            this.nombreElemento + " " + this.descripcionElemento + " " + this.cantidadElemento + " ";

            return toString;
    }






}
