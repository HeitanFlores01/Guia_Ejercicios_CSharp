namespace EjerciciosCSharp.VariablesOperadores

{
    public class AreaPerimetro
    {
        public AreaPerimetro(int opcion, float radio, float b, float h, float lado1, float lado2, float lado3, float b2, float h2, float Bm, float bm, float ladoIzq, float ladoDer, float h3)
        {
             switch (opcion)  
            {
                case 1: 
                    // Calculo de Area y Perímetro del circulo
                    double areaC = 3.1416 * (radio * radio);
                    Console.WriteLine($"El area del circulo es : {areaC}");

                    double perimetroC = 2 * 3.1416 * radio;
                    Console.WriteLine($"El perimetro del circulo es : {perimetroC}");
                    break;

                case 2:
                    // Calculo de Area y Perímetro del triángulo
                    double areaT = (b * h) / 2;
                    Console.WriteLine($"El area del triangulo es : {areaT}");

                    double perimetroT = lado1 + lado2 + lado3;
                    Console.WriteLine($"El perimetro del triangulo es : {perimetroT}");
                    break;

                case 3:
                    // Calculo de Area y Perímetro del rectángulo
                    double areaR = b2 * h2;
                    Console.WriteLine($"El area del rectangulo es : {areaR}");

                    double perimetroR = 2 * (b2 + h2);
                    Console.WriteLine($"El perimetro del rectangulo es : {perimetroR}");
                    break;

                case 4: 
                    // Calculo de Area y Perímetro del trapecio
                    double areaTra = ((Bm + bm) * h3) / 2;
                    Console.WriteLine($"El area del trapecio es : {areaTra}");

                    double perimetroTra = Bm + bm + ladoIzq + ladoDer;
                    Console.WriteLine($"El perimetro del trapecio es : {perimetroTra}");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    return;  
            }   
        }
    }
}