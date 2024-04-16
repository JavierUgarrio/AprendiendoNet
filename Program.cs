namespace IntroduccionNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mensaje = Console.ReadLine();
            int edad= 15;
            bool verdadero;
            int? altura; // con el ? puedes decir que la varible puede ser nula

            int valorDefecto = default(int); // valor 0
            bool valorDefectoBooleano = default(bool); // valor FALSE

            edad = edad + 5;

            if(edad == null)
            {
                //hacer algo
            }

            DateTime? fecha = new DateTime();

            int? dia = fecha?.Day;

            Console.WriteLine(dia);

            Console.WriteLine(edad);

            //inferir en una variable

            var variable = "Hola";

            var variable2 = edad + "hola interfiero";

            var pruebaDeMerge = "okey";

        }
    }
}
