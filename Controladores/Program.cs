using edu.CMejeroExamen.Dtos;
using edu.CMejeroExamen.Servicios;
using System.Collections.Generic;

namespace edu.CMejeroExamen.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// <author>CMR - 4-12-23</author>
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Metodo de entrada a la aplicación
        /// <author>CMR - 4-12-23</author>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            List<VajillaDto> lista = new List<VajillaDto>();


            int opcionUsuario;
            bool cerrarMenu=false;

            while(!cerrarMenu) {

                opcionUsuario = mi.mostrarMenuYSeleccion();

                switch(opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("La aplicación se cerrará");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Has seleccionado añadir elemento");
                        oi.añadirElemento(lista);
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado modificar elemento");
                        oi.modificarElemento(lista);
                        break;
                    case 3:
                        Console.WriteLine("Has seleccionado ver Stock");
                        foreach(VajillaDto elemento in lista)
                        {
                            Console.WriteLine(elemento.ToString());
                        }
                    break;
                    default:
                        Console.WriteLine("La opción seleccionada no coincide con ninguna");
                        break;
                }
            }

        }
    }
}