List<Double> grades = new List<double>();
bool active = true;
Console.WriteLine("Input the grades:\n");
const double aproved = 7.0;
var sum = 0;
var x = 0;
while (active)
{
var grade = Convert.ToInt32(Console.ReadLine());
if (grade < 0 ){
  break;
}else{
grades.Add(grade);
x += 1;
}}

foreach(int i in grades){
  sum += i;
}

var average = sum / x;

if(average != aproved){
  Console.WriteLine("Reprovou");
}else{
  Console.WriteLine("Aprovado");
}