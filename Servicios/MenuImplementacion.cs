using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroExamen.Servicios
{
    /// <summary>
    /// Implementación de la interfaz
    /// <author>CMR - 4-12-23</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcionUsuario;

            Console.WriteLine("########################");
            Console.WriteLine("0. Cerrar Aplicación");
            Console.WriteLine("1. Añadir elemento");
            Console.WriteLine("2. Modificar elemento");
            Console.WriteLine("3. Ver stock");
            Console.WriteLine("########################");

            opcionUsuario= Console.ReadKey(true).KeyChar - ('0');
            return opcionUsuario;

        }

        public int pedirNombreCubierto()
        {
            int opcionUsuario;
            Console.WriteLine("introduzca nombre del elemento");
            opcionUsuario = Console.ReadKey(true).KeyChar - ('0');

            return opcionUsuario;
            
        }


    }
}
