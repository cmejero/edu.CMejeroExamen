using edu.CMejeroExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroExamen.Servicios
{
    /// <summary>
    ///  Implementacion la operativaInterfaz
    ///  <author>CMR - 4-12-23</author>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        MenuInterfaz mi = new MenuImplementacion();

        public void añadirElemento(List<VajillaDto> listaAntigua)
        {
            VajillaDto nuevoElemento = crearNuevoElemento();

            listaAntigua.Add(nuevoElemento);
        }



        public void crearNuevoElemento()
        {
            VajillaDto nuevoElemento = new VajillaDto();
                                      
                
            Console.WriteLine("Introduzca id del elemento");
            nuevoElemento.IdElemento = Convert.ToInt64(Console.ReadLine());
            
                
            Console.WriteLine("Introduza el nombre del elemento");
            nuevoElemento.NombreElemento = Console.ReadLine();
                   
                
             Console.WriteLine("Introduzca descripción del elemento");
             nuevoElemento.DescripcionElemento = Console.ReadLine();
                                 
                
             Console.WriteLine("Introduzca cantidad de elemento");
             nuevoElemento.CantidadElemento= Convert.ToInt32(Console.ReadLine());                         
               
            
        }
        public void modificarElemento(List<VajillaDto> listaAntigua)
        {
            string buscarNombre = mi.pedirNombreCubierto();
            int numeroTotal;
            foreach(VajillaDto elemento in listaAntigua)
            {
                if (elemento.NombreElemento.Equals(buscarNombre))
                {
                    numeroTotal = elemento.NombreElemento - CantidadARestar();
                }
                
                

                
            }
        }
        /// <summary>
        /// Método que se encarga de pedir un número
        /// <author>CMR - 4-12-23</author>
        /// </summary>
        private void CantidadARestar()
        {
            int numeroARestar;
            Console.WriteLine("Indique la cantidad que quieres eliminar");
            numeroARestar= Convert.ToInt32(Console.ReadLine());
        }

    }
}
