using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnte.Servicios
{
    /// <summary>
    /// Interfaz donde se encuentran los métodos de el menú y pedir el Codigo.
    /// <author>CHI - 04-12-23</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz 
    {

        /// <summary>
        /// Método donde se encuentra el menú
        /// <author>CHI - 04-12-23</author>
        /// </summary>
        public int menu() 
        {
        Console.WriteLine("Inventario de la vajilla");
        Console.WriteLine("[0] - Cerrar Menú");
        Console.WriteLine("[1] - Dar de Alta un nuevo elemento");
        Console.WriteLine("[2] - Eliminar cantidad del elemento");
        Console.WriteLine("[3] - Ver cantidad");

        int opcion = Convert.ToInt32(Console.ReadLine());

        return opcion;
        }

        // <summary>
        /// Método donde se encuentra la pedida de Código
        /// <author>CHI - 04-12-23</author>
        /// </summary>
        public string resta()
        {
            Console.WriteLine("Dame el Codigo del Elemento");
            string Cod = Console.ReadLine();
            return Cod;

        }

    }
}
