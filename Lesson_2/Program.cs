using System;
namespace Lesson_2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Есть ли у Вас питомец?");
            bool pet = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Какой у Вас размер ноги?");
            double foot = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My age is " + Convert.ToString(age));
            Console.WriteLine("Do I have a pet? " + Convert.ToString(pet));
            Console.WriteLine("My shoe size is " + Convert.ToString(foot));

        }
    }
}

/* using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string MyName = "Jane";
        byte MyAge = 27;
        bool HaveIApet = true;
        double MyShoeSize = 37.5;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("MyAge " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIApet);
        Console.WriteLine("My shoe size is " + MyShoeSize);

    }
}
*/