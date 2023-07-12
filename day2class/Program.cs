
// if statements
int age = 34;
if (age >= 21);
{
    Console.WriteLine("Can Drink");
}
else if (age >= 18)
{
    Console.WriteLine("Can Vote");
}
else if(age >= 16)
{
    Console.WriteLine("Can Drive");
}
else
{
    Console.WriteLine("Too young");
}
//switch case (good for menu choices)

Console.WriteLine("Please enter a menu choice 1-3");
int menuChoice = int.Parse(Console.ReadLine());
switch (menuChoice)
{
    case 1: Console.WriteLine("Here are all books");
        break;
        case 2: Console.WriteLine("Check out a book");
        break;
        case 3: Console.WriteLine("Return Book");
        break;
    default:Console.WriteLine("Invalid choice");
        break;
}
// ternary (good for 1-2 options)
int age2 = 25;
string status = age2 >= 18 ? "Adult" : "Child";
Console.WriteLine(status);

//--------------------------------------------------------
//LOOPS
//For loop
//if you know how many times you want to loop
//1 variable holds loop count
// 2 boolean expression (true = run. false = stop)
// 3 counter increment/decrement
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}
// starts a 10, count down to 0
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}


//write ******IMPORTANT*******
bool runProgram = true;
while (runProgram)
{
    //main code here
    //ask to continue
    Console.WriteLine("Would you like to continue y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    {
        runProgram = false;
    }
}

//do while
int menu = -1;

do
{
    Console.WriteLine("Menu choice 1-3 (0 to leave)");
    menu = int.Parse(Console.ReadLine());
    if (menu == 1)
    {
        Console.WriteLine("See all books");
    }
    else if (menu == 2)
    {
        Console.WriteLine("Check out");
    }
    else if (menu == 3)
    {
        Console.WriteLine("Return");
    }
} while (menu != 0);

//continue

for (int i = 0; i<= 10; i++)
{
    if(i % 2 == 1)
    {
        //skip to next loop
        continue;
    }

    Console.WriteLine();
}

