namespace EjerciciosCSharp.EstructurasControlCondicionales

{
    public class CajeroAutomatico
    {
        public CajeroAutomatico(int monto)
        {
            int saldo = 5000;

            // Evaluamos que cada retiro sea de 20 en 20
            if(monto % 20 == 0)
            {
                if(monto > saldo)
                {
                Console.WriteLine("El saldo es insufiente para el retiro");
                }
                else 
                {
                    saldo = saldo - monto;
                    Console.WriteLine($"El monto retirado es de : {monto}");

                    // Calculamos cuantos billetes de 20 son
                    int billetes20 = monto / 20;
                    Console.Write($"Billetes entregados : {billetes20}\n");

                }
            }
            else
            {
                Console.WriteLine("Lo sentimos el monto a retirar debe de ser multiplos de 20");
            }

             Console.WriteLine($"El saldo restante es de : {saldo}");
        }
    }
}