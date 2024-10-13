// Math >= 90, Biology >= 90, Chemistry >= 90;
int math, biology, chemistry;

Console.WriteLine("Enter your Math exam result.");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology exam result.");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry exam result.");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You've been accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approved due to low test score(s).");
}
