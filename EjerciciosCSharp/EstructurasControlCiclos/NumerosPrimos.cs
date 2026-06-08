namespace EjerciciosCSharp.EstructurasControlCiclos

{
    public class NumerosPrimos
    {
        public NumerosPrimos(int n1, int n2)
        {
            int contador = 0;
            int numeroActual = n1;

            // Evaluamos dentro del while que no que se repita el ciclo hasta el numero
            // limite ingresado
            while(numeroActual <= n2)
            {
                // evaluamos aca que sea mayor a 1 porque los números negativos y 1 no son primos 
                if(numeroActual > 1)
                {
                    // asumimos que es primo con la variable bandera
                    bool esPrimo = true;
                    int divisor = 2;

                    while(divisor < numeroActual)
                    {
                        // si el residuo da 0 la division es exacta 
                        if(numeroActual % divisor == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                        divisor++;
                    }

                    // si no se pudo dividir exactamente entonces es un primo y el contador
                    // hace su trabajo 
                    if(esPrimo == true)
                    {
                        Console.WriteLine($"Numero primo encontrado : {numeroActual}");
                        contador++;
                     }
                }
                numeroActual++;
            }
            Console.WriteLine($"Se encontraron en total : {contador} numeros primos");
        }
    }
}