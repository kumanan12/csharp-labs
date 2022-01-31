using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class StringDemo
    {

        public void RunDemo()
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] words = pangram.Split(' ');
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var word in words)
            {
                var reversedWord = ReverseWord(word);
                stringBuilder.Append(reversedWord);
                stringBuilder.Append(" ");

            }
            //string firstWord = words[0];
            //string reversedWord = ReverseWord(firstWord);
            //StringBuilder stringBuilder = ReverseWord(firstWord);
        }

        private object ReverseWord(string word)
        {
            throw new NotImplementedException();
        }
    }
}
