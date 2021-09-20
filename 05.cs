using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite um numero");
		int num = int.Parse(Console.ReadLine());

		if ((num%2)==0){
			Console.WriteLine("Numero Par {0}", num);
		}else{
			Console.WriteLine("Numero Impar {0}", num);
		}
    }
}