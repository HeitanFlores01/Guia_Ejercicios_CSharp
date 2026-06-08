namespace EjerciciosCSharp.ArreglosUnidimensionales

{
    public class BusquedaOrdenamiento
    {
        public BusquedaOrdenamiento(int buscar)
        {
            int[] numeros = new int[10];

            // Llenamos el arreglo
            int i = 0;
            
            while (i < 10)
            {
                Console.Write($"Digita el numero entero {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                i = i + 1;
            }

            // Aca se muestran los elementos en posiciones pares
            Console.Write("\nElementos en posiciones pares del arreglo: ");
            i = 0;

            while (i < 10)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"[{i}]:{numeros[i]}  ");
                }
                i = i + 1;
            }
            Console.WriteLine();

            // Se realiza la búsqueda lineal 
            int posicionEncontrada = -1;
            i = 0;

            while (i < 10)
            {
                if (numeros[i] == buscar)
                {
                    posicionEncontrada = i;
                }
                i = i + 1;
            }

            if (posicionEncontrada != -1)
            {
                Console.WriteLine($"El numero {buscar} se encontro en el indice: {posicionEncontrada}");
            }
            else
            {
                Console.WriteLine("El numero no existe en el arreglo");
            }

            // Encontramos el mayor y segundo mayor
            int mayor = numeros[0];

            // Empezamos con un número muy bajo
            int segundoMayor = -999999; 
            i = 1;

            while (i < 10)
            {
                if (numeros[i] > mayor)
                {
                    segundoMayor = mayor;
                    mayor = numeros[i];
                }
                else if (numeros[i] > segundoMayor && numeros[i] != mayor)
                {
                    segundoMayor = numeros[i];
                }
                i = i + 1;
            }
            Console.WriteLine($"El mayor es: {mayor}, y el segundo mayor es: {segundoMayor}");

            // Realizamos el ordenamiento burbuja (Ascendente)
            int x = 0;

            while (x < 10)
            {
                int y = 0;

                while (y < 9)
                {
                    if (numeros[y] > numeros[y + 1])
                    {
                        // Se hace un intercambio 
                        int temporal = numeros[y];
                        numeros[y] = numeros[y + 1];
                        numeros[y + 1] = temporal;
                    }
                    y = y + 1;
                }
                x = x + 1;
            }

            // Mostramos le arreglo ordenado
            Console.Write("Arreglo ordenado por burbuja: ");
            i = 0;

            while (i < 10)
            {
                Console.Write(numeros[i] + " ");
                i = i + 1;
            }
            Console.WriteLine();
        }
    }
}