// Первая задача: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

int ThreeDigits (int n)
{
    int second = (n/10)%10;
    return second;
}
Console.Write("Input three digit number: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = ThreeDigits(n);
Console.WriteLine($"The second digit is {result}");
Console.WriteLine();

// Вторая задача: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

void ThirdDigit (int third)
{
    int digit = 0;
    if (third <= 99) 
    {
        Console.WriteLine("There is no third digit in the number!");
    }
    else
    {
    if (third > 99 && third <= 999) {digit = third%10; Console.WriteLine($"The third digit is: {digit}");}
    if (third > 999 && third <= 9999) {digit = (third/10)%10; Console.WriteLine($"The third digit is: {digit}");}
    if (third > 9999 && third <= 99999) {digit = (third/100)%10; Console.WriteLine($"The third digit is: {digit}");}
    if (third > 99999 && third <= 999999) {digit = (third/1000)%10; Console.WriteLine($"The third digit is: {digit}");}
    if (third > 999999 && third <= 9999999) {digit = (third/10000)%10; Console.WriteLine($"The third digit is: {digit}");}
    if (third > 9999999 && third <= 99999999) {digit = (third/100000)%10; Console.WriteLine($"The third digit is: {digit}");}
    if (third > 99999999 && third <= 999999999) {digit = (third/1000000)%10; Console.WriteLine($"The third digit is: {digit}");}
    }
}
Console.Write("Input a number: ");
int third = Convert.ToInt32(Console.ReadLine());
ThirdDigit(third);
Console.WriteLine();

// Третья задача: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.

bool DaysOfTheWeek (int day)
{
    if (day>0 && day<8 && (day == 6 || day == 7)) return true;
    else return false;
}
Console.Write("Input number day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());
bool res3 = DaysOfTheWeek(day);
Console.WriteLine($"Is day {day} of the week a weekend? {res3}");