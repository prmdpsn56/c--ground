using System;

namespace MyQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Question[] questions =  new Question[]{
                    new Question("what is the capital of germany?", new string[] {
                        "paris","berlin","london","madrid"},
                        1
                    )
                };

            Quiz myquiz = new Quiz(questions);
            myquiz.DisplayQuestion(questions[0]);

            // Console.ReadLine();
            
            // Console.WriteLine("Hello World!");
        }
    }
}