namespace EjerciciosCSharp.EstructurasControlCondicionales

{
    public class SistemaCalificacionesUNAH
    {
        public SistemaCalificacionesUNAH(float nota)
        {
            // Validamos todos los rangos de las notas de aprobación usando if y else anidados
            if(nota > 0 && nota <= 100)
            {
                if(nota >= 90 && nota <= 100)
                {
                Console.WriteLine("Felicidades, ha aprobado con una nota excelente -A-");
                }
                else if(nota >= 80 && nota <= 89)
                {
                    Console.WriteLine("Felicidades, ha aprobado con una nota muy buena -B-");
                }
                else if(nota >= 75 && nota <= 79)
                {
                    Console.WriteLine("Felicidades, ha aprobado con una nota buena -C-");
                }
                else if(nota >= 65 && nota <= 74)
                {
                    Console.WriteLine("Felicidades, ha aprobado con una nota satisfactoria -D-");
                }
                else
                {
                    Console.WriteLine("Lo sentimos, ha reprobado con una nota -F-");
                }
            }
            else
            {
                Console.WriteLine("La nota ingresada no esta en el rango permitido");
            }
        }
    }
}