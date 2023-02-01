using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Task2;
class Program
{
    /*Написати Програму перевірки полів з використанням регулярних
    виразів. Про себе ввести такі дані: Прізвище (від 3 до 20 символів),
    номер телефону, email, рік народження (4 цифри).
    Результати вивести на консоль. Вставити обробку помилок.
    Перевірити всі можливі варіанти.*/

    static void Main()
    {
        try
        {
            string name = "Бугай";
            Regex reg1 = new Regex(@"(^[А-ЯЁІ]{1}[а-яёії]{2,20})");
            if (!reg1.IsMatch(name))
            {
                throw new Exception("Помилка введення прізвища.");
            }

            string phone = "0501234567";
            Regex reg2 = new Regex(@"^(\d{10}$)");
            if (!reg2.IsMatch(phone))
            {
                throw new Exception("Помилка телефону");
            }

            string email = "abc@gmail.com";
            Regex reg3 = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!reg3.IsMatch(email))
            {
                throw new Exception("Помилка email");
            }

            string birth = "1990";
            Regex reg4 = new Regex(@"^(\d{4}$)");
            if (!reg4.IsMatch(birth))
            {
                throw new Exception("Помилка року");
            }

            Console.WriteLine($"Прізвище: {name}\nНомер {phone}\nemail {email}\nВік {birth}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Main();
        }
    }
}