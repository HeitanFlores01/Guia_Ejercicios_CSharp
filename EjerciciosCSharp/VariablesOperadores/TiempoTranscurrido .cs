namespace EjerciciosCSharp.VariablesOperadores

{
    public class TiempoTranscurrido 
    {
        public TiempoTranscurrido(int hora1, int minuto1, int segundo1, int hora2, int minuto2, int segundo2)
        {
            // Pasaremos las horas a segundos para trabajar en una solo unidad de tiempo
            int segundos1 = (hora1 * 3600) + (minuto1 * 60) + segundo1;
            int segundos2 = (hora2 * 3600) + (minuto2 * 60) + segundo2;

            // El math.abs hace que cualquier valor sea siempre positivo en este caso si 
            // tenemos un numero menor restando a uno mayor ya que las horas siempre son 
            // números enteros positivos
            int diferencia = Math.Abs(segundos1 - segundos2);

            // Pasamos los segundos de nuevo a formatos de horas, minutos

            int horasTotales = diferencia / 3600;
            int minutosTotales = (diferencia % 3600) / 60;
            int segundosTotales = diferencia % 60;

            Console.WriteLine($"Las horas de diferencia son : {horasTotales}:{minutosTotales}:{segundosTotales}");
        }
    }
}