using charnte.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnte.Servicios
{
    /// <summary>
    /// Interfaz donde encuentran los métodos de cubiertos
    /// <author>CHI - 04-12-23</author>
    /// </summary>
    internal interface CubiertoInterfaz
    {
        /// <summary>
        /// Método donde se dará alta a los nuevos elementos
        /// <author>CHI - 04-12-23</author>
        /// </summary>
        /// <param name="cubiertosAntiguos"></param>
        public void altaCubierto(List<CubiertosDto> cubiertosAntiguos);

        /// <summary>
        /// Método donde se modificará la cantidad de los elementos
        /// <author>CHI - 04-12-23</author>
        /// </summary>
        /// /// <param name="cubiertosAntiguos"></param>
        public void modCubierto(List<CubiertosDto> cubiertosAntiguos);
    }
}
