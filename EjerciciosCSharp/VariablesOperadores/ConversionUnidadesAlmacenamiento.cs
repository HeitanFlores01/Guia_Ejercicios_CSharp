namespace EjerciciosCSharp.VariablesOperadores

{
    public class ConversionUnidadesAlmacenamiento
    {
        public ConversionUnidadesAlmacenamiento(string unidad, double cantidad)
        {
            // Aca se guardara todo en el valor mínimo que son los bytes
            double totalBytes = 0;

            // Asignamos la cantidad de bytes que tiene cada unidad y multiplicamos para
            // realizar las conversiones de cada una
             switch (unidad)  
            {
                case "Bytes":
                    totalBytes = cantidad;
                    break;

                case "KB":
                    totalBytes = cantidad * 1024;
                    break;

                case "MB":
                    totalBytes = cantidad * 1024 * 1024;
                    break;

                case "GB":
                    totalBytes = cantidad * 1024 * 1024 * 1024;
                    break;

                case "TB":
        
                    totalBytes = cantidad * 1024 * 1024 * 1024 * 1024;
                    break;

                default:
                     Console.WriteLine("Unidad no valida, escriba bien los : Bytes, KB, MB, GB, TB");
                     return;     
            }

            // Aca ya se muestran todas las conversiones
            Console.WriteLine($"Equivalencias para {cantidad} {unidad}");
            Console.WriteLine($"Bytes: {totalBytes}"); 
            Console.WriteLine($"KB   : {totalBytes / 1024}");
            Console.WriteLine($"MB   : {totalBytes / (1024 * 1024)}");
            Console.WriteLine($"GB   : {totalBytes / (1024 * 1024 * 1024)}");
            Console.WriteLine($"TB   : {totalBytes / 1024 / 1024 / 1024 / 1024}");
        }
    }
}