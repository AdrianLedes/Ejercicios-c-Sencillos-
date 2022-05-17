/*Después de un duro trimestre en la oficina, decides descansar un poco en unas vacaciones. 
Así que reservarás un vuelo para ti y tu novia y tratarás de dejar todo el lío atrás.
Necesitará un coche de alquiler para poder moverse en sus vacaciones. El encargado del alquiler de coches te hace unas buenas ofertas.
Cada día que alquilas el auto cuesta $40. Si alquila el automóvil por 7 días o más, obtiene $ 50 de descuento en su total. 
Alternativamente, si alquila el automóvil por 3 o más días, obtiene $ 20 de descuento en su total.
*/

/*Esta line realmente solo sirve para que el ejerccio se mas intereactivo, puede omitirse y darle el valor desde la variable "dias"*/
Console.WriteLine("Introduce los dias que rentaras el automovil: ");

/* Dandole el valor desde la variable dias podemos saltar el paso de convertir un string a un int*/
int dias = Int32.Parse(Console.ReadLine());
int dia = 40;
int total = 0;

if(dias <= 2)
{
    total = dias * dia;
    Console.WriteLine("Por los " + dias + " dias deberas pagar un total de: " + total);
}
else if (dias<=6)
{
    total = dias * dia - 20;
    Console.WriteLine("Por los " + dias + " dias deberas pagar un total de: " + total);
}
else if (dias >=7)
{
    total = dias * dia - 50;
    Console.WriteLine("Por los " + dias + " dias deberas pagar un total de: " + total);
}

