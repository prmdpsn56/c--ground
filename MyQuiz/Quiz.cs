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

    
    public void StartQuiz(){
        System.Console.WriteLine("Welcome to the Quiz!");
        int questionNumber = 1;

        foreach (var question in questions)
        {
            int userChoice = 0;
            Console.WriteLine($"Question:  {questionNumber++}");
            DisplayQuestion(question);
            userChoice = GetUserChoice();
            if(question.IsCorrectAnswer(userChoice)){
                System.Console.WriteLine("correct!");
            }else{
                System.Console.WriteLine($"wrong! the correct answer is :{question.Answers[question.CorrectAnswerIndex]}");
            }
        }
    }

    private void DisplayQuestion (Question question){
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
    }


    private int GetUserChoice(){
        System.Console.WriteLine("Please Enter Your answer (in number)");
        string input = Console.ReadLine();
        int choice = 0;
        while(!int.TryParse(input,out choice) || choice < 1 || choice > 4){
            Console.WriteLine("Invalid selecton,Please select values in 1 and 4");
            input = Console.ReadLine();
        }
        return choice - 1; //adjust to zerio indexing
    }
}
