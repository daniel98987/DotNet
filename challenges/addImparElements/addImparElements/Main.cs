using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addImparElements
{
    public class Main
    {
        public int AddImparNumbers(int[] numbers)
        {
            var aux = 0;
            foreach (int number in numbers)
            {
                if (!(number % 2 == 0))
                {
                    aux = aux + number;
                }
            }
            return aux;
        }
        public int AddImparNumbersLinq(int[] numbers)
        {

            return numbers.Where(x => !(x % 2 == 0)).Sum();
        }
    }
}
