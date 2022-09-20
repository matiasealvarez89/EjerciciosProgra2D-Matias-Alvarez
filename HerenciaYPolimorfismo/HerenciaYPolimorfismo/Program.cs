

using HerenciaYPolimorfismo;

Sobrescrito objetoSobrescrito = new Sobrescrito();
string objeto = "¡Este es mi método ToString sobrescrito!";

Console.WriteLine(objetoSobrescrito.ToString());

Console.WriteLine("----------------------------------------------");
Console.Write("Comparación Sobrecargas con String: ");
Console.WriteLine(objetoSobrescrito.Equals(objeto));

Console.WriteLine("----------------------------------------------");
Console.WriteLine(objetoSobrescrito.GetHashCode());

Console.ReadKey();