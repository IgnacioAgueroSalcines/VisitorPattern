using Composite;

namespace VisitorPattern
{
    /// <summary>
    /// Clase que comprueba el funcionamiento de la impresion del contenido de forma compacta
    /// </summary>
    class MainCompacto
    {
        static void Main(string[] args)
        {
            IVisitor v = new ImprimeArbolCompacto();

            Composite.Composite root= inicialize();

            root.ToString();
            
        }
       

        public static Composite.Composite inicialize()
        {
            //inicio creacion del arbol
            Archivo arc = new Archivo("hoja4", 5);
            Composite.Composite composite = new Directorio("root");
            Composite.Composite composite2 = new Directorio("dir");
            Composite.Composite composite3 = new Comprimido("comp");


            composite3.addComponente(new Archivo("hoja1", 5));
            composite3.addComponente(new Archivo("hoja2", 5));

            composite2.addComponente(new Archivo("hoja3", 5));
            composite2.addComponente(composite3);

            EnlaceDirecto e = new EnlaceDirecto(composite2);

            composite.addComponente(arc);
            composite.addComponente(composite2);
            composite.addComponente(e);
            //fin creacion del arbol

            return composite;
        }
    }
}
