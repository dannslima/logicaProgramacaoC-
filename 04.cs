using System;

class Program {
    static void Main(string[] args) {
      Console.WriteLine("Digite o nome do produto");
	  string nome = Console.ReadLine()		;
	  Console.WriteLine("Digite o valor do produto")	;
	  double valor = double.Parse(Console.ReadLine());
	  Console.WriteLine("Qual desconto aplicar ?")	;
	  double desconto = double.Parse(Console.ReadLine());
	  double valorComDesconto = valor - ((valor*desconto)/ 100) ;	 
	  Console.WriteLine("Valor do produto com desconto {0}",valorComDesconto);	
		
    }
}