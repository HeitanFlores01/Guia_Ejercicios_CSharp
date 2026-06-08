namespace EjerciciosCSharp.EstructurasControlCondicionales

{
    public class CalculadoraDescuentos
    {
        public CalculadoraDescuentos(float monto)
        {
            double descuento = 0;
            // usaremos if y else anidados para la validación dependiendo del rango de la compra 
            // para dar el descuento correspondiente 

           if(monto > 0 && monto < 500)
            {
               Console.WriteLine("No aplica para ningun descuento");
            }
            else if(monto >= 500 && monto <= 999)
            {
                descuento = monto * 0.05;
                Console.WriteLine($"Su compara tiene un descuento del 5% {descuento}");
            }
            else if(monto >= 1000 && monto <= 2499)
            {
                descuento = monto * 0.10;
                Console.WriteLine($"Su compara tiene un descuento del 10% {descuento}");
            }
            else 
            {
                descuento = monto * 0.15;
                Console.WriteLine($"Su compara tiene un descuento del 15% {descuento}");
            }

            // Se muestra todos los datos finales 
            Console.WriteLine("---DESCRIPCIONES DE SU COMPRA---");
            Console.WriteLine($"El valor de la compra es : {monto}");
            Console.WriteLine($"El descuento de la compra es : {descuento}");
            Console.WriteLine($"Total de la compra es : {monto - descuento}");
        }
    }
}