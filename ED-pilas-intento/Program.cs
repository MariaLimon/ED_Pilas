using ED_pilas_intento.Clases;

namespace ED_pilas_intento
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Pila pila = new Pila();
			pila.Push(1);
			pila.ImprimirDatos();
			pila.Push(2);
			pila.ImprimirDatos();
			pila.Push(3);
			pila.ImprimirDatos();
			pila.Push(4);
			pila.ImprimirDatos();
			pila.Push(5);
			pila.ImprimirDatos();
			pila.Push(6);
			pila.ImprimirDatos();
			pila.Push(7);
			pila.ImprimirDatos();
			pila.Push(8);
			pila.ImprimirDatos();
			pila.Push(9);
			pila.ImprimirDatos();
			pila.Push(10);
			pila.ImprimirDatos();
			pila.Push(11);
			
			Console.WriteLine("---------------------");
			/*
			pila.Pop();
			pila.ImprimirDatos();
			*/
		}
	}
}