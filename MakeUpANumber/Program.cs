using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeUpANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            String numberList = Console.ReadLine();
            int solution = Convert.ToInt32(Console.ReadLine());
            String[] words = numberList.Split(',');
            int[] num = new int[words.Length];
            int i = 0;
            List<string> strings = new List<string>();
            foreach (var word in words)
            {
                num[i]=Convert.ToInt32($"{word}");
                i++;
            }
            MakeItUp madeIt = new MakeItUp();
            //strings = madeIt.getAnswers(num,solution);
            int[] history = new int[num.Length];
            strings = madeIt.recursionfunc(solution, num, strings, num.Length, 0, history);
            foreach (string value in strings)
            {
                Console.WriteLine($"{value.Substring(1,value.Length-1)}");//.Substring(1,value.Length-1)}");
            }
            Console.ReadLine();
        }
    }
}
