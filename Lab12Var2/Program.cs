namespace Lab12Var2;
class Program
{

    /*1.Написати програму Анкета студента.Ввести такі дані про себе:
        Прізвище, ім’я, група, курс (ціле число від 1 до 4), рейтинг(дійсне
        число від 0 до 100).
        Результати вивести на консоль.Вставити обробку помилок.
        Перевірити всі можливі варіанти.*/
    static void Main()
    {
        string mes = "Поле обовʼязкове для заповнення";
        try
        {

            Console.WriteLine("Введіть прізвище");
            string surname = Console.ReadLine();
            if (surname.Length == 0)
            {
                throw new Exception(mes);
            }
            if (!IsName(surname))
            {
                throw new Exception("Щось не те знову");
            }

            Console.WriteLine("Введіть імʼя");
            string name = Console.ReadLine();
            if (name.Length == 0)
            {
                throw new Exception(mes);
            }
            if (!IsName(name))
            {
                throw new Exception("Щось не те знову");
            }

            Console.WriteLine("Введіть номер групи");
            int group;
            if (int.TryParse(Console.ReadLine(), out group))
            {
                if ((group < 21 || group > 23))
                {
                    throw new Exception("Группа 21, 22, 23.");
                }
                else;
            }
            else throw new Exception("Потрібно ввести число");

            Console.WriteLine("Введіть курс");
            int course;
            if (int.TryParse(Console.ReadLine(), out course))
                {
                if ((course < 1 || course > 4))
                    {
                    throw new Exception("Курс 1, 2, 3, 4");
                    }
                else;
                }
            else throw new Exception("Потрібно ввести число");

            Console.WriteLine("Введіть рейтинг (від 0 до 100)");
            double rating;
            if (double.TryParse(Console.ReadLine(), out rating))
            {
                if ((rating < 0 || rating > 100))
                {
                    throw new Exception("Рейтинг має бути від 0 до 100");
                }
                else;
            }
            else throw new Exception("Потрібно ввести число від 0 до 100");

            Console.WriteLine($"Студент: {surname} {name}\nГрупа: {group}\nКурс: {course}\nРейтинг: {rating}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Main();
        }
    }

    static bool IsName(string name)
    {
        try
        {
            if (name.Length > 1 && name.Length <= 20)
            {
                if (char.IsUpper(name[0]))
                {
                    return true;
                }
                else
                {
                    throw new Exception("Перша літера має бути великою");
                }
            }
            else
            {
                throw new Exception("Ваше призвище занадто коротке або довге :)");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false; 
        }
    }
}