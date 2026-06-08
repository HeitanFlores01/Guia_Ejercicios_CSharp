namespace EjerciciosCSharp.EstructurasControlCiclos

{
    public class TablaMultiplicarExtendida
    {
        public TablaMultiplicarExtendida(int tabla)
        {
            int limite = 12;

            // usamos el ciclo for para que se repita la tabla hasta llegar al numero
            // limite puesto que en este caso es 12 y se imprime la tabla que desea el usuario
            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine($"{tabla} x {i} = {tabla * i}");
            }
        }
    }
}