//Assignment 1
Console.WriteLine("Enter the Number of day: ");
int  num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("Saturday");//Monday, Tuesday,Wednesday, Thursday, Friday
        break;
    case 2:
        Console.WriteLine("Sunday");
        break;
    case 3:
        Console.WriteLine("Monday");
        break;
    case 4:
        Console.WriteLine("Tuesday");
        break;
    case 5:
        Console.WriteLine("Wednesday");
        break;
    case 6:
        Console.WriteLine("Thursday");
        break;
    case 7:
        Console.WriteLine("Friday");
        break;
        default:
        Console.WriteLine("invalid input");
        break;
        
    
}
//Assignment 2
Console.WriteLine("Enter the Month:");
int month =Convert.ToInt32(Console.ReadLine());
if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
{
    Console.WriteLine($"Number of days this Month_{month}  is 31 ");

}
else if (month == 4 || month == 6 || month == 9 || month == 11)
{
    Console.WriteLine($"Number of days this Month_{month}  is 30 ");

}
else if (month == 2) {
    Console.WriteLine($"Number of days this Month_{month}  is 28 ");


}
else
{
    Console.WriteLine("Invalid input");
}

Console.WriteLine("ramiz");
