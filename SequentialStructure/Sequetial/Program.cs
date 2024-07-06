// 1. Faça um Programa que mostre a mensagem "Alo mundo" na tela.

using System.ComponentModel;
using System.Net.NetworkInformation;

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

// 5. Faça um Programa que converta metros para centímetros.

void ShowMetersToCentimeter()
{
double MetersToCentimeters()
{
Console.WriteLine("Digite o valor em metros: ");
double m = Convert.ToDouble(Console.ReadLine());
double cm = m * 100; 
return cm;
}
Console.WriteLine("O valor em Cm é: " + MetersToCentimeters());
}

// 6. Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
void ShowAreaOfCircle()
{
  double AreaOfCircle()
  {
    double pi = 3.14;
    Console.WriteLine("Digite o raio");
    double r = Convert.ToDouble(Console.ReadLine());
    return  pi * (r * r);
  }
  Console.WriteLine("A área do circulo é: " + AreaOfCircle());
}

// 7. Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.
void ShowAreaOfSquare()
{
  double DoubleOfAreaOfSquare()
  {
   
    Console.WriteLine("Digite o lado do quadrado");
    double l = Convert.ToDouble(Console.ReadLine());
    return (l * l) * 2;
  }
  Console.WriteLine("A área do circulo é: " + DoubleOfAreaOfSquare());
}

// 8. Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês. Calcule e mostre o total do seu salário no referido mês.

void ShowWage()
{
 double WageCalc()
 {
  double workHours = Convert.ToDouble(Console.ReadLine());
  double hourWage = Convert.ToDouble(Console.ReadLine());
  return workHours * hourWage;
 }
 Console.WriteLine(WageCalc());
}
// 9. Faça um Programa que peça a temperatura em graus Fahrenheit, transforme e mostre a temperatura em graus Celsius. C = 5 * ((F-32) / 9).

void ShowConvertedToCelsius()
{
  double ConvertToCelsius()
  {
    double F = Convert.ToDouble(Console.ReadLine());
    return 5 * ((F - 32) / 9);
  }
  Console.WriteLine(ConvertToCelsius());
}
//10. Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Fahrenheit.
void ShowConvertedToFahrenheit()
{
  double ConvertToFahrenheit()
  {
    double C = Convert.ToDouble(Console.ReadLine());
    return (C * 1.8) + 32;
  }
  Console.WriteLine(ConvertToFahrenheit());
}
/*
11. Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre:
a. o produto do dobro do primeiro com metade do segundo .
b. a soma do triplo do primeiro com o terceiro.
c. o terceiro elevado ao cubo.
*/

void ShowNumberTransformation()
{
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
double n3 = Convert.ToDouble(Console.ReadLine());
double a()
{
return Convert.ToDouble((n1 * 2) * (n2 / 2.0));
}
double b()
{
  return Convert.ToDouble((n2 * 3.0) + n3);
}

double c()
{
  return Convert.ToDouble(n3 * n3 * n3);
}
Console.WriteLine("a: " + a() + " b: " + b() + " c: " + c());
}
// 12. Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula: (72.7*altura) - 58

void ShowIdealWeight()
{
double IdealWeight()
{
double height = Convert.ToDouble(Console.ReadLine());
return (72.7 * height) - 58;
}
Console.WriteLine("Seu peso ideal é: " + IdealWeight());
}
/*
13. Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
a. Para homens: (72.7*h) - 58
b. Para mulheres: (62.1*h) - 44.7
*/
void ShowIdealWeight2()
{
double height = Convert.ToDouble(Console.ReadLine());
double IdealWeightMan()
{
return (72.7 * height) - 58;
}
double IdealWeightFemale()
{
  return (62.1 * height) - 44.7;
}
Console.WriteLine("Seu peso ideal masculino é: " + IdealWeightMan());
Console.WriteLine("Seu peso ideal feminino é: " + IdealWeightFemale());

}
/*
João Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar o rendimento diário de seu trabalho. Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. João precisa que você faça um programa que leia a variável peso (peso de peixes) e calcule o excesso. Gravar na variável excesso a quantidade de quilos além do limite e na variável multa o valor da multa que João deverá pagar. Imprima os dados do programa com as mensagens adequadas.
*/

void ShowJoao()
{
double fishWidth = Convert.ToDouble(Console.ReadLine());
double ticket = fishWidth >= 0 && fishWidth <= 40 ? 0 : (fishWidth - 50) * 4;

Console.WriteLine("Você recebeu uma multa de: " + ticket);
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
case 5:
  ShowMetersToCentimeter();
  break;
case 6:
  ShowAreaOfCircle();
  break;
case 7:
  ShowAreaOfSquare();
  break;
case 8:
  ShowWage();
  break;
case 9:
  ShowConvertedToCelsius();
  break;
case 10:
  ShowConvertedToFahrenheit();
  break;
case 11:
  ShowNumberTransformation();
  break;
case 12:
  ShowIdealWeight();
  break;
case 13:
  ShowIdealWeight2();
  break;
case 14:
  ShowJoao();
  break;
case 15:
  break;
case 16:
  break;
case 17:
  break;
case 18:
  break;
}


