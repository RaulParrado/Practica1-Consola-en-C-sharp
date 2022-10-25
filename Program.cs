//Enunciado Práctica:

//1.1 - Solicitar al usuario que introduzca una cadena de al menos 40 caracteres. Si la longitud de la cadena es menor de 40 caracteres, se mostrará un aviso al usuario, informándole de la longitud actual, y solicitándole que vuelva a introducir una nueva cadena. Por ejemplo: "La cadena introducida posee únicamente XX caracteres. Por favor, introduzca una nueva cadena con más de 40 caracteres: ".

//1.2 - Una vez tengamos la cadena con el tamaño mínimo deseado, aparecerá un menú para:

//•Sustituir una palabra por otra. Para ello, se solicitará introducir, separadas por un espacio, la palabra a sustituir, y la sustituta, mostrándose por pantalla el resultado final.

//•Buscar texto en la cadena. Para ello, se solicitará introducir un texto para comprobar si existe o no.

//•Buscar texto de inicio en la cadena. Para ello, se solicitará introducir un texto para comprobar si la cadena comienza por el mismo.

//1.3- Una vez haya terminado la acción seleccionada del menú, volvemos a solicitar una nueva cadena.
do
{
    Console.Clear();
    Console.WriteLine("Introduzca una cadena de al menos 40 caracteres");
    Console.WriteLine("Para salir del programa, introduzca una cadena vacía");
    string? frase = Console.ReadLine();

    if (frase != null)
    {
        while (frase.Length < 40)
        {
            Console.WriteLine("La cadena introducida posee únicamente {0} caracteres.Por favor, introduzca una nueva cadena con al menos de 40 caracteres: ", frase.Length);
            frase = Console.ReadLine();
            if (frase == null) return;
        }
        Console.Clear();
        Console.WriteLine("Este es un menu");
        Console.WriteLine("");

        Console.WriteLine("0.Salir de la aplicación");
        Console.WriteLine("1.Sustituye una palabra, introduce la palabra a sustituir y la sustituta separadas por espacio");
        Console.WriteLine("2.Buscar un texto en la cadena");
        Console.WriteLine("3.Buscar texto de inicio en la cadena");

        string? eleccion = Console.ReadLine();

        Console.Clear();
        switch (eleccion)
        {
            case "0":
                return;

            case "1":
                Console.WriteLine("1.Sustituye una palabra, introduce la palabra a sustituir y la sustituta separadas por espacio");
                string? palabras = Console.ReadLine();
                if (palabras != null)
                {
                    string[] palabrasSeparadas = palabras.Split(" ");
                    if (palabrasSeparadas.Length == 2)
                    {
                        if (frase.Contains(palabrasSeparadas[0]))
                        {
                            frase = frase.Replace(palabrasSeparadas[0], palabrasSeparadas[1]);
                        }
                        else
                        {
                            Console.WriteLine("La frase no contiene la palabra introducida");
                        }
                        Console.WriteLine("Nueva frase: ");
                        Console.WriteLine(frase);
                    }

                    else
                    {
                        Console.WriteLine("El formato de las palabras introducidas no es correcto");
                    }


                }
                break;
            case "2":
                Console.WriteLine("2.Buscar un texto en la cadena");
                string? buscar = Console.ReadLine();
                if (buscar != null)
                {
                    if (frase.Contains(buscar))
                    {
                        Console.WriteLine("La cadena original contiene la frase buscada");

                    }
                    else
                    {
                        Console.WriteLine("La cadena original no contiene la frase buscada");

                    }
                }
                break;
            case "3":
                Console.WriteLine("3.Buscar texto de inicio en la cadena");
                string? buscar2 = Console.ReadLine();
                if (buscar2 != null)
                {
                    if (frase.StartsWith(buscar2))
                    {
                        Console.WriteLine("La frase original empieza por la frase introducida");

                    }
                    else
                    {
                        Console.WriteLine("La frase original no empieza por la frase introducida");

                    }
                }
                break;

            default:
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("Pulse cualquier tecla para reiniciar");
        Console.ReadKey();

    }
    else
    {
        return;
    }
} while (true);