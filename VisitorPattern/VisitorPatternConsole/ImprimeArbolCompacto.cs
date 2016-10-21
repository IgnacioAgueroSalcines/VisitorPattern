using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;

namespace VisitorPattern
{
    public class ImprimeArbolCompacto : IVisitor
    {
        public void imprimeArchivo(Archivo a)
        {
            Console.WriteLine(a.nombre);
        }

        public void ImprimeComprimido(Comprimido c)
        {
            Console.WriteLine(c.nombre);
        }

        public void ImprimeDirectorio(Directorio d)
        {
            Console.WriteLine(d.nombre);
        }

        public void ImprimeEnlace(EnlaceDirecto e)
        {
            Console.WriteLine(e.nombre);
        }
    }
}
