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
        String fullName = "Alfahrel Rifananda";
        String phoneNumber = "+628-9231-7498";

        //fullName = fullName.ToUpper();
        //fullName = fullName.ToLower();

        //Console.WriteLine(fullName);

        //phoneNumber = phoneNumber.Replace("-", "");
        //Console.WriteLine(phoneNumber.Length);

        //String userName = fullName.Insert(0, "Mr. ");
        //Console.WriteLine(userName);

        String firstName = fullName.Substring(0, 8);
        String lastName = fullName.Substring(9, 9);

        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        Console.ReadKey();


    }
}