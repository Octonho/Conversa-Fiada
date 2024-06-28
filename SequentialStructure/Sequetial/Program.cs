// 1. Faça um Programa que mostre a mensagem "Alo mundo" na tela.

void HelloWorld()
{
  Console.WriteLine("Alo mundo");
}
Console.WriteLine("Digite sua resposta");
int choice = Convert.ToInt32(Console.ReadLine());
switch(choice)
{
case 1:
  HelloWorld();
  break;
}


