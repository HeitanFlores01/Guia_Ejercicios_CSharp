namespace EjerciciosCSharp.EstructurasControlCondicionales

{
    public class ValidarFecha
    {
        public ValidarFecha(int anio, int mes, int dia)
        {
             bool esBisiesto = false;
             int diasMaximos;

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

            // validación de rango de días de cada mes, el máximo dia qye tiene cada uno
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                diasMaximos = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                diasMaximos = 30;
            }
            else if (mes == 2)
            {
                // Se evalúa si el mes tiene 29 días para el año bisiesto
                if (esBisiesto == true)
                {
                    diasMaximos = 29;
                }
                else
                {
                    diasMaximos = 28;
                }
            }
            else
            {
                diasMaximos = 0;
            }

            // Evalúa que los días estén en el rango estimado
            if (dia >= 1 && dia <= diasMaximos)
            {
                Console.WriteLine("La fecha es valida y real");
            }
            else
            {
                Console.WriteLine("La fecha es inválida");
            }
        }
    }
}