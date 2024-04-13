Console.WriteLine("Please Enter the number : ");
int a = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i < a; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}