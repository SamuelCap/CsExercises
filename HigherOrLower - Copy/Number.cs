using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    public class Number : INumber
    {
        public int guessedNumber { get; set; }
        public int randomNumber { get; set; }
        public int numOfGuesses { get; set; }
        public bool ishigher()
        {
            numOfGuesses++;
            Func<int, int, bool> higherFunc = (x, y) => x < y ? true : false;
            return higherFunc(guessedNumber,randomNumber);
        }
        public bool iscorrect()
        {
            Func<int, int, bool> correctFunc = (x, y) => x == y ? true : false;
            return correctFunc(guessedNumber, randomNumber);
        }
        public int generateNumber()
        {
            Random random = new Random();
            return random.Next(1,101); 
        }
        public string print()
        {
            Func<bool, string> correct = x => x ? "Correct" : "You Lose";
            return correct(iscorrect());
        }
    }
}