using System;

class MainClass {
  public static void Main (string[] args) {
    
    double va, vb;
    
    Console.WriteLine ("Meu nome é JayJay Robot! :)"+"\n"+"Qual o desafio dessa vez? Alternar os valores? OK!");
    
    Console.Write ("Me diga então o primeiro valor: ");
    va = double.Parse (Console.ReadLine ());
    
    Console.Write ("Beleza, agora o segundo valor: ");
    vb = double.Parse (Console.ReadLine ());
    

    
    Console.Write ("ahahahah simples, gente! \n Ó, o valor de a agora é "+vb+"\n");
    Console.Write("E o valor de b agora é "+va);
    
    Console.ReadKey ();
  }
}