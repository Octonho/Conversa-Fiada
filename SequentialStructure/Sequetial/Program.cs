// 1. Faça um Programa que mostre a mensagem "Alo mundo" na tela.

void HelloWorld()
{
  Console.WriteLine("Alo mundo");
}

// 2. Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].
void ShowNumber(){
int Number()
{
Console.WriteLine("Digite um número para ser apresentado na tela: ");
int number = Convert.ToInt32(Console.ReadLine()); 
return number;
}
Console.WriteLine("O número informado foi "+ Number());
}

Console.WriteLine("Digite o código baseado nessa lista: https://wiki.python.org.br/EstruturaSequencial: ");
int choice = Convert.ToInt32(Console.ReadLine());
switch(choice)
{
case 1:
  HelloWorld();
  break;
case 2:
  ShowNumber();
  break;
}


