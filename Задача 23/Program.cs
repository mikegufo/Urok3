System.Console.WriteLine("Введите число :");
int count = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    System.Console.Write(Math.Pow(i, 3) + " ");
}
