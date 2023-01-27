//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();				                // очистка консоли

Console.WriteLine("Введите 1-е число: ");		// ввод 1-го числа
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число: ");		// ввод 2-го числа
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2)
    Console.WriteLine($"Числа равны: {n1}={n2}.");
else
    if (n1 > n2)
        Console.WriteLine($"Большее число: {n1}. Меньшее число: {n2}.");
    else    
        Console.WriteLine($"Большее число: {n2}. Меньшее число: {n1}.");