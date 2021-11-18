using System;

namespace PracticaArrays02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombreEstudiantes;

            Console.WriteLine("Cuantos estudiantes hay?");
            int estudiantes = int.Parse(Console.ReadLine());

            nombreEstudiantes = new string[estudiantes];


            for (int i = 0; i < estudiantes; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                nombreEstudiantes[i] = Console.ReadLine();
            }

            for(int j = 0; j < estudiantes; j++)
            {
                Console.WriteLine(nombreEstudiantes[j]);
            }
        }
    }
}
