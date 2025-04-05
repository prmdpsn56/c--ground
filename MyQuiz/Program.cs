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
                    ),
                     new Question("what is the capital of India?", new string[] {
                        "delhi","punjab","kolkata"},
                        0
                    ),
                     new Question("what 2 +2?", new string[] {
                        "1","2","3","4"},
                        3
                    )
                };

            Quiz myquiz = new Quiz(questions);


            myquiz.StartQuiz();
            // myquiz.DisplayQuestion(questions[0]);

            // Console.ReadLine();
            
            // Console.WriteLine("Hello World!");
        }
    }
}