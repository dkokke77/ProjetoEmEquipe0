﻿double resultado;
Console.WriteLine("Qual o primeiro número?\n");
if (double.TryParse(Console.ReadLine(), out double numero1))
{
	Console.WriteLine("\nQual o segundo número?\n");
	if (double.TryParse(Console.ReadLine(), out double numero2))
	{
		Console.WriteLine("\nQual o operador desejado? Digite o símbolo referente a cada operação.\n");
		Console.WriteLine("1) Soma: +\n");
		Console.WriteLine("2) Subtração: -\n");
		Console.WriteLine("3) Multiplicação: *\n");
		Console.WriteLine("4) Divisão: /\n");
		if (char.TryParse(Console.ReadLine(), out char operador))
		{
			switch (operador)
			{
				case '+':
					resultado = numero1 + numero2;
					Console.WriteLine("O resultado desta soma é de: " + resultado);
					break;
				case '-':
					resultado = numero1 - numero2;
					Console.WriteLine("O resultado desta subtração é de: " + resultado);
					break;
				case '*':
					resultado = numero1 * numero2;
					Console.WriteLine("O resultado desta multipicação é de: " + resultado);
					break;
				case '/':
					if (numero2 != 0)
					{
						resultado = numero1 / numero2;
						Console.WriteLine("O resultado desta divisão é de: " + resultado);
					}
					else
						Console.WriteLine("Operação inválida, divisão por 0.");
					break;
				default:
					Console.WriteLine("Opção invélida!");
					break;
			}
		}
		else
		{
			Console.WriteLine("\nNúmero inválido!");
		}
	}
	else
	{
		Console.WriteLine("\nNúmero inválido!");
	}
}
else
{
	Console.WriteLine("\nNúmero inválido!");
}
