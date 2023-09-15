int numeroDigitado, centenas, dezenas, unidades;

Console.Write("Digite um número:");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO número {numeroDigitado} possui:");

centenas = numeroDigitado / 100;
dezenas = (numeroDigitado % 100) / 10;
unidades = (numeroDigitado % 100) % 10;

Console.WriteLine($"{unidades.ToString().PadLeft(10, ' ')} unidade(s)");
Console.WriteLine($"{dezenas.ToString().PadLeft(10, ' ')} dezena(s)");
Console.WriteLine($"{centenas.ToString().PadLeft(10, ' ')} centena(s)");