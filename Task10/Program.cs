// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

namespace HelloWorld 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            string str = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine($"{str[1]}");
        } 
    } 
}