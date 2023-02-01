namespace Task3;
class Program
    {

    /*Розширити консольний калькулятор з лекції 12. Додати операцію
    обчислення остачі від ділення цілих чисел (%).
    Результати вивести на консоль. Вставити обробку помилок.
    Перевірити всі можливі варіанти.*/
    static void Main(string[] args)
        {
        string str;
        double result;
        do
            {
            Console.WriteLine("Введіть арифметичний вираз");
            str = Console.ReadLine();
            try
                {
                if (str.Length == 0)
                    {
                    throw new Exception("Нічого не введено! Введіть правильний вираз.");
                    }
                string[] split = str.Split(new Char[] { ' ', '*', '+', '-', '/', '%' }, System.StringSplitOptions.RemoveEmptyEntries);
                int i = 0;
                double[] digit = new double[2];
                foreach (string s in split)
                    {
                    if (double.TryParse(s, out digit[i]))
                        i++;
                    else
                        throw new Exception("Помилка у виразі");
                    }
                char[] array0p = new char[5] { '*', '+', '-', '/', '%' };
                string op = "";
                foreach (char c in array0p)
                    {
                    int indexop = str.IndexOf(c);
                    if (indexop != -1)
                        {
                        op = str[indexop].ToString();
                        break;
                        }

                    }
                Console.WriteLine($"op = {op}");
                if (op.Length == 0)
                    {
                    throw new Exception("Операція не знайдена у виразі");
                    }
                switch (op)
                    {
                    case ("+"):
                        result = digit[0] + digit[1];
                        break;
                    case ("-"):
                        result = digit[0] - digit[1];
                        break;
                    case ("/"):
                        result = digit[0] / digit[1];
                        break;
                    case ("*"):
                        result = digit[0] * digit[1];
                        break;
                    case ("%"):
                        result = digit[0] % digit[1];
                        break;
                    default:
                        throw new Exception("Невідома операція");
                    }
                Console.WriteLine("аргумент1 = {0},операція = {1},аргумент2 = {2}", digit[0], op, digit[1]);
                Console.WriteLine("Результат = " + Math.Round(result, 2));
                }
            catch (Exception e)
                {
                Console.WriteLine("Помилка у вхідних даних." + e.Message);
                }
            Console.WriteLine("Для завершення роботи введіть exit");
            } while (Console.ReadLine() != "exit");
        }
    }