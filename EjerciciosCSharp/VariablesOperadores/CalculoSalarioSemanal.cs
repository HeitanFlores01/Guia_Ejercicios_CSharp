namespace EjerciciosCSharp.VariablesOperadores

{
    public class CalculoSalarioSemanal
    {
        public CalculoSalarioSemanal(int cantidad, float tarifa)
        {
            // Se saca el salario semanal
            float Salario = cantidad * tarifa;
            double SalarioConExtra = 0;

            // Sacamos las horas extras si hay 
            double HorasExtras = tarifa * 1.5;

            // Evaluamos que la cantidad de horas semanales sea mayor a 44 horas para aplicar 
            // el de que se pagan con 150% mas 
            if(cantidad > 44)
            {
               SalarioConExtra = (44 * tarifa) + ((cantidad - 44) * HorasExtras);
            }
            else
            {
                Console.WriteLine("No tiene horas extras laboradas");
                SalarioConExtra = Salario;
            }

            // Evaluamos si trabajo mas de 44 horas, si es asi se restan 44 horas
            // y nos quedan las extras que se multiplican con lo que nos dan del 150% 
            // por trabajar horas extra en este caso tarifa * 1.5 y eso es las HorasExtras
            double dineroExtra = (cantidad > 44) ? (cantidad - 44) * HorasExtras : 0;

            Console.WriteLine("-----DESGLOSE SALARIO SEMANAL-----");
            Console.WriteLine($"El salario semanal base es de : {SalarioConExtra - dineroExtra}");
            Console.WriteLine($"Horas totales laboradas en la semana : {cantidad}");
            Console.WriteLine($"Horas extra laboradas : {(cantidad > 44 ? cantidad - 44 : 0)}");
            Console.WriteLine($"Pago por cada hora extra laborada : {HorasExtras}");
            Console.WriteLine($"Salario total más pago por horas extra : {SalarioConExtra}");
        }
    }
}