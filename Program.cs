using System;

// Definición de la estructura Estudiante
struct Estudiante
{
    public string nombre;
    public double nota;
}

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario la cantidad de estudiantes
        int cantidadEstudiantes = 0;
        bool cantidadValida = false;
        while (!cantidadValida)
        {
            Console.Write("Ingrese la cantidad de estudiantes: ");
            string inputCantidad = Console.ReadLine();
            if (int.TryParse(inputCantidad, out cantidadEstudiantes) && cantidadEstudiantes > 0)
            {
                cantidadValida = true;
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor numérico válido mayor que cero.");
            }
        }

        // Declarar un arreglo de estudiantes
        Estudiante[] estudiantes = new Estudiante[cantidadEstudiantes];

        // Variables para contar los alumnos aprobados y no aprobados, y el total de notas
        int aprobados = 0;
        int noAprobados = 0;
        double totalNotas = 0;

        // Solicitar los datos de cada estudiante
        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            
            double nota = 0;
            bool notaValida = false;
            while (!notaValida)
            {
                Console.Write("Nota: ");
                string inputNota = Console.ReadLine();
                if (double.TryParse(inputNota, out nota) && nota >= 0 && nota <= 20)
                {
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico válido entre 0 y 20.");
                }
            }

            // Guardar los datos en el arreglo de estudiantes
            estudiantes[i].nombre = nombre;
            estudiantes[i].nota = nota;

            // Contar aprobados y no aprobados
            if (nota >= 12)
            {
                aprobados++;
            }
            else
            {
                noAprobados++;
            }

            // Sumar la nota al total
            totalNotas += nota;
        }

        // Calcular el promedio de notas
        double promedioNotas = totalNotas / cantidadEstudiantes;

        // Mostrar la información
        Console.WriteLine($"\nNúmero de alumnos aprobados: {aprobados}");
        Console.WriteLine($"Número de alumnos no aprobados: {noAprobados}");
        Console.WriteLine($"Promedio de notas de la sección: {promedioNotas}");

        Console.ReadLine();
    }
}
