// See https://aka.ms/new-console-template for more information
using Entidades;

List<Personaje> listaPersonajes = new List<Personaje>();

Personaje p1 = new Personaje();

Personaje p2 = new Personaje("Pepe", 200);

Personaje p3 = new Personaje("Jorge");





listaPersonajes.Add(p1);
listaPersonajes.Add(p2);
listaPersonajes.Add(p3);


foreach (Personaje auxPersonaje in listaPersonajes)
{
    if(auxPersonaje.Vida > 100)
    Console.WriteLine(auxPersonaje.MonstrarInformacion());
}


static void MostrarPersonaje(Personaje personaje, string info)
{
    Console.WriteLine(info);
    Console.WriteLine(personaje.MonstrarInformacion());
}