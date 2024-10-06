using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC
{

    internal class StringBehaviour
    {
        string Text = " Hola Mundo Terrenal ";
        public StringBehaviour()
        {
            Contains(Text);
            Split(Text);
            Trim(Text);
            Equals(Text);
            Join(Text);
        }
        void Contains(string text)
        {
            bool contains = text.Contains('Z');
            Console.WriteLine($"Contains -> {contains}");
        }        
        
        void Split(string text)
        {
            string[] contains = text.Split(" ");
            foreach (string s in contains)
            {
                Console.WriteLine($"Split -> {s}");
            }
   
        }
        void Trim(string text)
        {

            Console.WriteLine($"Trim() '{text.Trim()}'");         
            Console.WriteLine($"TrimEnd() '{text.TrimEnd()}'");  
            Console.WriteLine($"TrimStart() '{text.TrimStart()}'");

        }        
        void Equals(string text)
        {

            string texto1 = "Hola";
            string texto2 = "hola";
            bool sonIguales = texto1.Equals(texto2, StringComparison.OrdinalIgnoreCase); // Ignora mayúsculas/minúsculas

            Console.WriteLine(sonIguales); // Salida: True

        }       
        
        void Join(string text)
        {

            string[] palabras = { "Me", "gusta", "C#" };
            string fraseUnida = string.Join(" ", palabras);
            Console.WriteLine(fraseUnida); // Salida: Me gusta C#


        }

    }
}
