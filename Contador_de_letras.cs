// Necesitamos saber cuantas veces aparece la letra "a" (puede ser cambiada por cualquier otra) en el siguiente texto.

String cadena = "C# is an object-oriented, component-oriented programming language. " +
    "C# provides language constructs to directly support these concepts, making C# a natural language in which to create and use software components. " +
    "Since its origin, C# has added features to support new workloads and emerging software design practices. " +
    "At its core, C# is an object-oriented language. You define types and their behavior.";

//Creamos una variable con la letra que desmos buscar o contar.
char variable = 'a';

//Cremoas otra variable para poder guardar el numero de veces que podemos encontrar la letra.
int contador = 0;

foreach (var c in cadena)
{
    //Ahora decimos que cada que encutre la letra que buscamos sume al contador
    if (c == variable)
        contador++;
}
Console.WriteLine(contador);
