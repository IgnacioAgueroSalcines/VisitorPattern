using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern;

namespace Composite
{
   public abstract class Componente
    {

        public int orden { get; set; }
        public abstract int getTamano();
        public abstract int elementos();
        public abstract void accept(IVisitor v);
        public abstract String ToStringExtends();
        
    }
}
