int [] array1 = new int[5];
array1 = [1,2,3,4,5];

int [] array2 = [1,2,3,4,5,6];
int [,] array2d = {{1,2},{10,12}};
string [,] array22d = {
    {"x","x","x"},
    {"x","o","x"},
    {"x","x","x"}
    };

int [][] jaggedArray = [[12,3],[1,2,3,4,4]];

string [] weekdays = ["mon","tue","wed","thu","fri","sat","sun"];

// System.Console.WriteLine(array1[0]);
// System.Console.WriteLine(array2[5]);
// System.Console.WriteLine(weekdays[2]);
// System.Console.WriteLine("length of weekdays array is " + weekdays.Length);


// for(int i = 0; i < weekdays.Length; i++){
//     System.Console.WriteLine(weekdays[i]);
// }

// foreach(var day in weekdays){
//     System.Console.WriteLine(day);
// }


foreach(var item in array22d){
    System.Console.WriteLine(item);
}

// System.Console.WriteLine(array2d[1,1]);
// System.Console.WriteLine(jaggedArray[1][1]);