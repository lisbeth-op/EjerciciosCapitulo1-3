//Hacer un programa que transforme de grados a radianes.

Console.WriteLine("\n\n--- Convierta grados a radianes ---\n");
Console.WriteLine("Indique el grado que quiere convertir a radianes: ");
int grado=int.Parse(Console.ReadLine());
double calculo = grado * (3.14 / 180);
Console.WriteLine($"\n{grado } son {calculo} radianes");