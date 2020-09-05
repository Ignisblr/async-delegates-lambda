using System;

namespace ConsoleDelegatesAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegatesTest delegatesTest = new DelegatesTest();
            Console.WriteLine("Enter two words:");
            string word = Console.ReadLine();
            string nextWord = Console.ReadLine();

            delegatesTest.GetMesseges();
            delegatesTest.ConcatStrings(word, nextWord);
            //CharsCounter charsCounter = delegatesTest.GetCharsNumber;
            Func<string, int> charsCounter = delegatesTest.GetCharsNumberByValue;

            Console.WriteLine(charsCounter(word));
            Console.ReadLine();
        }
    }
}
