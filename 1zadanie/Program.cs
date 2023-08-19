Console.WriteLine("Введите число: ");
string str_num_1 = Console.ReadLine();
int num_1 = int.Parse(str_num_1);
int prover;
int delost;
int summ = 0;
for(prover=num_1;num_1!=0;num_1=num_1/10)
{
delost=num_1 % 10;
summ=summ*10+delost;
}
if(prover==summ)
Console.WriteLine($"{prover} является палиндромом.");
else
Console.WriteLine($"{prover} не является палиндромом.");