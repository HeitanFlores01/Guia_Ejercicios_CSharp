namespace EjerciciosCSharp.EstructuresControlCiclos
{
    public class JuegoAdivinanza
    {
        public JuegoAdivinanza()
        {
            // Lo investigue y  Random azar se utiliza para generar números aleatorios
            Random azar = new Random();
            
            // Aca se genera el número aleatorio entre 1 y 100
            int numeroSecreto = azar.Next(1, 101); 

            int intentoActual = 1;
            bool adivino = false;

            Console.WriteLine("---JUEGO DE ADIVINANZA---");
            Console.WriteLine("Adivina el numero entre 1 y 100 en 7 intentos");
            Console.WriteLine("-----------------------------------------");

            // El ciclo se repite hasta llegar al intento 7
            while (intentoActual <= 7)
            {
                if (adivino == false)
                {
                    Console.Write("Digita tu numero :");
                    int numeroUsuario = Convert.ToInt32(Console.ReadLine());

                    if (numeroUsuario == numeroSecreto)
                    {
                        Console.WriteLine("Ganaste, adivinaste el numero");
                        adivino = true;
                    }
                    else
                    {
                        // Muestra si el numero aleatorio es mayor o menor y imprime 
                        // el numero de intentos restantes 
                        if (numeroUsuario < numeroSecreto)
                        {
                            Console.WriteLine("El numero secreto es MAYOR");
                        }
                        else
                        {
                            Console.WriteLine("El numero secreto es MENOR");
                        }
                        
                        Console.WriteLine($"Te quedan  {7 - intentoActual} intentos");
                        Console.WriteLine("-----------------------------------------");
                    }
                }

                // registra los intentos 
                intentoActual = intentoActual + 1;
            }

            Console.WriteLine("---FIN DEL JUEGO---");
            
            if (adivino == true)
            {
                Console.WriteLine("Estado: Victoria");
            }
            else
            {
                Console.WriteLine("Estado: Derrota");
                Console.WriteLine($"El numero secreto era: {numeroSecreto}");
            }
        }
    }
}