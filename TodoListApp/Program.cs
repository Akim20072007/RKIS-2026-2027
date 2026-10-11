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
            string[] todos = new string[2];
            int taskCount = 0;
            Console.WriteLine("Добро пожаловать в TodoList! Введите help для отображения списка команд.");
            while (true)
            {
                Console.Write("\n> ");
                string input = Console.ReadLine();
                string[] parts = input.Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 0)
                    continue;
                string command = parts[0].ToLower();
                string argument = parts.Length > 1 ? parts[1] : "";
                if (command == "exit")
                {
                    Console.WriteLine("Завершение работы программы.");
                    return;
                }
                else
                {
                    Console.WriteLine($"Команда '{command}' принята. Аргумент: '{argument}'");
                }
            }
        }
    }
}