using EjercicioClase13;

Console.WriteLine("Bienvenido a Billetera.");

Billetera[] billeteras = new Billetera[2];

billeteras[0] = new Billetera();
billeteras[1] = new Billetera();

foreach (var item in billeteras)
{
    Console.WriteLine("------------------ Nueva Billetera -------------------");
    Console.WriteLine("Ingrese cantidad de billetes de 10:");
    item.BilletesDe10 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de billetes de 20:");
    item.BilletesDe20 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de billetes de 50:");
    item.BilletesDe50 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de billetes de 100:");
    item.BilletesDe100 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de billetes de 200:");
    item.BilletesDe200 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de billetes de 500:");
    item.BilletesDe500 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese cantidad de billetes de 1000:");
    item.BilletesDe1000 = int.Parse(Console.ReadLine());
}
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("La suma total de la billetera 1 es: $" + billeteras[0].Total());
Console.WriteLine("La suma total de la billetera 2 es: $" + billeteras[1].Total());

Billetera b3 = billeteras[0].Combinar(billeteras[0],billeteras[1]);

Console.WriteLine("Combinando ambas billeteras tenemos un total de: $" + b3.Total());