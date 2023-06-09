using System;
using System.Linq;
using System.Collections.Generic;

namespace Bidding;

public class Leilao 
{         
   public static void Main(){	
   		
   int N = Convert.ToInt16(Console.ReadLine());
   List<string> C = new List<string>();
   List<int> V = new List<int>();
   
   ListaDeCompradores(N,C,V);
   
   int Vm = V.Max();
   
   int index = ChecarIgual(V,Vm);
   
   Console.WriteLine(C[index]);
   Console.WriteLine(V[index]);
   
   } 
   
   static void ListaDeCompradores(int a, List<string> b, List<int> c){
    for (int i = 0; i < a; i++){
     b.Add(Console.ReadLine());
     c.Add(Convert.ToInt16(Console.ReadLine()));
   }
   }   
    
	static int ChecarIgual(List<int> a, int b){
	 for (int i = 0; i < a.Count; i++){
	  if (a[i] == b){
	  return i; 
	  }else {return 0;}
	} return 0;
	}
}
