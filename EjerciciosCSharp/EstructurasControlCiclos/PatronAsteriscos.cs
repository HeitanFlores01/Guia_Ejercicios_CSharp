namespace EjerciciosCSharp.EstructuresControlCiclos
{
    public class PatronAsteriscos
    {
        public PatronAsteriscos(int opcion, int tamano)
        {
            // Triangulo normal
            if (opcion == 1)
            {
                int fila = 1;
                while (fila <= tamano)
                {
                    int columna = 1;

                    // Dibuja tantos asteriscos como el número de la fila actual
                    while (columna <= fila)
                    {
                        Console.Write("*");
                        columna = columna + 1;
                    }
                    
                    // Salto de linea al terminar la fila
                    Console.WriteLine(); 
                    fila = fila + 1;
                }
            }

            // Triangulo invertido
            else if (opcion == 2)
            {
                int fila = tamano;

                // Empezamos desde el tamaño máximo y vamos bajando hacia 1
                while (fila >= 1)
                {
                    int columna = 1;
                    while (columna <= fila)
                    {
                        Console.Write("*");
                        columna = columna + 1;
                    }
                    Console.WriteLine(); 
                    fila = fila - 1; // Se resta uno para que la fila siguiente tenga menos asteriscos
                }
            }

            // Cuadrado hueco
            else if (opcion == 3)
            {
                int fila = 1;
                while (fila <= tamano)
                {
                    int columna = 1;
                    while (columna <= tamano)
                    {
                        // Aca pregunta si esta en los bordes del cuadrado
                        // Primera fila o última fila, primera columna o última columna
                        if (fila == 1 || fila == tamano || columna == 1 || columna == tamano)
                        {
                            Console.Write("*");
                        }

                        // si es el centro dibuja un espacio vacío
                        else
                        {
                            Console.Write(" ");
                        }
                        columna = columna + 1;
                    }
                    Console.WriteLine();
                    fila = fila + 1;
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}