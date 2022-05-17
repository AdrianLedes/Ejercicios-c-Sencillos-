// Logra que la cadena de string sea leida correctamente invirtiendola.

String text = "gnirts led anedac al ritrevni odargol zah euq se otxet etse reel sedeup is";

//Creamos una varible para poder guardar la cenada a la hora de invertirla.
String rest = "";

//Hacemos un recorrido al string pero de manera inversa a lo que comun mente se hace.
//se recorrerla de derecha a izquierda permitiendo asi invertir toda la cadena
for (int i = text.Length - 1; i >= 0; i--)
{
    //Concatenamos el resultado para poder visualizar la cadena ya invertida.
    rest += text[i];
}

Console.WriteLine(rest);

