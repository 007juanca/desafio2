namespace desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            int suma = calculadora.Sumar(23, 34);
            int resta = calculadora.Restar(23, 34);
            int multiplicacion = calculadora.Multiplicar(4, 2, 4);
            int division = calculadora.Dividir(36, 6);

            Console.WriteLine("El resultado de la suma es: " + suma);
            Console.WriteLine("El resultado de resta es: " + resta);
            Console.WriteLine("resultado de la multiplicación: " + multiplicacion);
            Console.WriteLine("EL resultado de división es: " + division);
            Console.Read();
        }
    }
}