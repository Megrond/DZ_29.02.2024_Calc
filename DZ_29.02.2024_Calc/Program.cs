class Calculator
{
    static void Main()
    {
        double num1, num2, result;
        char op;

        Console.WriteLine("Введите первое число:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор (+, -, *, /):");
        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Результат: " + result);
                break;
            case '-':
                result = num1 - num2;
                Console.WriteLine("Результат: " + result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("Результат: " + result);
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Результат: " + result);
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль.");
                }
                break;
            default:
                Console.WriteLine("Ошибка: некорректный оператор.");
                break;
        }

        Console.ReadLine();
    }
}