// Math >= 90 OR Chemistry >= 90

// math && chemistry || math && biology || chemistry && biology
int math, chemistry, biology;

Console.WriteLine("Enter your Math exam result.");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology exam result.");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry exam result.");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90 ) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You've been accepted!");
}
else
{
    Console.WriteLine("Your application cannot be approved due to low test score(s).");
}
