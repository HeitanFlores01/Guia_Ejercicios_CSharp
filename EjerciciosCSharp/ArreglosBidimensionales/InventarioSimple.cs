using System;

namespace EjerciciosCSharp.ArreglosBidimensionales
{
    public class InventarioSimple
    {
        public InventarioSimple()
        {
            // Matriz numérica: 5 filas (productos), 3 columnas (0=Codigo, 1=Cantidad, 2=Precio)
            double[,] datosNumericos = new double[5, 3];

            // Este es un arreglo paralelo para guardar los nombres de esos mismos 5 productos
            string[] nombres = new string[5];

            // Inicializamos el inventario con datos base para que no empiece vacío
            datosNumericos[0, 0] = 101; datosNumericos[0, 1] = 10; datosNumericos[0, 2] = 15.50; nombres[0] = "Lapiz";
            datosNumericos[1, 0] = 102; datosNumericos[1, 1] = 25; datosNumericos[1, 2] = 45.00; nombres[1] = "Cuaderno";
            datosNumericos[2, 0] = 103; datosNumericos[2, 1] = 5;  datosNumericos[2, 2] = 120.00; nombres[2] = "Mochila";
            datosNumericos[3, 0] = 104; datosNumericos[3, 1] = 50; datosNumericos[3, 2] = 5.25;  nombres[3] = "Borrador";
            datosNumericos[4, 0] = 105; datosNumericos[4, 1] = 15; datosNumericos[4, 2] = 30.00; nombres[4] = "Regla";

            int menuOpcion = 0;

            while (menuOpcion != 5)
            {
                Console.WriteLine("\n=== SISTEMA DE INVENTARIO (5 PRODUCTOS) ===");
                Console.WriteLine("1. Mostrar Inventario Completo");
                Console.WriteLine("2. Buscar Producto por Codigo");
                Console.WriteLine("3. Actualizar Cantidad de Stock");
                Console.WriteLine("4. Calcular Valor Total del Inventario");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opcion: ");
                menuOpcion = Convert.ToInt32(Console.ReadLine());

                // Mostrar inventario
                if (menuOpcion == 1)
                {
                    Console.WriteLine("\nCODIGO\tNOMBRE\t\tCANTIDAD\tPRECIO");
                    int i = 0;
                    while (i < 5)
                    {
                        Console.WriteLine($"{datosNumericos[i, 0]}\t{nombres[i]}\t\t{datosNumericos[i, 1]}\t\tL. {datosNumericos[i, 2]}");
                        i = i + 1;
                    }
                }

                // Se encarga de buscar el producto
                else if (menuOpcion == 2)
                {
                    Console.Write("Ingresa el codigo del producto a buscar: ");
                    double buscarCod = Convert.ToDouble(Console.ReadLine());
                    int indiceEncontrado = -1;

                    int i = 0;

                    while (i < 5)
                    {
                        if (datosNumericos[i, 0] == buscarCod) { indiceEncontrado = i; }
                        i = i + 1;
                    }

                    if (indiceEncontrado != -1)
                    {
                        Console.WriteLine($"Encontrado -> Nombre: {nombres[indiceEncontrado]}, Stock: {datosNumericos[indiceEncontrado, 1]}, Precio: L. {datosNumericos[indiceEncontrado, 2]}");
                    }
                    else { Console.WriteLine("Producto no registrado"); }
                }

                // Actualiza la cantidad 
                else if (menuOpcion == 3)
                {
                    Console.Write("Ingresa el codigo del producto: ");
                    double buscarCod = Convert.ToDouble(Console.ReadLine());
                    int indiceEncontrado = -1;

                    int i = 0;

                    while (i < 5)
                    {
                        if (datosNumericos[i, 0] == buscarCod) { indiceEncontrado = i; }
                        i = i + 1;
                    }

                    if (indiceEncontrado != -1)
                    {
                        Console.Write($"Stock actual de {nombres[indiceEncontrado]} es {datosNumericos[indiceEncontrado, 1]}. Escribe el nuevo Stock: ");
                        datosNumericos[indiceEncontrado, 1] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Cantidad modificada con exito");
                    }
                    else { Console.WriteLine("Codigo no encontrado"); }
                }

                // Valor total del inventario
                else if (menuOpcion == 4)
                {
                    double valorTotal = 0;
                    int i = 0;

                    while (i < 5)
                    {
                        // Se realiza la siguiente operación y se va acumulando 
                        valorTotal = valorTotal + (datosNumericos[i, 1] * datosNumericos[i, 2]);
                        i = i + 1;
                    }
                    Console.WriteLine($"El valor financiero total de la mercancia es: L. {valorTotal}");
                }
            }
        }
    }
}