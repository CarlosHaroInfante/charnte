using charnte.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace charnte.Servicios
{
    /// <summary>
    /// Interfaz donde encuentran los métodos de cubiertos
    /// <author>CHI - 04-12-23</author>
    /// </summary>
    internal class CubiertoImplementacion : CubiertoInterfaz
    {

        /// <summary>
        /// Método donde se dará alta a los nuevos elementos
        /// <author>CHI - 04-12-23</author>
        /// </summary>
        /// <param name="cubiertosAntiguos"></param>
        public void altaCubierto(List<CubiertosDto> cubiertosAntiguos)
        
        {
            CubiertosDto elemento = DatosCubierto();

            cubiertosAntiguos.Add(elemento);

            Console.WriteLine("---------------");
            Console.WriteLine(elemento.NombreElemento);
            Console.WriteLine(elemento.CantidadElemento);

        }
        /// <summary>
        /// Método donde se modificará la cantidad de los elementos
        /// <author>CHI - 04-12-23</author>
        /// </summary>
        /// /// <param name="cubiertosAntiguos"></param>
        public void modCubierto(List<CubiertosDto> cubiertosAntiguos)
        { 
              CubiertosDto modCub = new CubiertosDto();

              MenuInterfaz dato = new MenuImplementacion();

              string idElm = dato.resta();

            foreach (CubiertosDto cubierto in cubiertosAntiguos)
            {
                Console.WriteLine(cubierto.IdElemento + cubierto.NombreElemento);
                
                Console.WriteLine("Que cantidad quiere eliminar de elementos");
                int borrar = Convert.ToInt32(Console.ReadLine());

                
                 
                if (idElm.Equals(cubierto.IdElemento + cubierto.NombreElemento))
                {
                    
                    int cubierto1 = Convert.ToInt32(cubierto.CantidadElemento);
                    int resta = borrar - cubierto1;
                    modCub.CantidadElemento = resta;

                    modCub.CantidadElemento = cubierto.CantidadElemento;

                    Console.WriteLine(cubierto.NombreElemento.ToString());
                    Console.WriteLine(cubierto.CantidadElemento);

                    break; 
                }
                //cubiertosAntiguos.Add(modCub);
                Console.WriteLine("---------------");
                Console.WriteLine(cubierto.NombreElemento.ToString());
                Console.WriteLine(cubierto.CantidadElemento.ToString()); 
            }
            
        }

        private CubiertosDto DatosCubierto()
        {

            CubiertosDto cubi = new CubiertosDto();

            Console.WriteLine("Datos del nuevo Elemento");

            Console.WriteLine("ID del Elemento");
            cubi.IdElemento = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Nombre del Elemento");
            cubi.NombreElemento = Console.ReadLine();

            Console.WriteLine("Descripción del Elemento");
            cubi.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("Cantidad del Elemento");
            cubi.CantidadElemento = Convert.ToInt32(Console.ReadLine());

            return cubi;

        }
    }
}
