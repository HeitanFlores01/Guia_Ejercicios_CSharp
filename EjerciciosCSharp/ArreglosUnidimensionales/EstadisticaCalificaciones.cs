namespace EjerciciosCSharp.ArreglosUnidimensionales

{
    public class EstadisticaCalificaciones
    {
        public EstadisticaCalificaciones(int n)
        {
            // Creamos el arreglo con tamaño que indica el usuario
            double[] notas = new double[n];

            // llenamos el arreglo
            int i = 0;

            while (i < n)
            {
                Console.Write($"Digite la calificacion {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                i = i + 1;
            }

            double suma = 0;
            double maxima = notas[0];
            double minima = notas[0];
            int aprobados = 0;
            int reprobados = 0;

            i = 0;

            while (i < n)
            {
                suma = suma + notas[i];

                if (notas[i] > maxima) { maxima = notas[i]; }
                if (notas[i] < minima) { minima = notas[i]; }

                // Use el sistema de aprobación de la UNAH
                if (notas[i] >= 65)
                {
                    aprobados = aprobados + 1;
                }
                else
                {
                    reprobados = reprobados + 1;
                }

                i = i + 1;
            }

            double promedio = suma / n;

            // Aca se realiza el calculo de la desviación estándar
            double sumaDiferenciasCuadrado = 0;
            i = 0;
            
            while (i < n)
            {
                double diferencia = notas[i] - promedio;
                sumaDiferenciasCuadrado = sumaDiferenciasCuadrado + (diferencia * diferencia);
                i = i + 1;
            }

            double desviacionStandar = Math.Sqrt(sumaDiferenciasCuadrado / n);

            Console.WriteLine("---ESTADISTICAS DE CALIFICACIONES---");
            Console.WriteLine($"Promedio general: {promedio}");
            Console.WriteLine($"Nota maxima: {maxima}");
            Console.WriteLine($"Nota minima: {minima}");
            Console.WriteLine($"Cantidad de notas aprobadas: {aprobados}");
            Console.WriteLine($"Cantidad de notas reprobadas: {reprobados}");
            Console.WriteLine($"Desviacion estandar: {desviacionStandar}");
        }
    }
}