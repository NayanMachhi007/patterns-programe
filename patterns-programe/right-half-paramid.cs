
Console.WriteLine("Enter the value : ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < a; i++)
{
   for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine(" ");
}