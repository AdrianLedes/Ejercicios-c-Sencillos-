/*Escriba una función que tome una serie de palabras y las junte en una oración y devuelva la oración. 
 * Puede ignorar cualquier necesidad de desinfectar palabras o agregar puntuación, pero debe agregar espacios entre cada palabra.
 * ¡Cuidado, no debe haber un espacio al principio o al final de la oración!

['hello', 'world', 'this', 'is', 'great']  =>  'hello world this is great' */

string[] array = {"Hello", "word", "this", "is", "great"};

//Creamos una nueva variable, la cual sera igual a la primera palabra de el array que ocupa la posicion 0
string result = array[0];

/*Ahora hacemos un recorrido empezando desde la posicion 1 ya que la 0 ya la tenemos guardada en un variable,
por eso i se inicializa desde 1 */
for (int i = 1; i < array.Length; i++)
{
    // concatenamos nuestra variable con un espacio vacio y con el array
    result += " " + array[i];
  
    /*Esta parte de codigo solo esta para darnos cuenta de como se reliza el recorido del array,
   nos muetra como es que cada palabra se va concatenando*/
    
    //Console.WriteLine(result);
}
Console.WriteLine(result);




