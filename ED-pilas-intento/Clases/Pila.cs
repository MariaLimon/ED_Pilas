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
            return _cima == -1? false : true;
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
			return _cima == longitudPila-1? false : true;
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

		// Imprimir los datos de la pila: ImprimirDatos
		public void ImprimirDatos()
		{
			if (PilaVacia())
			{
				Console.WriteLine("la pila esta vacia");
			}
			else
			{
				for (int i = _cima - 1; i >= 0; i--)
				{
					Console.WriteLine($"{listaPila[_cima]}->");
				}
				Console.WriteLine("->null");
			}
		}

		
		
	}
}
