namespace EjerciciosCSharp.ArreglosUnidimensionales

{
    public class ArregloTemperaturas
    {
        public ArregloTemperaturas()
        {
            double[] temps = new double[7];
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            // Capturamos los datos
            int i = 0;
            double suma = 0;

            while (i < 7)
            {
                Console.Write($"Digita la temperatura del {dias[i]}: ");
                temps[i] = Convert.ToDouble(Console.ReadLine());
                suma = suma + temps[i];
                i = i + 1;
            }

            double promedioSemanal = suma / 7;

            // Buscamos los días mas calurosos, fríos y días sobre promedio de los dos
            double masCaluroso = temps[0];
            double masFrio = temps[0];
            int diasSobrePromedio = 0;

            string diaCalurosoNombre = dias[0];
            string diaFrioNombre = dias[0];

            i = 0;

            while (i < 7)
            {
                if (temps[i] > promedioSemanal) { diasSobrePromedio = diasSobrePromedio + 1; }
                if (temps[i] > masCaluroso) { masCaluroso = temps[i]; diaCalurosoNombre = dias[i]; }
                if (temps[i] < masFrio) { masFrio = temps[i]; diaFrioNombre = dias[i]; }
                i = i + 1;
            }

            // Imprimimos todos los datos generales 
            Console.WriteLine($"\n---REPORTE SEMANAL---");
            Console.WriteLine($"Promedio semanal: {promedioSemanal}°C");
            Console.WriteLine($"Dias por encima del promedio: {diasSobrePromedio}");
            Console.WriteLine($"Dia mas caluroso: {diaCalurosoNombre} ({masCaluroso}°C)");
            Console.WriteLine($"Dia mas frio: {diaFrioNombre} ({masFrio}°C)");

            // Calculamos la variación entre días consecutivos 
            Console.WriteLine("\nVariacion consecutiva:");
            i = 0;

            // Solo llegamos a 6 porque domingo no tiene siguiente
            while (i < 6) 
            {
                double variacion = temps[i + 1] - temps[i];

                // Math.Abs convierte el número a positivo si da una resta negativa
                Console.WriteLine($"De {dias[i]} a {dias[i+1]}: Variacion de {Math.Abs(variacion)}°C");
                i = i + 1;
            }
        }
    }
}