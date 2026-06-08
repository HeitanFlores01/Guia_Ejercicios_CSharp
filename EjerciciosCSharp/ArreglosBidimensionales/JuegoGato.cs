namespace EjerciciosCSharp.ArreglosBidimensionales

{
    public class JuegoGato
    {
        public JuegoGato()
        {
            char[,] tablero = new char[3, 3];
            bool jugarDeNuevo = true;

            while (jugarDeNuevo == true)
            {
                // limpiamos o iniciamos el juego con espacios vacíos
                int f = 0;
                while (f < 3)
                {
                    int c = 0;
                    while (c < 3)
                    {
                        tablero[f, c] = '-';
                        c = c + 1;
                    }
                    f = f + 1;
                }

                char jugadorActual = 'X';
                bool hayGanador = false;
                int movimientos = 0;

                // Ciclo principal de la partida (son máximo 9 movimientos)
                while (hayGanador == false && movimientos < 9)
                {
                    // Dibujar tablero en pantalla
                    Console.Clear();
                    Console.WriteLine("=== JUEGO DEL GATO ===");
                    Console.WriteLine($"  0   1   2");
                    Console.WriteLine($"0 {tablero[0, 0]} | {tablero[0, 1]} | {tablero[0, 2]}");
                    Console.WriteLine(" ---+---+---");
                    Console.WriteLine($"1 {tablero[1, 0]} | {tablero[1, 1]} | {tablero[1, 2]}");
                    Console.WriteLine(" ---+---+---");
                    Console.WriteLine($"2 {tablero[2, 0]} | {tablero[2, 1]} | {tablero[2, 2]}");

                    Console.WriteLine($"\nTurno del Jugador [{jugadorActual}]");
                    Console.Write("Digita la fila (0-2): ");
                    int filaTiro = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digita la columna (0-2): ");
                    int colTiro = Convert.ToInt32(Console.ReadLine());

                    // Aca se realiza la validación de coordenadas correctas y casilla vacía
                    if (filaTiro >= 0 && filaTiro <= 2 && colTiro >= 0 && colTiro <= 2 && tablero[filaTiro, colTiro] == '-')
                    {
                        tablero[filaTiro, colTiro] = jugadorActual;
                        movimientos = movimientos + 1;

                        // Verificamos si el jugador actual ganó con este tiro
                        // Revisamos las filas e igualdades
                        if ((tablero[0, 0] == jugadorActual && tablero[0, 1] == jugadorActual && tablero[0, 2] == jugadorActual) ||
                            (tablero[1, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[1, 2] == jugadorActual) ||
                            (tablero[2, 0] == jugadorActual && tablero[2, 1] == jugadorActual && tablero[2, 2] == jugadorActual) ||
                            // Revisamos columnas
                            (tablero[0, 0] == jugadorActual && tablero[1, 0] == jugadorActual && tablero[2, 0] == jugadorActual) ||
                            (tablero[0, 1] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 1] == jugadorActual) ||
                            (tablero[0, 2] == jugadorActual && tablero[1, 2] == jugadorActual && tablero[2, 2] == jugadorActual) ||
                            // Diagonales
                            (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual) ||
                            (tablero[0, 2] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 0] == jugadorActual))
                        {
                            hayGanador = true;
                            Console.Clear();
                            Console.WriteLine($"EL JUGADOR [{jugadorActual}] ES EL GANADOR");
                        }
                        else
                        {
                            // Cambiar de turno si no se ha ganado
                            if (jugadorActual == 'X') { jugadorActual = 'O'; }
                            else { jugadorActual = 'X'; }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Movimiento invalido, presione ENTER e intente otra casilla");
                        Console.ReadLine();
                    }
                }

                if (hayGanador == false && movimientos == 9)
                {
                    Console.WriteLine("¡Es un Empate!");
                }

                Console.Write("\n¿Quieres jugar otra partida? (1=Si / 2=No): ");
                int respuesta = Convert.ToInt32(Console.ReadLine());
                if (respuesta != 1)
                {
                    jugarDeNuevo = false;
                }
            }
        }
    }
}