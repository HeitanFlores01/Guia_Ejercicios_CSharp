namespace EjerciciosCSharp.EstructurasControlCondicionales

{
    public class ClasificacionTriangulos
    {
        public ClasificacionTriangulos(float a, float b, float c)
        {
            // hacemos las evaluaciones que el triangulo tenga 3 lados y que cumpla cada 
            // requisito para que se cumpla uno de los 3 triángulos solicitados
            if((a + b > c) && (a + c > b) && (b + c > a))
            {
                if(a == b && b == c)
                {
                    Console.WriteLine("Es una triangulo equilatero");
                }
                else if(a == b && b != c)
                {
                    Console.WriteLine("Es un triangulo isosceles");
                }
                else if(a != b && b != c && a != c)
                {
                    Console.WriteLine("Es un triangulo escaleno");
                }

                if (a*a + b*b == c*c) 
                {
                    Console.WriteLine("Es un triangulo Rectangulo");
                }
                else if (a*a + b*b > c*c)
                {
                     Console.WriteLine("Es un triangulo acutangulo");
                }
                else
                {
                    Console.WriteLine("Es un triangulo obtusangulo");
                }
            }
            else
            {
                Console.WriteLine("Los lados ingresados no forman ningun triangulo valido");
            }
        }
    }
}