using GuessTheNumber;
using System.Timers;

internal class Program
{
    private static void Main( string[] args )
    {
        bool keepRunning = true;

        Console.WriteLine( "-------------------------------------------\n" +
            "Zasady:\n" +
                          "\t1. Liczba zostanie wylosowana od 1 do 1000\n" +
                          "\t2. Twoim zadaniem jest odgadnięcie liczby\n" +
                          "\t3. Za mało - twoja liczba jest mniejsza || Za dużo - twoja liczba jest większa\n" +
                          "-------------------------------------------" );


        while ( keepRunning )
        {
            Console.WriteLine( "Losować? (T/N)" );
            string firstAnswer = Console.ReadLine().Trim().ToUpper();

                if ( firstAnswer == "T" )
                {
                    GameController game = new GameController();
                    int userAnswer = 0;
                    game.Clear();

                while ( !game.IsCorrect( userAnswer ) )
                    {
                        Console.Write( "Wpisz swoją odpowiedź: " );

                        if ( int.TryParse( Console.ReadLine(), out userAnswer ) )
                        {
                            string result = game.CheckAnswer( userAnswer );
                            Console.WriteLine( result );
                        }
                        else
                        {
                            Console.WriteLine( "Nieprawidłowa wartość. Wpisz liczbę całkowitą." );
                        }
                }
            }
                else if ( firstAnswer == "N" )
                {
                    keepRunning = false;
                    Environment.Exit( 0 );
                }
                else Console.WriteLine( "Niepoprawna odpowiedź. Wpisz 'T' aby rozpocząć nową grę, lub 'N' aby zakończyć." );

            
        }
    }
}