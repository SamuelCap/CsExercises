using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess A number between 1 and 100");
            Number num = new Number();
            num.randomNumber = num.generateNumber();
            num.guessedNumber = Convert.ToInt32(Console.ReadLine());
            while (!num.iscorrect() && num.numOfGuesses <6) {
                Func<bool, string> higher = x => x ? "Higher" : "Lower";
                Console.WriteLine(higher(num.ishigher()));
                num.guessedNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(num.print());
            Console.ReadLine();
        }
    }
}