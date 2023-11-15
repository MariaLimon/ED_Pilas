using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_pilas_intento.Clases
{
	internal class Pila
	{

		private int _cima;
		private int[] listaPila;
		private int longitudPila = 5;
			

		// Constructor
		public Pila()
		{
			_cima = -1;
			listaPila = new int[longitudPila];
		}

        //la pila esta vacia: PilaVacia
        public bool PilaVacia()
        {
            return _cima == -1 ? true: false;
			/*
            if (_cima == -1)
            {
                return true;
            }
			return false;
            /*otra forma de hacerlo es con operador ternario solo se puede tener dos opciones
                return _cima == -1 ? false : true;
             */
        }

		public bool PilaLlena()
		{
			return _cima == longitudPila-1? true : false;
		}

		//tamaño de la pila: TamañoPila
		public int TamañoPila()
		{
			return longitudPila;
		}

		//cantidad de elementos de la pila: CantidadElementosPila
		public int CantidadElementosPila()
		{
			return _cima + 1;
		}

		//leer el valor de la cima: ValorCima
		public int ValorCima()
		{
			return listaPila[_cima];
		}

        // Insertar elementos en la pila: Push
        public bool Push(int dato)
		{
			if (PilaLlena())
			{
				return false;
			}
			else
			{
				_cima++;
                listaPila[_cima] = dato;
				return true;
			}
		}

		// Extraer un elemento de la pila: Pop
		public int Pop()
		{
			if (PilaVacia())
			{
				Console.WriteLine("la pila esta vacia");
				return _cima;
			}
			else
			{ 
				int auxiliar = listaPila[_cima];
				_cima--;
				return auxiliar;
			}
		}

		//limpiar elementos de la pila: LimpiarPila
		public bool Limpiar()
		{
			if (PilaVacia())
			{
				return false;
			}
			else
			{
				while (!PilaVacia())
				{
                    Pop();
                }
				return true;
			}
		}

		// Imprimir los datos de la pila: ImprimirDatos
		public void ImprimirDatos()
		{
			if (PilaVacia())
			{
				Console.WriteLine("La pila está vacía");
			}
			else
			{
				for (int i = 0; i < _cima+1; i++)
				{
					Console.WriteLine($"{listaPila[i]}->");
				}
				Console.WriteLine("->null");
			}
		}
		/*
		public void ImprimirDatos()
		{
			if (PilaVacia())
			{
				Console.WriteLine("la pila esta vacia");
			}
			else
			{
				int contador = 0;
				while (_cima+1 != contador)
				{

					Console.WriteLine($"{listaPila[contador]}->");
					contador++;
				}
				Console.WriteLine("->null");
			}
		}
		*/
	}
}
