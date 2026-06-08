namespace EjerciciosCSharp.EstructurasControlCiclos

{
    public class SerieFibonacci
    {
        public SerieFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int contador = 1;
            double sumaTotal = 0;

            Console.WriteLine($"---Los primeros {n} términos de Fibonacci---");

            // ciclo para generar los números 
            while (contador <= n)
            {
                Console.WriteLine($"{a} ");

                // sumamos al acumulador
                sumaTotal += a;

                // Calculo de la serie Fibonacci
                int siguiente = a + b;

                // intercambiamos valores 
                a = b;
                b = siguiente;
                contador++;
            }

            double promedio = sumaTotal / n;

            Console.WriteLine($"\nSuma total : {sumaTotal}");
            Console.WriteLine($"Promedio   : {promedio}");
        }
    }
}