using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
	public class ListTypes
	{ 
		public void ListType()
		{
			Console.WriteLine("==================== TYPE LIST =========================");
			List<int> numbers = new();
			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(3);
			numbers.Add(1);
			numbers.Remove(1);
			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Hi");
			Console.WriteLine("========================================================");
		} 		
		public void HashTableListType()
		{
			//Permite tener un diccionar que tenga elementos unicos
			Console.WriteLine("==================== HashTableListType  =========================");
			Hashtable numbers = new Hashtable();
			numbers.Add(1, "1");
			numbers.Add(2, "2");
			numbers.Add(3, "3");
			numbers.Add(4, "4");

			foreach (string i in numbers.Values)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Hi");
			Console.WriteLine("========================================================");
		} 		
		public void DictionaryListType()
		{
			//Permite tener un diccionar con el tipo necesitado o requerido
			Console.WriteLine("==================== DictionaryListType  =========================");
			Dictionary<int, string> numbers = new Dictionary<int, string>();

			numbers.Add(1, "1");
			numbers.Add(2, "2");
			numbers.Add(3, "3");
			numbers.Add(4, "4");

			foreach (string i in numbers.Values)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Hi");
			Console.WriteLine("========================================================");
		}
		public void QueueListType()
		{
			//Primero que entra primero que sale fifo
			Console.WriteLine("==================== QueueListType  =========================");
			Queue<int> numbers = new Queue<int>();

			numbers.Enqueue(1);
			numbers.Enqueue(2);
			numbers.Enqueue(3);
			numbers.Enqueue(4);

			numbers.Dequeue();

			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("========================================================");
		} 		
		public void StackListType()
		{
			//Primero que entra primero que sale fifo
			Console.WriteLine("==================== StackListType  =========================");
			Stack<int> numbers = new Stack<int>();

			numbers.Push(1);
			numbers.Push(2);
			numbers.Push(3);
			numbers.Push(4);

			int last = (int)numbers.Pop();

			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("========================================================");
		}		
		public void ListManagement( List<int> lst)
		{
			//foreach (var (item, index) in lst.())
			//{
			//	Console.WriteLine(i);
			//}
			//Console.WriteLine("List => ",lst);
		} 		
		public void IListManagement( IList<int> lst)
		{
			foreach (int i in lst)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("IList => ",lst);
		}
		public void ICollectionManagement(ICollection<int> lst)
		{
			Console.WriteLine($"Count => {lst.Count}");

			// Verificar si la colección implementa IList<T> para acceder por índice
			if (lst is IList<int> list && lst.Count > 2)
			{
				// Cambiar el valor en la posición 2
				list[2] = 1;
			}
			else
			{
				// Puedes manejar de manera diferente si no se puede acceder por índice
				Console.WriteLine("La colección no admite acceso por índice.");
			}
		}

		public void IEnumerableManagement(IEnumerable<int> lst)
		{
		/*	Console.WriteLine("IEnumerable => ", lst)*/;
			//Console.WriteLine("Count => ", lst.Count);
			//foreach (int i in lst)
			//{
			//	Console.WriteLine(i);
			//}
	
		} 
	}
}
