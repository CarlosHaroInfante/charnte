using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charnte.Dtos
{
    /// <summary>
    /// Lista del Programa donde se encuentran los tipos de cada opción, su getter and setter, constructor y ToString
    /// <author>CHI - 04-12-23</author>
    /// </summary>
    internal class CubiertosDto
    {

        long idElemento;

        string codigoElemento;

        string nombreElemento = "aaaaa";

        string descripcionElemento = "aaaaa";

        int cantidadElemento = 11111;

        

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }
    public CubiertosDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }
    public CubiertosDto() { }

        override
        public string ToString()
        {
            string cubierto = " idElemento: " + this.idElemento +
                " Código del Elemento: " + (this.idElemento + this.nombreElemento) +
                " Nombre del Elemento: " + this.nombreElemento +
                " Descripcion del Elemento: " + this.descripcionElemento +
                " Cantidad del elemento: " + this.cantidadElemento;

            return cubierto;
        }
    
    }
    
}
