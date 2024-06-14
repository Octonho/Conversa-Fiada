using System.Collections;
using System.Diagnostics.Contracts;

var contatoss = new ArrayList();
int codigo = 0;



while (true){
  int Count = 0;
  Console.WriteLine("\nBem vindo a agenda, digite o código da função desejada:\n");
  Console.WriteLine("0: Sair\n1: Exibir contatos\n2: Adicionar novo contato\n3: Remover Contato:\n");
  ArrayList contatos = new ArrayList(contatoss);
  codigo = Convert.ToInt32(Console.ReadLine());
  if(codigo == 0){
    break;
  }else if(codigo == 1){
    Console.WriteLine("Contatos: ");
    foreach(string i in contatos){
      Console.WriteLine(i);
    }
  }else if(codigo == 2){
    Console.WriteLine("Digite o nome do contato: \n");
    contatoss.Add(Console.ReadLine());
    Console.WriteLine("\n");
  }else if(codigo == 3){
    Console.WriteLine("Escolha um contato para remover: ");
    foreach(string i in contatoss){
      Count ++;
      Console.WriteLine(i + " " + Count);
      }
    contatoss.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
    
  }
}