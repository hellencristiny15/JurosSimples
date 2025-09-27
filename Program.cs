Console.Clear();

decimal capital, taxa, meses, juros, montante;

Console.WriteLine("Juros simples (j)\n");

Console.Write("capital [c] (R$)....:");
capital = Convert.ToDecimal(Console.ReadLine());

Console.Write("taxa de juros [i] (%)....:");
taxa = Convert.ToDecimal(Console.ReadLine());

Console.Write("tempo [t] (meses)....:");
meses = Convert.ToDecimal(Console.ReadLine());

juros = capital * (taxa / 100) * meses;
montante = capital + juros;

Console.WriteLine($"\nJuros (j)....: R$ {juros:C2}");
Console.WriteLine($"Montante (M)....: R$ {montante:C2}");