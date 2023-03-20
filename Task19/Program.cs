Console.Clear();
Console.Write("Введите число: ");
string n = Console.ReadLine()!;
int i =0, m = n.Length-1;
while (i < m && n[i] == n[m])
{i++; m--;};
if (n[i] == n[m])
Console.WriteLine($"{n} - это палиндром");
else
Console.WriteLine($"{n} - это не палиндром");

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// string b = Convert.ToString(a);
// string z = new string(b.Reverse().ToArray());
// if (b == z)
//     Console.WriteLine($"Число {a} - является полиндромом");
// else
//     Console.WriteLine($"Число {a} - не является полиндромом");