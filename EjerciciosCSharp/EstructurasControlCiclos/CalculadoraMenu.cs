namespace EjerciciosCSharp.EstructuresControlCiclos

{
    public class CalculadoraMenu
    {
        public CalculadoraMenu()
        {
            // Usamos el double para decimales para operaciones que están encadenadas
            double resultadoAcumulado = 0;
            int opcion = 0;

            // El ciclo opera en el menu hasta que el usuario escoja salir 
            // siempre se inicia en suma para poder agregar una cantidad 
            // para llevar esa cadena y usar las demás operaciones
            while (opcion != 8)
            {
                Console.WriteLine($"Resultado actual: {resultadoAcumulado}");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raiz Cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Salir");
                Console.Write("Elige una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                // Aca se realizan todas las operaciones que se pueden realizar
                if (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4 || opcion == 5 || opcion == 7)
                {
                    Console.Write("Digita el numero: ");
                    double numero = Convert.ToDouble(Console.ReadLine());

                    if (opcion == 1)
                    {
                        resultadoAcumulado = resultadoAcumulado + numero;
                    }
                    else if (opcion == 2)
                    {
                        resultadoAcumulado = resultadoAcumulado - numero;
                    }
                    else if (opcion == 3)
                    {
                        resultadoAcumulado = resultadoAcumulado * numero;
                    }
                    else if (opcion == 4)
                    {
                        resultadoAcumulado = resultadoAcumulado / numero;
                    }
                    else if (opcion == 5)
                    {
                        // usamos el Math.Pow para sacar potencias 
                        resultadoAcumulado = Math.Pow(resultadoAcumulado, numero);
                    }
                    else if (opcion == 7)
                    {
                        // Aca sacamos los porcentajes
                        resultadoAcumulado = resultadoAcumulado * (numero / 100);
                    }
                }

                // Se usa el Math.Sqrt para la raíz cuadrada
                else if (opcion == 6)
                {
                    resultadoAcumulado = Math.Sqrt(resultadoAcumulado);
                }
                else if (opcion == 8)
                {
                    Console.WriteLine("Saliendo de la calculadora....");
                }
                else
                {
                    Console.WriteLine("Opcion no valida.");
                }
            }
        }
    }
}