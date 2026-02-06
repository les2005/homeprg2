/**************************************************
 * Proyecto: Comunidad
 * Autor: Leslie Rojas
 * Matrícula: 2025-0942
 * Descripción: Programa principal para gestionar una comunidad educativa.
 **************************************************/

using Comunidadv2.Entyties;

namespace Comunidadv2
{
    class Program
    {
        public static void Main()
        {
            Estudiante estudiante1 = new Estudiante(
                1,
                "Leslie Rojas",
                19,
                "leslie.rojas@email.com",
                "15/08/2023",
                "Ingeniería en Sistemas",
                "20/07/2006",
                "8095551234",
                "Av. Principal #45"
            );

            Console.WriteLine("Información del Estudiante:");
            estudiante1.MostrarInfo();
            Console.WriteLine();

            ExAlumno exAlumno = new ExAlumno(
                2,
                "Leslie Rojas",
                23,
                "leslie.rojas@email.com",
                "10/06/2021",
                "Técnico en Informática",
                "20/07/2002",
                "8095555678",
                "Calle Los Estudiantes #12"
            );

            Console.WriteLine("Información del ExAlumno:");
            exAlumno.MostrarInfo();
            Console.WriteLine();

            Maestro maestro1 = new Maestro();
            maestro1.Id = 3;
            maestro1.Nombre = "Pedro Ramírez";
            maestro1.Edad = 48;
            maestro1.Email = "pedro.ramirez@escuela.edu";
            maestro1.Telefono = "8094443322";
            maestro1.Direccion = "Calle Educación #78";
            maestro1.Materia = "Matemáticas";
            maestro1.AñosExperiencia = 22;

            Console.WriteLine("Información del Maestro:");
            maestro1.MostrarInfo();
            Console.WriteLine();

            Empleado empleado1 = new Empleado();
            empleado1.Id = 4;
            empleado1.Nombre = "Laura Fernández";
            empleado1.Edad = 32;
            empleado1.Email = "laura.fernandez@institucion.edu";
            empleado1.Telefono = "8096667788";
            empleado1.Direccion = "Residencial Central #34";
            empleado1.Puesto = "Contadora";
            empleado1.Salario = 3500.00m;

            Console.WriteLine("Información del Empleado:");
            empleado1.MostrarInfo();
            Console.WriteLine();

            Docente docente1 = new Docente();
            docente1.Id = 5;
            docente1.Nombre = "Ana Morales";
            docente1.Edad = 37;
            docente1.Email = "ana.morales@colegio.edu";
            docente1.Telefono = "8092223344";
            docente1.Direccion = "Calle Ciencias #90";
            docente1.Asignatura = "Ciencias Naturales";
            docente1.Salario = 2800.75m;

            Console.WriteLine("Información del Docente:");
            docente1.MostrarInfo();
            Console.WriteLine();

            Administrativo administrativo1 = new Administrativo();
            administrativo1.Id = 6;
            administrativo1.Nombre = "José Castillo";
            administrativo1.Edad = 42;
            administrativo1.Email = "jose.castillo@institucion.edu";
            administrativo1.Telefono = "8091112233";
            administrativo1.Direccion = "Calle Oficina #10";
            administrativo1.Puesto = "Asistente Administrativo";
            administrativo1.Departamento = "Registro Académico";
            administrativo1.Salario = 3000.00m;

            Console.WriteLine("Información del Administrativo:");
            administrativo1.MostrarInfo();
            Console.WriteLine();

            Administrador administrador = new Administrador();
            administrador.Id = 7;
            administrador.Nombre = "Carlos Méndez";
            administrador.Edad = 52;
            administrador.Email = "carlos.mendez@institucion.edu";
            administrador.Telefono = "8099998888";
            administrador.Direccion = "Av. Dirección General #1";
            administrador.Puesto = "Director General";
            administrador.Salario = 5500.00m;

            Console.WriteLine("Información del Administrador:");
            administrador.MostrarInfo();

            Console.ReadKey();
        }
    }
}
