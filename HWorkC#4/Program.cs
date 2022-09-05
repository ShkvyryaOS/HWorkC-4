/*
// Напишите программу, которая на вход принимает число и выдает сумму цифр в этом числе

int SumDigit(int num)
{
 
   int result=0;
  
   while (num>0 )
   {result=result+num%10;
   num=num/10;
   
   }

return result;
}
Console.WriteLine("Input positive integer number");
int num= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digit {num} is {SumDigit(num)}");
*/


/*
 //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
 int DegreeNum( int a, int b)
 {
    int result=1;
    for (int current=1; current<=b; current++)
    result*=a;
 return result;
 }
Console.WriteLine("Input positive integer number A");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input positive integer number В");
int b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A={a} to the power of B={b} is {DegreeNum(a,b)}");
*/
/*
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray(int n)
 {
    int [] arr= new int [n];
    for (int i=0; i<=n-1; i++)
    {
         Console.WriteLine($"Введите {i+1} элемент массива");
         arr[i]= Convert.ToInt32(Console.ReadLine());
        
            }
 return arr;
 }
void PrintArray (int[] arr)
{
    Console.Write ("[");
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write ($"{arr[i]} ");
        }
    Console.WriteLine("]");
}
Console.WriteLine($"Введите количество элементов массива");
int n=Convert.ToInt32(Console.ReadLine());
PrintArray(CreateArray(n));
*/
