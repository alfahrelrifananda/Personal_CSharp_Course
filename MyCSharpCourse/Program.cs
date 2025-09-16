// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(String[] args)
    {
        // ! 1.
        // * Console.Write : Displaying output
        /*
        Console.WriteLine("This");
        Console.WriteLine("is");
        Console.WriteLine("Very");
        Console.WriteLine("Nice");
        */

        // * Console.Write : Outputing sound
        /*
        Console.Beep();
        */

        // ! 2.
        // * Comment and escape sequence
        /*
        Console.Write("Hey!");
        Console.WriteLine("Hello");
        */

        // This is a comment
        /*
        This
        is
        a
        multiline
        comment
        */

        // * Escape Sequence
        /*
        Console.WriteLine("\t This is would have a tab");
        Console.ReadKey();
        */

        // ! 3.
        // * Variable
        /*
        String name = "Fahrel";
        int age = 20;
        double height = 174.3;
        bool isAlive = true;
        char symbol = '@';

        System.Console.WriteLine("Hello " + name);
        System.Console.WriteLine("You are " + age + " years old");
        System.Console.WriteLine("Your height is " + height + " cm");
        System.Console.WriteLine("Are you alive? " + isAlive);
        System.Console.WriteLine("Your symbol is " + symbol);

        String userName = symbol + name;
        System.Console.WriteLine("Your username is " + userName);
        */

        // ! 4.
        // * Const
        /*
        const double pi = 3.14;
        System.Console.WriteLine(pi);
        */

        // ! 5.
        // * type casting = convert datatype
        /*
        double a = 3.14;
        int b = Convert.ToInt32(a);

        int c = 5;
        double d = Convert.ToDouble(c);

        int e = 425;
        String f = Convert.ToString(e);

        String g = "@";
        char h = Convert.ToChar(g);

        String i = "false";
        bool j = Convert.ToBoolean(i);

        System.Console.WriteLine(b.GetType());
        System.Console.WriteLine(d.GetType());
        System.Console.WriteLine(f.GetType());
        System.Console.WriteLine(h.GetType());
        System.Console.WriteLine(j.GetType());
        */

        // ! 6.
        // * Accept user Input
        /*
        System.Console.WriteLine("What is your name?");
        String name = Console.ReadLine();

        System.Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Hello " + name);
        System.Console.WriteLine("You are " + age + " years old");
        */

        // ! 7.
        // * Basic Aritmatics
        // int friends = 6;

        // friends = friends + 1;
        // friends += 1;
        // friends++;

        // friends = friends - 1;
        // friends -= 1;
        // friends--;

        // friends = friends * 2;
        // friends *= 2;

        // friends = friends / 2;
        // friends /= 2;

        // friends = friends % 5;
        // friends %= 5;

        // System.Console.WriteLine(friends);

        // ! 8.
        // * Math Class
        /*
        double x = 3.14;
        double y = 4.54;

        // * Pangkat
        double a = Math.Pow(x, 2);
        // * Akar
        double b = Math.Sqrt(x);
        // * Berapa dari 0
        double c = Math.Abs(x);
        // * Membulatkan
        double d = Math.Round(x);
        // * Membulatkan keatas
        double e = Math.Ceiling(x);
        // * Membulatkan kebawah
        double f = Math.Floor(x);
        // * Mengambil yang terkecil
        double g = Math.Min(x, y);
        // * Mengambil yang terbesar
        double h = Math.Max(x, y);

        System.Console.WriteLine(h);
        */

        // ! 9.
        // *  Random
        /*
        Random rand = new Random();

        int num1 = rand.Next(1, 7);
        int num2 = rand.Next(1, 7);
        int num3 = rand.Next(1, 7);
        //double numD = rand.NextDouble();

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
        //Console.WriteLine(numD);
        */

        // ! 10.
        // * Find Hypotenuse of triangle
        /*
        Console.Write("Enter side A : ");
        double a = Convert.ToDouble(Console.ReadLine());


        Console.Write("Enter side B : ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt((a * a) + (b * b));

        Console.WriteLine("The hypotenuse is : " + c);
        */

        // ! 11.
        // * String methods
        // String fullName = "Alfahrel Rifananda";
        // String phoneNumber = "+628-9231-7498";

        //fullName = fullName.ToUpper();
        //fullName = fullName.ToLower();

        //Console.WriteLine(fullName);

        //phoneNumber = phoneNumber.Replace("-", "");
        //Console.WriteLine(phoneNumber.Length);

        //String userName = fullName.Insert(0, "Mr. ");
        //Console.WriteLine(userName);

        // String firstName = fullName.Substring(0, 8);
        // String lastName = fullName.Substring(9, 9);

        // Console.WriteLine(firstName);
        // Console.WriteLine(lastName);

        // ! 12.
        // * IF Statement
        /*
        System.Console.Write("Enter your name : ");
        String name = Console.ReadLine();

        System.Console.Write("Enter your age : ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (name == "")
        {
            System.Console.WriteLine("You didn't enter your name");
        }
        else
        {
            System.Console.WriteLine("Hello " + name);
        }

        if (age > 100)
        {
            System.Console.WriteLine("You are too old to sign up!");
        }
        else if (age >= 18)
        {
            System.Console.WriteLine("You are signed up!");
        }
        else if (age < 0)
        {
            System.Console.WriteLine("You haven't been born yet");
        }
        else
        {
            System.Console.WriteLine("You need to be at least 18 to sign up");
        }
        */

        // ! 13.
        // * Switch Statement
        /*
        System.Console.Write("What day is today? : ");
        String day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                System.Console.WriteLine("It's Monday");
                break;
            case "Tuesday":
                System.Console.WriteLine("It's Tuesday");
                break;
            case "Wednesday":
                System.Console.WriteLine("It's Wednesday");
                break;
            case "Thursday":
                System.Console.WriteLine("It's Thursday");
                break;
            case "Friday":
                System.Console.WriteLine("It's Friday");
                break;
            case "Saturday":
                System.Console.WriteLine("It's Saturday");
                break;
            case "Sunday":
                System.Console.WriteLine("It's Sunday");
                break;
            default:
                System.Console.WriteLine(day + " is not a day!");
                break;
        }
        */

        // ! 14.
        // * Logical Operator
        /*
        System.Console.Write("What's the temperature outside? (celcius) : ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (temperature >= 0 && temperature <= 30)
        {
            System.Console.WriteLine("The temperature is good today");
        }
        else if (temperature < 0 || temperature > 30)
        {
            System.Console.WriteLine("The temperature is bad today");
        }
        else
        {
            System.Console.WriteLine("Uhh... I don't know what the temperature is");
        }
        */

        // ! 15.
        // * While loops
        /*
        int attempt = 0;
        System.Console.Write("Enter your name : ");
        String name = Console.ReadLine();

        while (name == "")
        {
            attempt++;
            if (attempt >= 5)
            {
                System.Console.WriteLine("Stop being annoying!");
            }
            else
            {
                System.Console.WriteLine("You didn't enter your name");
            }
            System.Console.Write("Enter your name : ");
            name = Console.ReadLine();
        }

        if (attempt >= 5)
        {
            System.Console.WriteLine("There you go...");
        }
        System.Console.WriteLine("Hello " + name);
        */

        // ! 16.
        // * For loops
        /*
        for (int i = 1; i <= 10; i++)
        {
            System.Console.WriteLine("This will repeat 10 times");
            System.Console.WriteLine(i);
        }

        System.Console.WriteLine("==============================");

        for (int i = 1; i <= 10; i += 2)
        {
            System.Console.WriteLine("This will repeat 5 times");
            System.Console.WriteLine(i);
        }


        System.Console.WriteLine("==============================");

        for (int i = 1; i <= 10; i += 3)
        {
            System.Console.WriteLine("This will repeat 4 times");
            System.Console.WriteLine(i);
        }
        System.Console.WriteLine("==============================");

        for (int i = 10; i >= 1; i--)
        {
            System.Console.WriteLine("This will repeat 10 times but backwards");
            System.Console.WriteLine(i);
        }

        System.Console.WriteLine("Happy New Year!");
        */

        // ! 17.
        // * Nested loops
        System.Console.Write("How many rows? : ");
        int rows = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("How many columns? : ");
        int columns = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("What symbol? : ");
        char symbol = Convert.ToChar(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                System.Console.Write(symbol);
            }
            System.Console.WriteLine();
        }
    }
}
