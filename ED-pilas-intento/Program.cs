using ED_pilas_intento.Clases;

namespace ED_pilas_intento
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Pila pila = new Pila();
			pila.Push(5);
			pila.Push(6);
			pila.Push(7);
			pila.Push(8);
	

			pila.ImprimirDatos();


			Console.WriteLine("---------------------");
			
			pila.Pop();
			pila.ImprimirDatos();
			
		}
	}
}