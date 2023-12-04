

using charnte.Dtos;
using charnte.Servicios;

namespace charnte
{
    /// <summary>
    /// Clase principal de Nuestra aplicación por consola.
    /// <author>CHI - 04-12-23</author>
    /// </summary>
    class Program 
    { 
        /// <summary>
        /// Main principal de nuestro programa.
        /// <author>CHI - 04-12-23</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<CubiertosDto> Cubiertos = new List<CubiertosDto>();
            MenuInterfaz menu = new MenuImplementacion();
            CubiertoInterfaz elem = new CubiertoImplementacion();

            bool cerrarMenú = false;    

            while (!cerrarMenú)
            {
                int opcion = menu.menu();
                    

                switch(opcion)
                {

                    case 0:
                        Console.WriteLine("Cerrar Menú");
                        cerrarMenú=true;
                        break;
                    case 1:
                        Console.WriteLine("Alta de un nuevo elemento");
                        elem.altaCubierto(Cubiertos);
                        break;
                    case 2:
                        Console.WriteLine("Restar una cantidad a un elemento");
                        elem.modCubierto(Cubiertos);
                        break;
                    case 3:
                        Console.WriteLine("Ver cantidad de cubiertos");
                        foreach(CubiertosDto cubiertos in Cubiertos)
                        {
                            Console.WriteLine(cubiertos.ToString());                   
                        }
                        break;
                    default:
                        Console.WriteLine("Ninguna opción válida seleccionada");
                        break;
                }
            }


        }

    }
}
