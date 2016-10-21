using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace Composite
{
    /// <summary>
    /// Clase que contiene una lista de componentes sobre la que actuar
    /// </summary>
    public abstract class Composite : Renombrable
    {
        protected List<Componente> componentes= new List<Componente>();
        private int tamano;

        public Composite(string _nombre) : base(_nombre)
        {
            tamano = 1;
            this.nombre = _nombre;
        }
        /// <summary>
        /// Añade un componente a la lista
        /// </summary>
        /// <param name="c"></param>
        public  void addComponente(Componente c)
        {
            componentes.Add(c);
        }


        /// <summary>
        /// Elimina un componente de la lista
        /// </summary>
        /// <param name="c"></param>
        public  void removeComponente(Componente c)
        {
            componentes.Remove(c);
        }

        /// <summary>
        /// Método que retorna el numero de elementos hijos mas el mismo
        /// </summary>
        /// <returns></returns>
        public override int elementos()
        {
            int res = 0;
            for (int i = 0; i < componentes.ToArray().Length; i++)
            {
                res += componentes[i].elementos();
            }
            return res;
        }

        public abstract override void accept(IVisitor v);
        public abstract override int getTamano();

        public List<Componente> getHijos()
        {
            return componentes;
        }

        public override String ToString()
        {
            String res = this.nombre;
            res +="\n";
            for (int i=0;i<componentes.Count;i++)
            {
                res += componentes[i].ToString();
            }
            return res;
        }

    }
}
