// Faça um programa que leia dois valores de cateto e calcule sua hipotenusa

double catA;
double catB;

Console.Write("Medida do primeiro cateto: ");
catA = double.Parse(Console.ReadLine());

while (catA <= 0)
{
    Console.Write("Medida do cateto não pode ser zero ou negativa, tente novamente: ");
    catA = double.Parse(Console.ReadLine());
}

Console.Write("Medida do segundo cateto: ");
catB = double.Parse(Console.ReadLine());

while (catB <= 0)
{
    Console.Write("Medida do cateto não pode ser zero ou negativa, tente novamente: ");
    catB = double.Parse(Console.ReadLine());
}

double hip = Math.Sqrt(Math.Pow(catA, 2) + Math.Pow(catB, 2));

Console.WriteLine($"\nA hipotenusa é {hip}");