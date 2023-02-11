//Задача №1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Exponentiation(int number, int degree)
{
int result = 1;
while (degree>0)
{
  result = result*number;
  degree--;
}
return result;
}
Console.WriteLine("Input number: ");
int newnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input degree: ");
int newdegree = Convert.ToInt32(Console.ReadLine());
int newresult = Exponentiation(newnumber, newdegree);
Console.WriteLine($"The {newnumber} to the power of {newdegree} is {newresult}");
*/
//===========================================================================================
// Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber(int number)
{
  int Sum = 0;
  while (number!=0)
    {
      Sum = Sum + number%10;
      number = number/10;
    }
    return Sum;
}
Console.WriteLine("Input number: ");
int newnumber = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(newnumber);
Console.WriteLine($"Sum of elements form 1 to {newnumber} is {result}");
*/
//===============================================================================
// Задача №3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Enter array[{i}]: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Enter array size: ");
int NewArraySize = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(NewArraySize);
ShowArray(array);
*/