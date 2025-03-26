

int AddTwoValues(int value1, int value2){
    int result = value1 + value2;
    System.Console.WriteLine(result);
    return result;
}

int first_number = int.Parse(Console.ReadLine());
int second_number = int.Parse(Console.ReadLine());

var result = AddTwoValues(first_number,second_number);
System.Console.WriteLine("result from the values entered by the user " + result);