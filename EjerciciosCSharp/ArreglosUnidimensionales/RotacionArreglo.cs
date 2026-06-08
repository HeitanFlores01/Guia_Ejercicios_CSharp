namespace EjerciciosCSharp.ArreglosUnidimensionales

{
    public class RotacionArreglo
    {
        public RotacionArreglo(int n)
        {
            int[] arreglo = new int[n];

            int i = 0;

            while (i < n)
            {
                Console.Write($"Elemento [{i}]: ");
                arreglo[i] = Convert.ToInt32(Console.ReadLine());
                i = i + 1;
            }

            Console.WriteLine("---MENU DE ROTACION---");
            Console.WriteLine("1. Rotar posiciones a la izquierda");
            Console.WriteLine("2. Rotar posiciones a la derecha");
            Console.WriteLine("3. Invertir el arreglo");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // La primera opción es rotar a la izquierda
            if (opcion == 1)
            {
                Console.Write("Cuantas posiciones a la izquierda?: ");
                int k = Convert.ToInt32(Console.ReadLine());
                int vueltas = 0;

                while (vueltas < k)
                {
                    int primero = arreglo[0];
                    int j = 0;

                    while (j < n - 1)
                    {
                        arreglo[j] = arreglo[j + 1];
                        j = j + 1;
                    }
                    arreglo[n - 1] = primero;
                    vueltas = vueltas + 1;
                }
            }
            // La segunda opción es rotar a la derecha 
            else if (opcion == 2)
            {
                Console.Write("Cuantas posiciones a la derecha?: ");
                int k = Convert.ToInt32(Console.ReadLine());
                int vueltas = 0;

                while (vueltas < k)
                {
                    int ultimo = arreglo[n - 1];
                    int j = n - 1;

                    while (j > 0)
                    {
                        arreglo[j] = arreglo[j - 1];
                        j = j - 1;
                    }
                    arreglo[0] = ultimo;
                    vueltas = vueltas + 1;
                }
            }
            // La tercera opción es invertir 
            else if (opcion == 3)
            {
                int inicio = 0;
                int fin = n - 1;

                while (inicio < fin)
                {
                    int temp = arreglo[inicio];
                    arreglo[inicio] = arreglo[fin];
                    arreglo[fin] = temp;
                    inicio = inicio + 1;
                    fin = fin - 1;
                }
            }

            Console.Write("Resultado final del arreglo: ");
            i = 0;

            while (i < n)
            {
                Console.Write(arreglo[i] + " ");
                i = i + 1;
            }
            Console.WriteLine();
        }
    }
}