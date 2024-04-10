using LEDAppBlazorApp.Model;

namespace LEDAppBlazorApp.Services
{
    public class LED
    {

        public Nodo? PrimerNodo { get; set; }
        public Nodo? UltimoNodo { get; set; }

        public Nodo? NodoActual { get; set; }
        public LED()
        {
            PrimerNodo = null;
            UltimoNodo = null;
            NodoActual = null;
        }

        public bool isEmpty => PrimerNodo == null;

        public string AgregarNodoAlIncicio(Nodo nuevoNodo)
        {
            if(isEmpty)
            {
                PrimerNodo = nuevoNodo;
                UltimoNodo = nuevoNodo;
            }
            else
            {
                nuevoNodo.LigaSigueinte = PrimerNodo;
                PrimerNodo.LigaAnrerior = nuevoNodo;

                PrimerNodo = nuevoNodo;
            }

            NodoActual = nuevoNodo;

            return "Nodo agregado al inicio de la lista";
        }

        public Nodo Siguiente()
        {
            NodoActual = NodoActual.LigaSigueinte ?? UltimoNodo;

            return NodoActual;

        }
        
        public Nodo Anterior() {
            NodoActual = NodoActual.LigaAnrerior ?? PrimerNodo;

            return NodoActual;
        }

    }
}
