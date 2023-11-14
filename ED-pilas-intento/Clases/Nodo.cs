using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_pilas_intento.Clases
{
	public class Nodo
	{
		private int _dato;
		private Nodo _siguiente;
		//sobrecarga de metodo
		public Nodo(int dato)
		{
			_dato = dato;
			_siguiente = null;
		}
		//con esto podemos agregar en medio de la lista si queremos
		/*los argumentos son llamados firmas */
		public Nodo(int dato, Nodo siguiente)
		{
			_dato = dato;
			_siguiente = siguiente;
		}

		public int getDatos()
		{
			return _dato;
		}

		public Nodo getSiguiente()
		{
			return _siguiente;
		}
		public void setSiguiente(Nodo siguiente)
		{
			_siguiente = siguiente;
		}
		/*forma corta
        public int datos { get; }
        public Nodo siguiente { get; set; }
        */
	}
}
