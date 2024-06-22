List<Double> grades = new List<double>();
bool active = true;
Console.WriteLine("Input the grades:\n");
while (active)
{
var grade = Convert.ToInt32(Console.ReadLine());
if (grade < 0 ){
  break;
}else{
grades.Add(grade);
}}

