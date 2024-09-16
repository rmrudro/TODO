// See https://aka.ms/new-console-template for more information


int[,] array = new int[,]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 },
    { 7, 8, 9 }
};

int width = array.GetLength(0);
int height = array.GetLength(1);

Console.WriteLine("The Width is " + width);
Console.WriteLine("The Height is " + height);


//Console.WriteLine("Hello \nInput the First Number");

//var a = Console.ReadLine();
//var number1=int.Parse(a);
//Console.WriteLine("Input Second Number");
//var b = Console.ReadLine();
//var number2=int.Parse(b);

//Console.WriteLine("What do you want to do with this number \n(A) Add \n" +
//    "S) Subtract \nM) Multiply ");
//string operationinput = Console.ReadLine();

//int result;
//if(operationinput.ToUpper() == "A")
//{
//    result = number1 + number2;
//    Sum(number1, number2, result, "+");

//}
//else if (operationinput.ToUpper() == "S")
//{
//    result = number1 - number2;
//    Subtration(number1, number2, result, "-");
//}
//else if (operationinput.ToUpper() == "M")
//{
//    result = number1 * number2;
//    Multiplication(number1, number2, result, "*");
//}




//void Sum(int number1, int number2,int result,string @operator )
//{
//    Console.WriteLine($"The {@operator} result of {number1} and {number2} is {result}");
//}
//void Subtration(int number1, int number2,int result , string @operator)
//{
//    Console.WriteLine($"The {@operator} result of {number1} and {number2} is {result}");
//}
//void Multiplication(int result1,int result2,int result, string @operator)
//{
//    Console.WriteLine($"The {@operator} result of {number1} and {number2} is {result}");
//}



