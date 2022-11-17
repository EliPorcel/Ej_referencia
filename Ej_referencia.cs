using System;

namespace función_referencia
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Clear();

            int a = 5;
            int b = 3;
            
            //muestro valores iniciales
            Console.WriteLine("Valores iniciales: a = {0}, b = {1}", a, b);
            
            //Invoco la función
            Cambiar(ref a, ref b);

            //muestro valor después de la función
            Console.WriteLine("Valores después de la función: a = {0}, b = {1}", a, b);

            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
        }
        static void Cambiar (ref int x, ref int y)
        {
            x = 101;
            y = 213;
        }
    }
}