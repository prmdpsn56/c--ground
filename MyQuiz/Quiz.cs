using System;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace MyQuiz;

public class Quiz
{

    private Question[] _questions;
    private int _score;
    

    public Quiz( Question[] questions)
    {
        this._questions = questions;
        _score = 0;
    }

    
    public void StartQuiz(){
        System.Console.WriteLine("Welcome to the Quiz!");
        int questionNumber = 1;

        foreach (var question in _questions)
        {
            int userChoice = 0;
            Console.WriteLine($"Question:  {questionNumber++}");
            DisplayQuestion(question);
            userChoice = GetUserChoice();
            if(question.IsCorrectAnswer(userChoice)){
                System.Console.WriteLine("correct!");
                _score++;
            }else{
                System.Console.WriteLine($"wrong! the correct answer is :{question.Answers[question.CorrectAnswerIndex]}");
            }
        }

        this.DisplayResult();
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


    private void DisplayResult(){
        System.Console.WriteLine("Quiz finished and your score is as below");
        System.Console.WriteLine($"Your Score is _ {_score} out of {_questions.Length}");


        double percentage = ((double)_score / _questions.Length) * 100;

        if(percentage > 50 ){
            Console.ForegroundColor = ConsoleColor.Green;
        }else{
            Console.ForegroundColor = ConsoleColor.Red;
        }
        System.Console.WriteLine($"Your Scoring percentage is {percentage}");
    }
}
