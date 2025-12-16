using System;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Розділяємо ввід, використовуючи ВСІ МОЖЛИВІ РОЗДІЛЬНИКИ
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            Gandalf gandalf = new Gandalf();

            foreach (string foodName in input)
            {
                Food food = FoodFactory.GetFood(foodName);
                gandalf.Eat(food);
            }

            Mood mood = gandalf.GetMood();

            // Вивід результату
            Console.WriteLine(gandalf.HappinessPoints);
            Console.WriteLine(mood.Name);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Системна помилка: {ex.Message}");
        }
        finally
        {
            // Рядок для зупинки консолі після виводу
            Console.WriteLine("\nНатисніть Enter для завершення...");
            Console.ReadLine();
        }
    }
}