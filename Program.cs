// Andrew Nilsson
//0 9-13-2022
// Mini Challenge #6 - Odd or Even
// This is a console project that will take a users input and check if it is a number and if it's a number
// it will check if it is an odd or even number and out whether it is odd or even
// Peer Review by: Jessie Lamzon - Code is working!


string? playInput;
string? input;
int number, remainder;
bool validNum;

Console.Clear();

bool play = true;
while (play)
{
    Console.WriteLine("Enter a number to see if it is odd or even");

    input = Console.ReadLine();

    validNum = int.TryParse(input, out number);

    if (validNum)
    {
        remainder = number % 2;

        if (remainder == 0)
        {
            Console.WriteLine("Your number is even");
        }
        else
        {
            Console.WriteLine("Your number is odd");
        }

        Console.WriteLine("Do you want to enter another number? Yes or No?");
        bool validPlay = false;
        while (!validPlay)
        {
            playInput = Console.ReadLine().ToLower();

            switch (playInput)
            {
                case "yes":
                    validPlay = true;
                break;
                case "no":
                    validPlay = true;
                    play = false;
                    Console.WriteLine("Have a great day");
                break;
                default:
                    Console.WriteLine("INVALID INPUT\nEnter Yes or No");
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid number");
        play = true;
    }
}