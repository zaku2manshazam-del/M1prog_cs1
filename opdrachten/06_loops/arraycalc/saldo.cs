
double[] saldo = { 240.99, 1142.23, 789.89, 658.72 };

for (int i = 0; i < saldo.Length; i++)
{
    saldo[i] += 100;
}

for (int i = 0; i < saldo.Length; i++)
{
    Console.WriteLine($"Saldo {i + 1}: {saldo[i]:F2}");
}