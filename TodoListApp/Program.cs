using System;
namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Работу выполнили Катмаков и Науменко.");
            Console.Write("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("Введите год рождения: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            Console.WriteLine($"Добавлен пользователь {firstName} {lastName}, возраст - {age}.");
            Console.ReadLine();
        }
    }
}