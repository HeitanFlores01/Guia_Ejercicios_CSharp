namespace EjerciciosCSharp.EstructuresControlCiclos
{
    public class ValidacionContrasena
    {
        public ValidacionContrasena()
        {
            bool contraValida = false;

            Console.WriteLine("---REGISTRO DE CONTRASEÑA SEGURA---");
            Console.WriteLine("Tu contraseña debe tener:");
            Console.WriteLine("Minimo 8 caracteres");
            Console.WriteLine("Al menos una mayuscula");
            Console.WriteLine("Al menos una minuscula");
            Console.WriteLine("Al menos un numero");
            Console.WriteLine("Al menos un caracter especial (@, #, $, etc.)");
            Console.WriteLine("------------------------------------------------");

            // El ciclo se repite mientras la contraseña no sea valida
            while (contraValida == false)
            {
                Console.WriteLine("Digita tu contrasena: ");
                string contra = Console.ReadLine()!;

                // Usamos banderas para cada intento
                bool tieneMayuscula = false;
                bool tieneMinuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                // Revisamos letra por letra 
                foreach (char letra in contra)
                {
                    // char.IsUpper  pregunta si la letra esta en mayuscula
                    if (char.IsUpper(letra) == true)
                    {
                        tieneMayuscula = true;
                    }

                    // char.IsLower pregunta si la letra esya en minuscula
                    else if (char.IsLower(letra) == true)
                    {
                        tieneMinuscula = true;
                    }

                    // char.IsDigit pregunta si la letra es un numero 
                    else if (char.IsDigit(letra) == true)
                    {
                        tieneNumero = true;
                    }
                    else
                    {
                        // Si no es letra ni numero, se asume que es una letra especial
                        tieneEspecial = true;
                    }
                }

                // Evalúa y confirma que se cumplió y que falta 
                Console.WriteLine("---Evaluando intento---");
                int errores = 0;

                // .Length pregunta cuantas letras tiene en este caso la contraseña o un texto 
                if (contra.Length < 8)
                {
                    Console.WriteLine("Falta: Minimo 8 caracteres");
                    errores = errores + 1;
                }
                if (tieneMayuscula == false)
                {
                    Console.WriteLine("Falta: Al menos una mayuscula");
                    errores = errores + 1;
                }
                if (tieneMinuscula == false)
                {
                    Console.WriteLine("Falta: Al menos una minuscula");
                    errores = errores + 1;
                }
                if (tieneNumero == false)
                {
                    Console.WriteLine("Falta: Al menos un numero");
                    errores = errores + 1;
                }
                if (tieneEspecial == false)
                {
                    Console.WriteLine("Falta: Al menos un caracter especial");
                    errores = errores + 1;
                }

                // si no hay errores la contraseña se registra 
                if (errores == 0)
                {
                    Console.WriteLine("Contrasena segura registrada con exito");
                    contraValida = true; 
                }
                else
                {
                    Console.WriteLine("Contrasena rechazada, intente de nuevo");
                    Console.WriteLine("------------------------------------------------");
                }
            }
        }
    }
}