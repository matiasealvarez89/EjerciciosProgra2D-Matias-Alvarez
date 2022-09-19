using Entidades;

Cuenta nuevaCuenta = new Cuenta("Matias", 0);
int opcion;
float aux;

do
{
    Console.WriteLine("Seleccione la opcion deseada \n" +
        "1)Ingresar Dinero\n" +
        "2)Retirar Dinero\n");
    if(int.TryParse(Console.ReadLine(), out opcion))
    {
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingrese el monto a depositar");
                float.TryParse(Console.ReadLine(), out aux);
                nuevaCuenta.Ingresar(aux, nuevaCuenta);
                break;
            case 2:
                Console.WriteLine("Ingrese el monto a retirar");
                float.TryParse(Console.ReadLine(), out aux);
                nuevaCuenta.Retirar(aux, nuevaCuenta);
                break;
        }
            
    }
    else
    {
        Console.WriteLine("Ingreso incorrecto");
    }
    
    Console.WriteLine(nuevaCuenta.Mostrar());
} while (true);
