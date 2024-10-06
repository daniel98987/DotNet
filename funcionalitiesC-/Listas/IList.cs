using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Listas
{
	public class IList
	{
		public IEnumerable<int> InumerableTest()
		{
			//Basic feature to iterate through the list of item/objects
			List<int> list = new List<int>() {1, 2, 3, 4, 5};
			foreach (int i in list)
			{
				Console.WriteLine(i);
			};
			IEnumerable<int> e = list;
			return e;
		}
		//public ICollection<int> ICollectionTest()
		//{
		//	//Basic feature to iterate through the list of item/objects
		//	List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
		//	foreach (int i in list)
		//	{
		//		Console.WriteLine(i);
		//	};
		//	IEnumerable<int> e = list;
		//	return e;
		//}
		public void printList(ICollection<string> collection)
		{
			foreach(var element in collection)
			{
				Console.WriteLine($"{element}");
			}
			//collection.fin
		}
	}
}
