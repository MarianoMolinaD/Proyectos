namespace LESBlazorEliminar.Services
{
    using LESBlazorEliminar.Models;
    using System.Collections;

    namespace ListaBlazorApp.Services
    {
        public class ListaEnlazadaSimple : IEnumerable
        {
            public Nodo PrimerNodo { get; set; }
            public Nodo UltimoNodo { get; set; }

            public ListaEnlazadaSimple()
            {
                PrimerNodo = null;
                UltimoNodo = null;
            }

            public bool ListaVacia()
            {
                return PrimerNodo == null;
            }

            public string AgregarNodoAlFinal(Nodo nuevoNodo)
            {
                if (ListaVacia())
                {
                    PrimerNodo = nuevoNodo;
                    UltimoNodo = nuevoNodo;
                }
                else
                {
                    UltimoNodo.Referencia = nuevoNodo;
                    UltimoNodo = nuevoNodo;
                }

                return ("Se ha agregado el nodo al final");
            }

            public string AgregarNodoAlInicio(Nodo nuevoNodo)
            {
                if (ListaVacia())
                {
                    PrimerNodo = nuevoNodo;
                    UltimoNodo = nuevoNodo;
                }
                else
                {
                    nuevoNodo.Referencia = PrimerNodo;
                    PrimerNodo = nuevoNodo;

                }

                return "Se ha agregado el nodo al inicio";
            }
            public string AgregarNodoEnmedio(Nodo nuevoNodo)
            {
                if (ListaVacia())
                {
                    PrimerNodo = nuevoNodo;
                    UltimoNodo = nuevoNodo;
                }
                else
                {
                    nuevoNodo.Referencia = PrimerNodo;
                    UltimoNodo = nuevoNodo;
                }

                return "Se ha agregado el nodo en medio";
            }
            public string AgregarNodoEnPosicion(Nodo nuevoNodo, int posicion)
            {
                if (posicion < 0)
                {
                    return "La posición no puede ser negativa";
                }
                else if (posicion == 0)
                {
                    // Si la posición es cero, simplemente agregamos el nodo al inicio
                    return AgregarNodoAlInicio(nuevoNodo);
                }
                else
                {
                    Nodo nodoActual = PrimerNodo;
                    int contador = 0;

                    // Avanzamos hasta la posición anterior a la posición deseada
                    while (nodoActual != null && contador < posicion - 1)
                    {
                        nodoActual = nodoActual.Referencia;
                        contador++;
                    }


                    if (nodoActual == null)
                    {
                        return "La lista no es lo suficientemente larga para insertar en la posición especificada";
                    }
                    else
                    {
                        // Insertamos el nuevo nodo después del nodo actual
                        nuevoNodo.Referencia = nodoActual.Referencia;
                        nodoActual.Referencia = nuevoNodo;

                        // Si el nuevo nodo es el último nodo, actualizamos UltimoNodo
                        if (nodoActual == UltimoNodo)
                        {
                            UltimoNodo = nuevoNodo;
                        }

                        return $"Nodo actual: INFORMACION {nodoActual.Informacion} - REFERENCIA {nodoActual.Referencia}";

                    }
                }
            }


            public IEnumerator GetEnumerator()
            {
                Nodo nodoAuxiliar = PrimerNodo;

                while (nodoAuxiliar != null)
                {
                    yield return nodoAuxiliar.Informacion;

                    nodoAuxiliar = nodoAuxiliar.Referencia;
                }
            }
            

            public string EliminarPrimerNodo()
            {
                if (ListaVacia())
                {
                    return "La lista está vacía, no se puede eliminar ningún nodo.";
                }
                else
                {
                    Nodo nodoAEliminar = PrimerNodo;
                    PrimerNodo = PrimerNodo.Referencia;

                    if (PrimerNodo == null)
                    {
                        UltimoNodo = null;
                    }

                    return $"Se ha eliminado el nodo con información {nodoAEliminar.Informacion} del principio.";
                }
            }

            public string EliminarUltimoNodo()
            {
                if (ListaVacia())
                {
                    return "La lista está vacía, no se puede eliminar ningún nodo.";
                }
                else
                {
                    Nodo nodoActual = PrimerNodo;
                    Nodo nodoAnterior = null;

                    while (nodoActual.Referencia != null)
                    {
                        nodoAnterior = nodoActual;
                        nodoActual = nodoActual.Referencia;
                    }

                    UltimoNodo = nodoAnterior;
                    UltimoNodo.Referencia = null;

                    if (UltimoNodo == null)
                    {
                        PrimerNodo = null;
                    }

                    return $"Se ha eliminado el último nodo con información {nodoActual.Informacion}.";
                }
            }

            public string EliminarNodoEnPosicion(int posicion)
            {
                if (ListaVacia())
                {
                    return "La lista está vacía, no se puede eliminar ningún nodo.";
                }
                else if (posicion < 0)
                {
                    return "La posición no puede ser negativa.";
                }
                else if (posicion == 0)
                {
                    return EliminarPrimerNodo();
                }
                else
                {
                    Nodo nodoActual = PrimerNodo;
                    Nodo nodoAnterior = null;
                    int contador = 0;

                    while (nodoActual != null && contador < posicion)
                    {
                        nodoAnterior = nodoActual;
                        nodoActual = nodoActual.Referencia;
                        contador++;
                    }

                    if (nodoActual == null)
                    {
                        return "La posición especificada está fuera del rango de la lista.";
                    }
                    else
                    {
                        nodoAnterior.Referencia = nodoActual.Referencia;

                        if (nodoActual == UltimoNodo)
                        {
                            UltimoNodo = nodoAnterior;
                        }

                        return $"Se ha eliminado el nodo en la posición {posicion} con información {nodoActual.Informacion}.";
                    }
                }
            }

           
        }
    }

}
