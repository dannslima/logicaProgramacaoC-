using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
		
		List<int> notas = new List<int>();
		for (int i =1 ; i <5 ; i++){
			Console.WriteLine("digite a nota  {0}",i);
			int nota = int.Parse(Console.ReadLine());
			notas.Add(nota);
			
		}
		
		double total = notas.Sum() / 4 ;
		Console.WriteLine("Media é {0}", total);

		if (total < 6){
			Console.WriteLine("reprovado");
		} else {
		Console.WriteLine("aprovado");
		}
	
		
    }
}