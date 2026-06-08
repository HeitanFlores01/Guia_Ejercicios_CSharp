namespace EjerciciosCSharp.ArreglosBidimensionales

{
    public class MatrizNotasParcial
    {
        public MatrizNotasParcial(int n)
        {
            // Matriz: filas (estudiantes) x columnas (3 parciales)
            double[,] notas = new double[n, 3];
            double[] promedioEstudiantes = new double[n];

            // Ingreso de datos
            int f = 0;

            while (f < n)
            {
                Console.WriteLine($"\nEstudiante #{f + 1}:");
                int c = 0;
                double sumaEstudiante = 0;

                while (c < 3)
                {
                    Console.Write($"Nota Parcial {c + 1}: ");
                    notas[f, c] = Convert.ToDouble(Console.ReadLine());
                    sumaEstudiante = sumaEstudiante + notas[f, c];
                    c = c + 1;
                }

                promedioEstudiantes[f] = sumaEstudiante / 3;
                f = f + 1;
            }

            // Calculamos el promedio por parcial (Columnas)
            double[] promedioParciales = new double[3];
            int col = 0;

            while (col < 3)
            {
                double sumaParcial = 0;
                int fil = 0;
                while (fil < n)
                {
                    sumaParcial = sumaParcial + notas[fil, col];
                    fil = fil + 1;
                }
                promedioParciales[col] = sumaParcial / n;
                col = col + 1;
            }

            // Encontramos al mejor estudiante y parcial más difícil
            double mejorPromedio = promedioEstudiantes[0];
            int indiceMejorEstudiante = 0;
            f = 1;

            while (f < n)
            {
                if (promedioEstudiantes[f] > mejorPromedio)
                {
                    mejorPromedio = promedioEstudiantes[f];
                    indiceMejorEstudiante = f;
                }
                f = f + 1;
            }

            // El parcial más difícil es el que tenga el promedio de notas más bajo
            double peorPromedioParcial = promedioParciales[0];
            int parcialDificil = 1;
            int cX = 1;

            while (cX < 3)
            {
                if (promedioParciales[cX] < peorPromedioParcial)
                {
                    peorPromedioParcial = promedioParciales[cX];
                    parcialDificil = cX + 1;
                }
                cX = cX + 1;
            }

            Console.WriteLine("\n---REPORTE FINAL DE LA MATRIZ---");
            Console.WriteLine($"Promedio parcial 1: {promedioParciales[0]}");
            Console.WriteLine($"Promedio parcial 2: {promedioParciales[1]}");
            Console.WriteLine($"Promedio parcial 3: {promedioParciales[2]}");
            Console.WriteLine($"El estudiante con mejor rendimiento fue el estudiante #{indiceMejorEstudiante + 1} con promedio de: {mejorPromedio}");
            Console.WriteLine($"El parcial mas dificil de la clase fue el parcial: {parcialDificil}");
        }
    }
}