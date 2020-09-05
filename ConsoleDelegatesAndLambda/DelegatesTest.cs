using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDelegatesAndLambda
{
    public class DelegatesTest
    {
        public DelegatesTest()
        {
            ;
        }

        public delegate int CharsCounter(string str);

        public int GetCharsNumber(string str)
        {
            return str.ToCharArray().Length;
        }

        public int GetCharsNumberByValue(string str)
        {
            int num = 0;
            foreach (char ch in str)
            {
                if (ch.Equals('a')) { num++; }
            }

            return num;
        }

        public char[] GetChars(string str)
        {
            return str.ToCharArray();
        }

        public async void GetMesseges()
        {
            int i = 0;
            while (i < 100)
            {
                ++i;
                string messege = i % 2 == 0 ? "tack" : "tick";
                Thread.Sleep(500);
                await Task.Run(() => { Console.WriteLine("{0}: {1}", i, messege); });
            }
        }

        public void ConcatStrings(string firstStr, string secondStr)
        {
            Console.WriteLine("First string is: {0} and the second is: {1}", firstStr, secondStr);
        }

    }
}
