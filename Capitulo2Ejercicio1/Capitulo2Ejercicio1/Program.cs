

//Hacer un programa que calcule el perímetro de cualquier polígono regular.

Console.WriteLine("\n\n--- Calcule el perímetro de cualquier polígono regular ---\n");
Console.WriteLine("Indique la cantidad de lados del poligono:");
int lado=int.Parse(Console.ReadLine());
Console.WriteLine("indique la longitud de los lados");
int longitud=int.Parse(Console.ReadLine());
int perimetro= lado*longitud;
Console.WriteLine($"El perimetro es igual a: {perimetro}");