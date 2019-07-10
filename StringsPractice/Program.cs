using System;
using System.Text;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Calvin";
            string faveColor = "blue";
            string cityOfBirth = "Ukiah";
            string introduction = "Hello, my name is " + name + ", my favorite color is " + faveColor + " and I was born in " + cityOfBirth;
            Console.WriteLine(introduction);


            string someWords = "Here is a sentence.";
            string someWordsButAngry = someWords.ToUpper();
            Console.WriteLine(someWordsButAngry);

            StringBuilder s = new StringBuilder("There's five sentences in a paragraph right? That's what they taught us in 6th grade?");
            s.Append("First sentence. ");
            s.Append("Second sentence. ");
            s.Append("Third sentence. ");
            s.Append("Fourth sentence. ");
            s.Append("Fifth sentence. ");
            s.Append("Give me my pulitzer.");
            Console.WriteLine(s);
        }
    }
}
