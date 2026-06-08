namespace EjerciciosCSharp.CalculadoraIMC

{
    public class CalculadoraIMC
    {
        public CalculadoraIMC(float peso, float altura)
        {
            // Formula para calcular porcentaje de grasa corporal
            float IMC = peso/(altura*altura);

            Console.WriteLine($"Su porcentaje de grasa corporal es : {IMC}");

            // Evaluamos los rangos en los que se debe de encontrar la grasa corporal 
            // que son los porcentajes que se muestran a continuación
            if(IMC < 18.5)
            {
                Console.WriteLine("Su peso es bajo");
            }
            else if(IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Su peso esta en un rango normal y saludable");
            }
            else if(IMC >= 25 && IMC <= 29.9)
            {
                Console.WriteLine("Tiene sobrepeso");
            }
            else if(IMC > 30)
            {
                Console.WriteLine("Sufre de obesidad");
            }
        }
    }
}