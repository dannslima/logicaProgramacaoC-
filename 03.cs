using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite numero 1 ");
		int num1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite numero 2 ");
		int num2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite numero 3 ");
		int num3 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite numero 4 ");
		int num4 = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite numero 5 ");
		int num5 = int.Parse(Console.ReadLine());
        float media = ((num1 + num2 + num3 + num4 + num5)/5);
		Console.WriteLine("Media é "  + media);
    }
}