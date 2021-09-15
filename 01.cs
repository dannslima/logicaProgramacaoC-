using System;

class Program {
    static void Main(string[] args) {

		Console.WriteLine("Digite o numero a calcular");
		int numero = int.Parse(Console.ReadLine());
		for (int i = 0; i <11 ; i++){
		Console.WriteLine("{0}X{1}={2}",numero,i,(numero * i));
	}
      
    }
}