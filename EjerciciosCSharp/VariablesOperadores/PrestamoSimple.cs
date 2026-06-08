namespace EjerciciosCSharp.VariablesOperadores

{
    public class PrestamoSimple
    {
        public PrestamoSimple(float monto, float interes, float tiempo)
        {
            // Dividimos el interés  entre 1200 para pasar el interés anual a mensual y
            // convertir el porcentaje entero a decimal y aplicar la formula interés simple
            float tasaMensual = interes / 1200;

            // Para el calculo del interés total usamos la siguiente formula
            float interesTotal = monto * tasaMensual * tiempo;

            Console.WriteLine($"El interes total es de : {interesTotal}");

            // Para calculo de la cuota mensual fija 
            float CuotaFija = (monto + interesTotal) / tiempo;

            Console.WriteLine($"La cuota mensual fija es de : {CuotaFija}");
        }
    }
}