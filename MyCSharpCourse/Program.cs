// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

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
        /*
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
        */

        // ! 18.
        // * Number guessing game
        /*
        Random rand = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int number;
        int guess;
        int attempts;
        String response;

        while (playAgain)
        {
            number = rand.Next(min, max + 1);
            guess = 0;
            attempts = 0;

            System.Console.WriteLine("=====================================");
            System.Console.WriteLine("Welcome to the Number Guessing Game!");
            System.Console.WriteLine("=====================================");
            System.Console.WriteLine("I'm thinking of a number between " + min + " and " + max);
            while (guess != number)
            {
                System.Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess < number)
                {
                    System.Console.WriteLine("Too low! Try again.");
                }
                else if (guess > number)
                {
                    System.Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    System.Console.WriteLine(
                        "Congratulations! You've guessed the number "
                            + number
                            + " in "
                            + attempts
                            + " attempts."
                    );
                }
            }

            System.Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                playAgain = false;
                System.Console.WriteLine("Thank you for playing! Goodbye!");
            }
        }
        */

        // ! 19.
        // * Rock Paper Scissors Game
        /*
        Random rand = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string answer;

        while (playAgain)
        {
            int randNum = rand.Next(1, 4);
            player = "";
            computer = "";
            answer = "";

            System.Console.WriteLine("=================================");
            System.Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            System.Console.WriteLine("=================================");
            switch (randNum)
            {
                case 1:
                    computer = "rock";
                    break;
                case 2:
                    computer = "paper";
                    break;
                case 3:
                    computer = "scissors";
                    break;
                default:
                    computer = "rock";
                    break;
            }

            System.Console.Write("Enter rock, paper, or scissors: ");
            player = Console.ReadLine().ToLower();

            switch (player)
            {
                case "rock":
                    System.Console.WriteLine("Computer chose " + computer);
                    if (computer == "rock")
                    {
                        System.Console.WriteLine("It's a tie!");
                    }
                    else if (computer == "paper")
                    {
                        System.Console.WriteLine("You lose!");
                    }
                    else
                    {
                        System.Console.WriteLine("You win!");
                    }
                    break;
                case "paper":
                    System.Console.WriteLine("Computer chose " + computer);
                    if (computer == "rock")
                    {
                        System.Console.WriteLine("You win!");
                    }
                    else if (computer == "paper")
                    {
                        System.Console.WriteLine("It's a tie!");
                    }
                    else
                    {
                        System.Console.WriteLine("You lose!");
                    }
                    break;
                case "scissors":
                    System.Console.WriteLine("Computer chose " + computer);
                    if (computer == "rock")
                    {
                        System.Console.WriteLine("You lose!");
                    }
                    else if (computer == "paper")
                    {
                        System.Console.WriteLine("You win!");
                    }
                    else
                    {
                        System.Console.WriteLine("It's a tie!");
                    }
                    break;
                default:
                    System.Console.WriteLine("Invalid input! You get rock by default.");
                    break;
            }

            System.Console.Write("Do you want to play again? (yes/no): ");
            answer = Console.ReadLine().ToLower();
            if (answer != "yes")
            {
                playAgain = false;
                System.Console.WriteLine("Thank you for playing! Goodbye!");
            }
        }
        */

        // ! 20.
        // * Simple Calculator Program
        /*
        do
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            System.Console.WriteLine("=================================");
            System.Console.WriteLine("Welcome to the Simple Calculator!");
            System.Console.WriteLine("=================================");
            System.Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Choose an operation:");
            System.Console.WriteLine("\t Addition (+)");
            System.Console.WriteLine("\t Subtraction (-)");
            System.Console.WriteLine("\t Multiplication (*)");
            System.Console.WriteLine("\t Division (/)");
            System.Console.Write("Enter your choice : ");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    System.Console.WriteLine("Result: " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    System.Console.WriteLine("Result: " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    System.Console.WriteLine("Result: " + result);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        System.Console.WriteLine("Result: " + result);
                    }
                    else
                    {
                        System.Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    System.Console.WriteLine("Invalid operation! Please try again.");
                    break;
            }
            System.Console.Write("Would you like to perform another calculation? (Y/N): ");
        } while (Console.ReadLine().ToLower() == "y");
        System.Console.WriteLine("Thank you for using the calculator! Goodbye!");
        */

        // ! 21.
        // * Array
        // Declare empty array (fixed size)
        /*
        String[] cars = new String[3];
        cars[0] = "BMW";
        cars[1] = "Mustang";
        cars[2] = "Ford";
        */
        // String[] cars = { "BMW", "Mustang", "Ford" };

        // Replace element
        // cars[0] = "Lamborghini";

        /*
        System.Console.WriteLine(cars[0]);
        System.Console.WriteLine(cars[1]);
        System.Console.WriteLine(cars[2]);
        */

        // Using loops to iterate through array
        /*
        for (int i = 0; i < cars.Length; i++)
        {
            System.Console.WriteLine(cars[i]);
        }
        */

        // ! 22.
        // * Foreach loop
        /*
        String[] cars = { "BMW", "Mustang", "Ford" };

        foreach (String car in cars)
        {
            System.Console.WriteLine(car);
        }
        */

        // ! 23.
        // * Methods
        /*
        String name = "Fahrel";
        int age = 20;

        String dude = "Spongebob";
        int dudeAge = 28;

        String anotherDude = "Patrick";
        int anotherDudeAge = 32;

        singHappyBirthday(name, age);
        singHappyBirthday(dude, dudeAge);
        singHappyBirthday(anotherDude, anotherDudeAge);
        */

        // ! 24.
        // * Return keyword
        /*
        double x;
        double y;
        double result;

        System.Console.Write("Enter first number: ");
        x = Convert.ToDouble(Console.ReadLine());

        System.Console.Write("Enter second number: ");
        y = Convert.ToDouble(Console.ReadLine());

        result = multiplyNumbers(x, y);
        System.Console.WriteLine(result);
        */

        // ! 25.
        // * Method Overloading = same method name, different parameters
        /*
        System.Console.WriteLine(multiplyNum(2, 4));
        System.Console.WriteLine(multiplyNum(2, 4, 6));
        */

        // ! 26.
        // * Params keyword = pass multiple arguments into a method
        /*
        double price1 = 4.99;
        double price2 = 5.49;
        double price3 = 1.99;

        System.Console.WriteLine(checkout(price1, price2, price3));
        */

        // ! 27.
        // * Exception Handling
        /*
        double x;
        double y;
        double result;

        try
        {
            System.Console.Write("Enter the first number : ");
            x = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("Enter the second number : ");
            y = Convert.ToDouble(System.Console.ReadLine());

            result = x / y;
            System.Console.WriteLine("Result : " + result);
        }
        catch (System.Exception)
        {
            System.Console.WriteLine("Something went wrong");
        }
        finally
        {
            System.Console.WriteLine("Finished");
        }
        */

        // ! 28.
        // * Condition Operator
        /*
        double temperature = 23;
        string message;

        if (temperature >= 30)
        {
            message = "Its warm outside";
        }
        else
        {
            message = "Its cold outside";
        }

        System.Console.WriteLine(message);
        */

        // Shortcut / Conditional Operator
        double temperature = 29;
        string message;
        message = (temperature >= 30) ? "Its warm outside" : "Its cold outside";
        System.Console.WriteLine(message);

        // More short
        System.Console.WriteLine((temperature >= 30) ? "Its warm outside" : "Its cold outside");
    }

    static double checkout(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }

    static double multiplyNum(double a, double b)
    {
        double z = a * b;
        return z;
    }

    static double multiplyNum(double a, double b, double c)
    {
        double z = a * b * c;
        return z;
    }

    // To use return keyword, change void to datatype
    static double multiplyNumbers(double a, double b)
    {
        double z = a * b;
        return z;
    }

    static void singHappyBirthday(String n, int a)
    {
        System.Console.WriteLine("Happy birthday to you");
        System.Console.WriteLine("Happy birthday to you");
        System.Console.WriteLine("Happy birthday dear " + n);
        System.Console.WriteLine("Happy birthday to you");
        System.Console.WriteLine("You are now " + a + " years old!");
    }
}
