using System;
using System.Reflection.PortableExecutable;

namespace MyQuiz;

public class Quiz
{

    public Question[] questions;

    public Quiz( Question[] questions)
    {
        this.questions = questions;
    }


    public void DisplayQuestion (Question question){
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine(question.QuestionText);

        for (var i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.Write("  ");
            System.Console.Write(i+1);
            System.Console.ResetColor();
            System.Console.WriteLine($". {question.Answers[i]}");
        }

        if( GetUserChoice()== question.CorrectAnswerIndex){
            Console.WriteLine("Correct");
        }else {
            Console.WriteLine("incorrect");
        }
    }


    private int GetUserChoice(){
        System.Console.WriteLine("Your andwer (number)");
        string input = Console.ReadLine();
        int choice = 0;
        while(!int.TryParse(input,out choice) || choice < 1 || choice > 4){
            Console.WriteLine("Invalid selecton,Please select values in 1 and 4");
            input = Console.ReadLine();
        }

        return choice - 1; //adjust to zerio indexing
    }
}
