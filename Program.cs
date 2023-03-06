////////  Seyed Erfan Noorbakhsh  ///////

////////  Seyed Erfan Noorbakhsh  ///////
ConsoleKeyInfo key;
int number;


do
{
    number = 0;

    Console.WriteLine("Enter your score at programming exam: ");
    getnumber();


    if (17 < number & number <= 20)
    {
        Console.WriteLine("You are a good student and your rank is A . Thank you for your attempt. ");
    }
    else if (15 < number & number <= 17)
    {
        Console.WriteLine("Your rank is B . Your score is in the avrage of the class. ");
    }
    else if (10 <= number & number <= 15)
    {
        Console.WriteLine("You are rank C . ");
    }
    else if (0 <= number & number < 10)
    {
        Console.WriteLine("You failed Do your best next time. ");
    }
    int percent = number * 5 / 1;
    Console.WriteLine("Your score in percent is: " + percent + "%");

    Console.WriteLine("do you want to enter another number ? (y/n)");
    key = Console.ReadKey(true);
    // going to next line command is below //
    Console.WriteLine();



} while (key.KeyChar != 'N' && key.KeyChar != 'n');

Console.WriteLine("thanks for your time... ");
////////////////...........Methods.........///////////////////

void getnumber()
{
    while (true)
    {
        key = Console.ReadKey(true);

        if (char.IsDigit(key.KeyChar))
        {
            number = number * 10 + (int)char.GetNumericValue(key.KeyChar);
            Console.Write(key.KeyChar);

        }
        else
        {
            Console.Beep();
        }
        /////.............. clicking on enter button......../////////////
        if (key.Key == ConsoleKey.Enter)
        {
            Console.WriteLine();
            break;
        }



    }
}