using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite a base ");
		float baset = float.Parse(Console.ReadLine());
		Console.WriteLine("Digite a altura ");
		float altura = float.Parse(Console.ReadLine());
		float area = ((baset * altura)/2);
		Console.WriteLine("area = {0}", area);
		
    }
}