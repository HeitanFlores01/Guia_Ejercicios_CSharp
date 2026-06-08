namespace EjerciciosCSharp.EstructuresControlCiclos
{
    public class FactorialCombinaciones
    {
        public FactorialCombinaciones(int n, int r)
        {
            // validamos que n sea mayor o igual a r
            if (n < 0 || r < 0 || n < r)
            {
                Console.WriteLine("n debe ser mayor o igual a r y no pueden ser negativos");
            }
            else
            {
                // utilizamos la variable long porque algunos valores son demasiado grandes
                // Calculo factorial de n
                long factN = 1;
                int i = 1;
                while (i <= n)
                {
                    factN = factN * i;
                    i++;
                }

                // Calculo factorial de r
                long factR = 1;
                int j = 1;
                while (j <= r)
                {
                    factR = factR * j;
                    j++;
                }

                // Calculo factorial de (n - r) 
                long factNMR = 1;
                int k = 1;
                int resta = n - r;
                while (k <= resta)
                {
                    factNMR = factNMR * k;
                    k++;
                }

                // Utilizamos la formula 
                long combinaciones = factN / (factR * factNMR);

                Console.WriteLine($"Factorial de n es : {factN}");
                Console.WriteLine($"Factorial de r es : {factR}");
                Console.WriteLine($"Factorial de la resta es : {factNMR}");
                Console.WriteLine($"El total de combinaciones es : {combinaciones}");
            }
        }
    }
}