// See https://aka.ms/new-console-template for more information

Console.WriteLine("Calculo del promedio");
Console.WriteLine();


int Nota1, Nota2, Nota3, Nota4;

Console.WriteLine("Ingresar la Nota1: ");
Nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar la Nota2: ");
Nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar la Nota3: ");
Nota3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresar la Nota4: ");
Nota4 = Convert.ToInt32(Console.ReadLine());


double Nota = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

if (Nota > 70)

{
    Console.WriteLine("El Estudiente Aprobo");
}
else
{
    Console.WriteLine("El Estudiante Reprobo");
}