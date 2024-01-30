
using Lab2Class;


// Juan Benitez | Tech4982-01 | Lab#2


{

    //Integers
    Console.Write("How many integers are you providing?: ");
    double num = double.Parse(Console.ReadLine());

    Console.Write("Enter the first number: ");
    double number1 = double.Parse(Console.ReadLine());


    Console.Write("Enter the second number: ");
    double number2 = double.Parse(Console.ReadLine());

    if (num==3)
    
    {
        Console.Write("Enter the third number: ");
        double number3 = double.Parse(Console.ReadLine());

        

        Console.Write("The Minimum of " + number1 + " , " + number2 + " and " + number3 + " is " + Class1.Min(number1, number2,number3));


    }

    if (num == 2)
    {

        Console.Write("The Minimum of " + number1 + " and " + number2 + " is " + Class1.Min(number1, number2));

    }

}