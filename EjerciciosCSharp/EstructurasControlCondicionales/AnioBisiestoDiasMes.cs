namespace EjerciciosCSharp.EstructurasControlCondicionales

{
    public class AnioBisiestoDiasMes
    {
        public AnioBisiestoDiasMes(int anio, int mes)
        {
            bool esBisiesto = false;
            // Evaluamos que el año sea bisiesto
            if ((anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0))
            {
                Console.WriteLine("El año es bisiesto");
                esBisiesto = true;
    
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
                esBisiesto = false;
            }

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("Este mes tiene 31 dias");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("Este mes tiene 30 dias");
            }
            else if (mes == 2)
            {
                // Se evalúa si es del año bisiesto
                if (esBisiesto == true)
                {
                    Console.WriteLine("Febrero tiene 29 días");
                }
                else
                {
                    Console.WriteLine("Febrero tiene 28 dias");
                }
            }
        }
    }
}