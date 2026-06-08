namespace EjerciciosCSharp.VariablesOperadores

{
    public class ConversionTemperatura
    {
        public ConversionTemperatura(int opcion, float temperatura)
        {
            // Usamos un switch para hacer un menu de opciones en el cual el usuario pueda
            // escoger que conversion realizar ya que cada una tiene su respectiva formula

            switch (opcion)  
            {
                case 1: 
                    // Celsius a Fahrenheit
                     double F = (temperatura * 1.8) + 32;
                     Console.WriteLine($"La temperatura en Fahrenheit es: {F}");
                     break;

                case 2:
                    // Celsius a Kelvin"
                     double K = temperatura + 273.15;
                     Console.WriteLine($"La temperatura en Kelvin es: {K}");
                     break;

                case 3:
                    // Fahrenheit a Celsius
                     double C = (temperatura - 32) / 1.8;
                     Console.WriteLine($"La temperatura en Celsius es: {C}");
                     break;     

                case 4: 
                    // Fahrenheit a Kelvin 
                     double k = ((temperatura - 32) / 1.8) + 273.15;
                     Console.WriteLine($"La temperatura en Kelvin es: {k}");
                     break;

                case 5:
                    // Kelvin a Fahrenheit
                     double f = ((temperatura - 273.15) * 1.8) + 32;
                     Console.WriteLine($"La temperatura en Fahrenheit es: {f}");
                     break;

                case 6:
                    // Kelvin a Celsius
                     double c = temperatura - 273.15;
                     Console.WriteLine($"La temperatura en Celsius es : {c}");
                     break;
                     
                default:
                     Console.WriteLine("Opcion no valida");
                     return;     
            }
        }
    }
}