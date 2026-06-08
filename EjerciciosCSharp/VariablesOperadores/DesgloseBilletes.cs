namespace EjerciciosCSharp.VariablesOperadores

{
    public class DesgloseBilletes
    {
        public DesgloseBilletes(int monto)
        {
            // Declaramos las variables a utilizar
            int cantidad;
            int residuo;

            // Lo que se hace a continuación es que el monto original se va dividiendo entre
            // los billetes dados para sacar la cantidad de billetes a utilizar y después el
            // sacamos el porcentaje que seria monto restante y este se va guardando en la 
            // variable residuo y eso se aplica sucesivamente con los billetes restantes que 
            // son los de 100, 50, 20, 10, 5, 2 hasta que el residuo quede en 1

            Console.WriteLine("La menor cantidad en :");

            // Billetes de 500
            cantidad = monto / 500;
            residuo = monto % 500;
            Console.WriteLine($"Billetes de 500 es : {cantidad}");

            // Billetes de 100
            cantidad = residuo / 100;
            residuo = residuo % 100;
            Console.WriteLine($"Billetes de 100 es : {cantidad}");

            // Billetes de 50
            cantidad = residuo / 50;
            residuo = residuo % 50;
            Console.WriteLine($"Billetes de 50 es : {cantidad}");

            // Billetes de 20
            cantidad = residuo / 20;
            residuo = residuo % 20;
            Console.WriteLine($"Billetes de 20 es : {cantidad}");

            // Billetes de 10 
            cantidad = residuo / 10;
            residuo = residuo % 10;
            Console.WriteLine($"Billetes de 10 es : {cantidad}");

            // Billetes de 5
            cantidad = residuo / 5;
            residuo = residuo % 5;
            Console.WriteLine($"Billetes de 5 es : {cantidad}");

            // Billetes de 2
            cantidad = residuo / 2;
            residuo = residuo % 2;
            Console.WriteLine($"Billetes de 2 es : {cantidad}");

            // Billetes de 1
            cantidad = residuo / 1;
            residuo = residuo % 1;
            Console.WriteLine($"Billetes de 1 es : {cantidad}");
        }
    }
}