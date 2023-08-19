Console.WriteLine("Введите число: ");
string str_num = Console.ReadLine();
int num = int.Parse(str_num);
for (int i = 1; i <= num; i++)
{
    Console.Write($"{i*i*i} ");
}