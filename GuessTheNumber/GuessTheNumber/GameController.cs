using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{


    class GameController
    {
        private int getNumber;
        public int Count { get; private set; }

        public GameController()
        {
            Random random = new Random();
            getNumber = random.Next ( 1, 101 );
            Count = 0;
        }

        public string CheckAnswer( int userAnswer )
        {
            Count++;
            if ( userAnswer < getNumber )
            {
                return "\nZa mało\n";
            }
            else if ( userAnswer > getNumber )
            {
                return "\nZa dużo\n";
            }
            else
            {
                return $"\n\nGratulacje! Odgadłeś liczbę { getNumber } w { Count } próbach.";
            }
        }

        public bool IsCorrect( int userGuess )
        {
            return userGuess == getNumber;
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
