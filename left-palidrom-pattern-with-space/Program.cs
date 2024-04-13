Console.WriteLine("Please Enter the value of which want you print");
int a = Convert.ToInt32(Console.ReadLine());    

for (int i = 0; i < a; i++)
{
    for (int j = 0; j < a; j++)
    {
        if(i + j <= a)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine(" ");
}