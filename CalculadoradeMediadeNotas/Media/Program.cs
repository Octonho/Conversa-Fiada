Console.WriteLine("Digite a quantidade de notas");
int tamanho = Convert.ToInt32(Console.ReadLine());
double[] notas = new double[tamanho];
double soma = 0; 
for (int i = 0; i < tamanho; i++)
{
  Console.WriteLine("Digite a nota:\n ");
  notas[i] = Convert.ToDouble(Console.ReadLine());
}

foreach(double i in notas){
soma += i;
}
double media = soma / tamanho;
Console.WriteLine("\nSua média: " + media);
