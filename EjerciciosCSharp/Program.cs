// Aca se ejecutaran todos los ejercicios de la unidad 1 

using EjerciciosCSharp.EstructurasControlCondicionales;
using EjerciciosCSharp.VariablesOperadores;
using EjerciciosCSharp.EstructuresControlCiclos;
using EjerciciosCSharp.ArreglosUnidimensionales;
using EjerciciosCSharp.ArreglosBidimensionales;

namespace EjerciciosCSharp.VariablesOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============ Bloque 1: Variables y Operadores ========================

            // Console.WriteLine("Ingrese su peso en kg por favor");
            // float peso = float.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese su altura en metros por favor");
            // float altura = float.Parse(Console.ReadLine()!);
            
            // CalculadoraIMC calculadoraIMC = new CalculadoraIMC(peso, altura);
            // ====================================================================

            // Console.WriteLine("Ingrese la temperatura");
            // float temperatura = float.Parse(Console.ReadLine()!);

            // Console.WriteLine("---MENU DE OPCIONES CONVERSION DE TEMPERATURA---");
            // Console.WriteLine("1. Celsius a Fahrenheit"); 
            // Console.WriteLine("2. Celsius a Kelvin");
            // Console.WriteLine("3. Fahrenheit a Celsius");
            // Console.WriteLine("4. Fahrenheit a Kelvin");
            // Console.WriteLine("5. Kelvin a Fahrenheit");
            // Console.WriteLine("6. Kelvin a Celsius");

            // Console.WriteLine("Seleccione una opcion a convertir");
            // int opcion = int.Parse(Console.ReadLine()!);

            // ConversionTemperatura conversionTemperatura = new ConversionTemperatura(opcion, temperatura);
            // =============================================================================================

            // Console.WriteLine("Ingrese un monto a desglosar");
            // int monto = int.Parse(Console.ReadLine()!);

            // DesgloseBilletes desgloseBilletes = new DesgloseBilletes(monto);
            // =========================================================================

            // Console.WriteLine("Ingrese un monto por favor");
            // float monto = float.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese la tasa de interes anual");
            // float interes = float.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese el plazo en meses");
            // float tiempo = float.Parse(Console.ReadLine()!);

            // PrestamoSimple prestamoSimple = new PrestamoSimple(monto, interes, tiempo);
            // ===========================================================================

            // Console.WriteLine("Ingrese las horas a sacar diferencia en formato de 24 horas");
            // Console.WriteLine("Ingrese la primer hora");          
            // int hora1 = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese el minuto");
            // int minuto1 = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese el segundo");
            // int segundo1 = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese la segunda hora");          
            // int hora2 = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese el minuto");
            // int minuto2 = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese el segundo");
            // int segundo2 = int.Parse(Console.ReadLine()!);

            // TiempoTranscurrido tiempoTranscurrido = new TiempoTranscurrido(hora1, minuto1, segundo1, hora2, minuto2, segundo2);
            // ===================================================================================================================

            // Console.WriteLine("---MENU DE OPCIONES PARA CALCULO DE AREA Y PERIMETRO---");
            // Console.WriteLine("1. Circulo"); 
            // Console.WriteLine("2. Triangulo");
            // Console.WriteLine("3. Rectangulo");
            // Console.WriteLine("4. Trapecio");

            // Console.WriteLine("Seleccione la opcion que desea calcular");
            // int opcion = int.Parse(Console.ReadLine()!);

            // float radio = 0, b = 0, h = 0, lado1 = 0, lado2 = 0, lado3 = 0;
            // float b2 = 0, h2 = 0, Bm = 0, bm = 0, ladoIzq = 0, ladoDer = 0, h3 = 0;

            // switch (opcion)
            // {
            //     case 1:
            //         Console.WriteLine("Ingrese el radio");
            //         radio = float.Parse(Console.ReadLine()!);
            //         if (radio <= 0)
            //         { 
            //             Console.WriteLine("Error: El valor debe ser positivo");
            //             return;
            //         }
            //         break;

            //     case 2:
            //         Console.WriteLine("Ingrese la base y la altura");
            //         b = float.Parse(Console.ReadLine()!);
            //         h = float.Parse(Console.ReadLine()!);
            //         if (b <= 0 || h <= 0) 
            //         { 
            //             Console.WriteLine("Error: Los valores deben ser positivos");
            //             return;
            //         }

            //         Console.WriteLine("Ingrese el lado 1, 2 y 3");
            //         lado1 = float.Parse(Console.ReadLine()!);
            //         lado2 = float.Parse(Console.ReadLine()!);
            //         lado3 = float.Parse(Console.ReadLine()!);
            //         if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            //         { 
            //             Console.WriteLine("Error: Los lados deben ser positivos");
            //             return;
            //         }
            //         break;

            //     case 3:
            //         Console.WriteLine("Ingrese la base y la altura");
            //         b2 = float.Parse(Console.ReadLine()!);
            //         h2 = float.Parse(Console.ReadLine()!);
            //         if (b2 <= 0 || h2 <= 0)
            //         {
            //             Console.WriteLine("Error: Los valores deben ser positivos.");
            //             return;
            //         }
            //         break;

            //     case 4:
            //         Console.WriteLine("Ingrese la base mayor, base menor, lado izquierdo, lado derecho y altura");
            //         Bm = float.Parse(Console.ReadLine()!);
            //         bm = float.Parse(Console.ReadLine()!);
            //         ladoIzq = float.Parse(Console.ReadLine()!);
            //         ladoDer = float.Parse(Console.ReadLine()!);
            //         h3 = float.Parse(Console.ReadLine()!);
            //         if (Bm <= 0 || bm <= 0 || ladoIzq <= 0 || ladoDer <= 0 || h3 <= 0) 
            //         {
            //             Console.WriteLine("Error: Todos los valores deben ser positivos.");
            //             return;
            //         }
            //         break;

            //     default:
            //     Console.WriteLine("Opcion no valida");
            //     return;
            // }

            // AreaPerimetro areaPerimetro = new AreaPerimetro(opcion, radio, b, h, lado1, lado2, lado3, b2, h2, Bm, bm, ladoIzq, ladoDer, h3);
            // =================================================================================================================================

            // Console.WriteLine("Ingrese la unidad a convertir Bytes, KB, GB, TB");
            // string unidad = Console.ReadLine()!;

            // Console.WriteLine("Ingrese la cantidad");
            // double cantidad = double.Parse(Console.ReadLine()!);

            // ConversionUnidadesAlmacenamiento conversionUnidadesAlmacenamiento = new ConversionUnidadesAlmacenamiento(unidad, cantidad);
            // ============================================================================================================================

            // Console.WriteLine("Ingrese la cantidad de horas laboradas");
            // int cantidad = int.Parse(Console.ReadLine()!);
            
            // Console.WriteLine("Ingrese la tarifa por hora");
            // float tarifa = float.Parse(Console.ReadLine()!);

            // CalculoSalarioSemanal calculoSalarioSemanal = new CalculoSalarioSemanal(cantidad, tarifa);
            // ===========================================================================================

            
            // ============ Bloque 2: Estructuras de Control - Condicionales =====================

            // Console.WriteLine("Ingrese tres lados por favor");
            // float a = float.Parse(Console.ReadLine()!);
            // float b = float.Parse(Console.ReadLine()!);
            // float c = float.Parse(Console.ReadLine()!);

            // ClasificacionTriangulos clasificacionTriangulos = new ClasificacionTriangulos(a, b, c);
            // ========================================================================================

            // Console.WriteLine("Ingrese una nota en rango de (0 - 100) por favor");
            // float nota = float.Parse(Console.ReadLine()!);

            // SistemaCalificacionesUNAH sistemaCalificacionesUNAH = new SistemaCalificacionesUNAH(nota);
            // ===========================================================================================

            // Console.WriteLine("Ingrese el monto de la compra");
            // float monto = float.Parse(Console.ReadLine()!);

            // CalculadoraDescuentos calculadoraDescuentos = new CalculadoraDescuentos(monto);
            // ================================================================================

            // Console.WriteLine("Ingrese un año por favor");
            // int anio = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese un mes (1 - 12)");
            // int mes = int.Parse(Console.ReadLine()!);

            // AnioBisiestoDiasMes anioBisiestoDiasMes = new AnioBisiestoDiasMes(anio, mes);
            // =============================================================================

            // Console.WriteLine("Ingrese un año por favor");
            // int anio = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese un mes (1 - 12)");
            // int mes = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese un dia");
            // int dia = int.Parse(Console.ReadLine()!);

            // ValidarFecha validarFecha = new ValidarFecha(anio, mes, dia);
            // ===========================================================================

            // Console.WriteLine("Ingrese el monto a retirar");
            // int monto = int.Parse(Console.ReadLine()!);

            // CajeroAutomatico cajeroAutomatico = new CajeroAutomatico(monto);
            // ===========================================================================

            // ================ Bloque 3: Estructuras de Control - Ciclos =================

            // Console.WriteLine("Ingrese el numero tabla que desea ver");
            // int tabla = int.Parse(Console.ReadLine()!);

            // TablaMultiplicarExtendida tablaMultiplicarExtendida = new TablaMultiplicarExtendida(tabla);
            // ===========================================================================================

            // Console.WriteLine("Ingrese un numero para inicio");
            // int n1 = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese un numero de rango final");
            // int n2 = int.Parse(Console.ReadLine()!);

            // NumerosPrimos numerosPrimos = new NumerosPrimos(n1, n2);
            // ================================================================

            // Console.WriteLine("Ingrese un numero por favor");
            // int n = int.Parse(Console.ReadLine()!);

            // SerieFibonacci serieFibonacci = new SerieFibonacci(n);
            // ===================================================================

            // Console.WriteLine("Ingrese el valor de n por favor");
            // int n = int.Parse(Console.ReadLine()!);

            // Console.WriteLine("Ingrese el valor de r");
            // int r = int.Parse(Console.ReadLine()!);

            // FactorialCombinaciones factorialCombinaciones = new FactorialCombinaciones(n, r);
            // =================================================================================

            // JuegoAdivinanza juegoAdivinanza = new JuegoAdivinanza();
            // =============================================================================

            // ValidacionContrasena validacionContrasena = new ValidacionContrasena();
            // =============================================================================

            // Console.WriteLine("---GENERADOR DE PATRONES DE ASTERISCOS---");
            // Console.WriteLine("1. Triangulo");
            // Console.WriteLine("2. Triangulo invertido");
            // Console.WriteLine("3. Cuadrado hueco");
            // int opcion = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Digita el tamano de la figura: ");
            // int tamano = Convert.ToInt32(Console.ReadLine());

            // PatronAsteriscos patronAsteriscos = new PatronAsteriscos(opcion, tamano);
            // =============================================================================

            // CalculadoraMenu calculadoraMenu = new CalculadoraMenu();
            // =============================================================================

            // ========== Bloque 4: Arreglos Unidimensionales =============================

            // Console.Write("Digita la cantidad de calificaciones (n): ");
            // int n = Convert.ToInt32(Console.ReadLine());

            // EstadisticaCalificaciones estadisticaCalificaciones = new EstadisticaCalificaciones(n);
            // =======================================================================================

            // Console.Write("Digita el numero que deseas buscar: ");
            // int buscar = Convert.ToInt32(Console.ReadLine());

            // BusquedaOrdenamiento busquedaOrdenamiento = new BusquedaOrdenamiento(buscar);
            // =======================================================================================

            // Console.Write("Digita el tamano del arreglo (N): ");
            // int n = Convert.ToInt32(Console.ReadLine());

            // RotacionArreglo rotacionArreglo = new RotacionArreglo(n);
            // ==================================================================================

            // FrecuenciaElementos frecuenciaElementos = new FrecuenciaElementos();
            // ==================================================================================

            // ArregloTemperaturas arregloTemperaturas = new ArregloTemperaturas();
            // ==================================================================================

            // ==================== Bloque 5: Arreglos Bidimensionales ==========================

            // Console.Write("Digite la cantidad de estudiantes: ");
            // int n = Convert.ToInt32(Console.ReadLine());

            // MatrizNotasParcial matrizNotasParcial = new MatrizNotasParcial(n);
            // ==================================================================================

            // JuegoGato juegoGato = new JuegoGato();
            // ==================================================================================

            // InventarioSimple inventarioSimple = new InventarioSimple();
            // ==================================================================================
        }
    }
}