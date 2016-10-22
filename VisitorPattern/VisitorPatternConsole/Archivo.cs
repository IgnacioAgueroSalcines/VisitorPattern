using System;
using VisitorPattern;

namespace Composite
{
    /// <summary>
    /// Clase que simula un archivo propio del sistema.
    /// </summary>
    public class Archivo: Renombrable
    {
        
        public Archivo(String _nombre,int _tamano) : base(_nombre)
        {
            tamano = _tamano;
            nombre = _nombre;
            orden = 0;
        }

        public int tamano { get; set; }

        public override void accept(IVisitor v)
        {
            v.imprimeArchivo(this);
        }

        
        public override void actualizaOrden(int _orden)
        {
            throw new Exception("Este clase no tiene dicha capacidad");
        }

        /// <summary>
        /// Retorna el numero de elementos hijos mas el mismo
        /// </summary>
        /// <returns></returns>
        public override int elementos()
        {
            return 1;
        }

        public override int getTamano()
        {
            return tamano;
        }

        public override String ToString()
        {
            return this.nombre;
        }

        public override String ToStringExtends()
        {
            return "F "+this.nombre+".jpg";
        }

    }
}
