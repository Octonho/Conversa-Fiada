Console.WriteLine("Digite a quantidade de notas");
int tamanho = Convert.ToInt32(Console.ReadLine());
double[] notas = new double[tamanho];
double soma = 0; 
for (int i = 0; i < tamanho; i++){
  Console.WriteLine("Digite a nota: ");
  notas[i] = Convert.ToInt32(Console.ReadLine());
}

foreach(int i in notas){
soma += notas[i - 1];
}
double media = soma / tamanho;
Console.WriteLine("Sua média: " + media);
