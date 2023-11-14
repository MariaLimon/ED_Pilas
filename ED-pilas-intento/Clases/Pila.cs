using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_pilas_intento.Clases
{
	internal class Pila
	{
		
		
			int[] datosPila;
			int punteroPila = -1;
			const int MAXPILA = 10;

			// Constructor
			public Pila()
			{
				punteroPila = 0;
				datosPila = new int[MAXPILA];
			}

		// Añadir a la pila: Push
		public void Push(int dato)
		{
			if (PilaVacia() == false)
			{
				Console.WriteLine("Pila llena!");
			}
			else
			{
				datosPila[punteroPila] = dato;
				punteroPila++;
			}
		}

		// Extraer de la pila: Pop
		public int Pop()
		{
			if (PilaVacia())
			{
				Console.WriteLine("Pila vacia!");
			}
			else
			{ 
				punteroPila--;
				return datosPila[punteroPila];
			}
			return -0;
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
				for (int i = punteroPila - 1; i >= 0; i--)
				{
					Console.WriteLine($"{datosPila[i]}->");
				}
				Console.WriteLine("->null");
			}
		}

		//la pila esta vacia: PilaVacia
		public bool PilaVacia()
		{
			if (punteroPila == -1)
			{
				return true;
			}
			else if(punteroPila == MAXPILA)
			{
				return false;
			}
			else
			{
				return true;
			}
			/*otra forma de hacerlo es con operador ternario solo se puede tener dos opciones
                return primero == null ? false : true;
             */
		}
	}
}
