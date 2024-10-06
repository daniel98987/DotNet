using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC
{

	public class DelegadosFuncAction
	{
		public delegate string Mostrar(string cadena);
		public DelegadosFuncAction()
		{
			//ACTION NO REGRESA NADA
						Action<string, string> funcPortatil =(a,b)=>Console.WriteLine(a,b);
			Action<string, string> mostrarAction = ShowAction;
			HacerAlgoAction(mostrarAction);
			//DELEGATE-> puedo enviar una función como parametros
			//Mostrar mostrar = Show;
			//HacerAlgo(mostrar);
			//FUNC
			Func<string,int> mostrarFunc = ShowFunc;
			HacerAlgoFunc(mostrarFunc);

		}


		//ACTION
		private void ShowAction(string arg1, string arg2)
		{
			throw new NotImplementedException();
		}
		public static void HacerAlgoAction(Action<string, string> functionFinal)
		{
			Console.WriteLine("Hacer algo");
			functionFinal("se envio desde otra función", "otra");


		}
		//FUNC
		public static void HacerAlgoFunc(Func<string,int> functionFinal)
		{
			Console.WriteLine("Hacer algo");
			Console.WriteLine(functionFinal("se envio desde otra función"));


		}
		public static int ShowFunc(string cad)
		{
			return cad.Count();



		}


		//DELEGATE
		public static void HacerAlgo(Mostrar functionFinal)
		{
			Console.WriteLine("Hacer algo");
			Console.WriteLine(functionFinal("se envio desde otra función"));
			

		}
		public static string Show(string cad)
		{
			return cad.ToUpper();



		}
	

	}


}
