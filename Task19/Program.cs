Console.Clear();
Console.Write("Введите число: ");
string n = Console.ReadLine()!;
int i =0, m = n.Length-1;
while (i < m && n[i] == n[m])
i++; m--;
if (n[i] == n[m])
Console.WriteLine($"{n} - это палиндром");
else
Console.WriteLine($"{n} - это не палиндром");

