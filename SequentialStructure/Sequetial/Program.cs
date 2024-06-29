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

// 3. Faça um Programa que peça dois números e imprima a soma.

void ShowSum()
{
int Numbers()
{
Console.WriteLine("Digite o primeiro número: ");
int number1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Digite o segundo número: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 
return number1 + number2;
}
Console.WriteLine("A soma de ambos os números é igual: "+ Numbers());
}

// 4. Faça um Programa que peça as 4 notas bimestrais e mostre a média.

void ShowAvarage()
{
int Avarages()
{
Console.WriteLine("Digite a primeira nota: ");
int avarage1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
int avarage2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
int avarage3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a quarta nota: ");
int avarage4 = Convert.ToInt32(Console.ReadLine());

return (avarage1 + avarage2 + avarage3 + avarage4) / 4;
}
Console.WriteLine("Sua média é igual: "+ Avarages());
}

// Execução
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
case 3:
  ShowSum();
  break;
case 4:
  ShowAvarage();
  break;
}


