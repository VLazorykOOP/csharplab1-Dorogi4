using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Виберіть завдання:");
        Console.WriteLine("1. Обчислити ребро куба за об'ємом");
        Console.WriteLine("2. Перевірити, чи є сума цифр двозначного числа непарною");
        Console.WriteLine("3. Перевірити, чи знаходиться точка під певною лінією");
        Console.WriteLine("4. Знайти невідому дату");
        Console.WriteLine("5. Піднести суму двох чисел до квадрата");
        Console.WriteLine("6. Обчислити значення виразу");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateCubeSideLength();
                break;
            case 2:
                CheckSumOfTwoDigitNumber();
                break;
            case 3:
                CheckPointBelowLine();
                break;
            case 4:
                FindUnknownDate();
                break;
            case 5:
                SquareOfSum();
                break;
            case 6:
                CalculateExpressionValue();
                break;
            default:
                Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                break;
        }

        Console.ReadLine(); // Щоб консольне вікно не закрилося одразу
    }

    static void CalculateCubeSideLength()
    {
        Console.WriteLine("Введіть об'єм куба:");
        double volume = Convert.ToDouble(Console.ReadLine());

        // Обчислюємо довжину ребра куба
        double sideLength = Math.Pow(volume, 1.0 / 3.0);

        Console.WriteLine($"Довжина ребра куба: {sideLength}");
    }

    static void CheckSumOfTwoDigitNumber()
    {
        Console.WriteLine("Введіть двозначне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int digit1 = number / 10; // Перша цифра числа
        int digit2 = number % 10; // Друга цифра числа
        int sum = digit1 + digit2; // Сума цифр

        if (sum % 2 != 0)
        {
            Console.WriteLine("Сума цифр є непарною.");
        }
        else
        {
            Console.WriteLine("Сума цифр є парною.");
        }
    }

    static void CheckPointBelowLine()
    {
        Console.Write("Введіть координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (y < -100 || y > 0)
        {
            Console.WriteLine("Ні");
        }
        else if (y == -100 || y == -Math.Abs(x))
        {
            Console.WriteLine("На межі");
        }
        else if (y > -Math.Abs(x))
        {
            Console.WriteLine("Ні");
        }
        else
        {
            Console.WriteLine("Так");
        }
    }

    static void FindUnknownDate()
    {
        Console.Write("Введіть кількість днів, що пройшли після певної дати: ");
        int daysPassed = Convert.ToInt32(Console.ReadLine());

        // Початкова дата
        DateTime startDate = new DateTime(2024, 1, 1);

        // Додаємо дні до початкової дати
        DateTime unknownDate = startDate.AddDays(daysPassed);

        Console.WriteLine($"Невідома дата: {unknownDate.ToString("yyyy-MM-dd")}");
    }

    static void SquareOfSum()
    {
        Console.Write("Введіть перше число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;
        int squareOfSum = sum * sum;

        Console.WriteLine($"Квадрат суми {num1} і {num2}: {squareOfSum}");
    }

    static void CalculateExpressionValue()
    {
        Console.Write("Введіть значення a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Перевірка, щоб уникнути ділення на нуль
        if (b == 0 || a == b || a + b == 0)
        {
            Console.WriteLine("Ділення на нуль не можливе.");
        }
        else
        {
            double result = 5 + (b / (b * b + 1)) + (a - b) - (1 / (a + b));
            Console.WriteLine($"Значення виразу: {result}");
        }
    }
}
