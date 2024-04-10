namespace LEDAppBlazorApp.Model
{
    public class Nodo
    {
        public Nodo? LigaAnrerior { get; set; }
        public string Informacion { get; set; }
        public Nodo? LigaSigueinte { get; set; }

        public Nodo(string informacion)
        {
            LigaAnrerior = null;
            Informacion = informacion;
            LigaSigueinte = null;
        }
    }
}
