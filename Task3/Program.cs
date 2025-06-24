using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
    /*
     Задание 3
Создайте приложения для выполнения арифметических операций. Поддерживаемые операции:
■ Проверка числа на чётность;
■ Проверка числа на нечётность;
Практическое задание
1
■ Проверка является ли число простым;
■ Проверка является ли число числом Фибоначчи.
Обязательно используйте делегат типа Predicate.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 15;

            Arifmetic.IsNum(num, Arifmetic.IsEven, "Чётность");
            Arifmetic.IsNum(num, Arifmetic.IsOdd, "Нечётность");
            Arifmetic.IsNum(num, Arifmetic.IsPrime, "Простое число");
            Arifmetic.IsNum(num, Arifmetic.IsFibonacci, "Число Фибоначчи");
            
            //можно и так
            Predicate<int> isEven = Arifmetic.IsEven;
            bool result = isEven.Invoke(num); // вызов через Invoke

            Console.WriteLine("Число: {0}\n",result ?$"Четное":"Нечетное");

        }
    }
}
