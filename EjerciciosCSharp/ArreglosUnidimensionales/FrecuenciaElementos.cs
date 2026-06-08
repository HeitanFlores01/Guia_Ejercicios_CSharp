namespace EjerciciosCSharp.ArreglosUnidimensionales

{
    public class FrecuenciaElementos
    {
        public FrecuenciaElementos()
        {
            int[] aleatorios = new int[20];

            // Se usa para generar números aleatorios 
            Random numAzar = new Random();

            // LLenamos con números del 1 al 10
            int i = 0;
            Console.Write("Numeros generados al azar: ");

            while (i < 20)
            {
                // Genera entre 1 y 10
                aleatorios[i] = numAzar.Next(1, 11); 
                Console.Write(aleatorios[i] + " ");
                i = i + 1;
            }
            Console.WriteLine("\n");

            // Contamos las frecuencias usando un arreglo de tamaño 11
            int[] frecuencias = new int[11];
            i = 0;

            while (i < 20)
            {
                int numeroDato = aleatorios[i];
                frecuencias[numeroDato] = frecuencias[numeroDato] + 1;
                i = i + 1;
            }

            // Muestra las frecuencias y busca el más y menos repetido
            int masFrecuente = 1;
            int menosFrecuente = 1;
            
            // Inicializamos con valores primera posición real que es el indice 1
            int maxRepeticiones = frecuencias[1];
            int minRepeticiones = frecuencias[1];

            Console.WriteLine("---TABLA DE FRECUENCIAS---");
            i = 1;

            while (i <= 10)
            {
                Console.WriteLine($"Numero {i}: se repitio {frecuencias[i]} veces");

                if (frecuencias[i] > maxRepeticiones)
                {
                    maxRepeticiones = frecuencias[i];
                    masFrecuente = i;
                }
                if (frecuencias[i] < minRepeticiones)
                {
                    minRepeticiones = frecuencias[i];
                    menosFrecuente = i;
                }

                i = i + 1;
            }

            Console.WriteLine($"\nEl numero MAS frecuente es el: {masFrecuente} ({maxRepeticiones} veces)");
            Console.WriteLine($"El numero MENOS frecuente es el: {menosFrecuente} ({minRepeticiones} veces)");
        }
    }
}