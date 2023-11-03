using PREGUNTA2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PREGUNTA2
{
    internal class Pantallas
    {

        public static string[] estudiante = new string[20];
        public static float[] nota = new float[20];
        public static int contador = 0;

        public static int patallaPrincipal()
        {
            string texto = "================================\n" +
                "Notas de estudiantes\n" +
                "================================\n" +
                "1: Ingresar notas\n" +
                "2: Nota más alta\n" +
                "3: Nota más baja\n" +
                "4: Ver lista de estudiantes\n" +
                "5: Salir\n" +
                "================================\n";
            Console.Write(texto);
            return Operaciones.getEntero("Ingrese una opción:", texto );
        }

        public static int ingresarNota()
        {
            string texto = " " +
                "================================\n" +
                "Ingresar Nota\n" +
                "================================\n"; 
            Console.Write(texto);

            string nombreEstudiante = Operaciones.getTextoPantalla("Ingresar el nombre: ");
            float notaEstudiante = Operaciones.getDecimal("Ingresar la nota: ");

            if(contador == 20)
            {
                Console.WriteLine("Las notas ya estan llenas");
            }
            estudiante[contador] = nombreEstudiante;
            nota[contador] = notaEstudiante;
            contador++;

            string texto2 ="================================\n" +
                "¡Guardado!\n" +
                "================================\n" +
                "1: Agregar uno más    | 2: Volver\n" +
                "================================\n";
            Console.Write(texto2);

            int opcion = Operaciones.getEntero("Ingrese una opción:", texto);
            if (opcion == 2) return 0;
            return opcion;

        }

        public static int notaMasAlta()
        {
            string texto = "================================\r\n" +
                "La nota más alta\r\n" +
                "================================\r\n";
            Console.Write(texto);
            if ( contador == 0)
            {
                Console.Write("No existe nota");
            }
            else
            {
                float mayor = nota[0];
                int posicionMayor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (nota[i] > mayor)
                    {
                        posicionMayor = i;
                    }
                        

                }

                string nombreEstudiante = estudiante[posicionMayor];
                string estudianteAlto = "Estudiante: " + nombreEstudiante + "\n";
                Console.Write(estudianteAlto);
                string notaalta = "Nota: " + mayor + "\n";
                Console.Write(notaalta);
            }

            

       
            string texto2 = "\n================================" +
                "\n1: Regresar";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 0;
        }

        public static int notaMasBaja()
        {
            string texto = "================================\r\n" +
                "La nota más baja\r\n" +
                "================================\r\n";
            Console.Write(texto);
            if (contador == 0)
            {
                Console.Write("No existe nota");
            }
            else
            {
                float menor = nota[0];
                int posicionMenor = 0;
                for (int i = 0; i > contador; i++)
                {
                    if (nota[i] < menor)
                    {
                        posicionMenor = i;
                    }


                }

                string nombreEstudiante = estudiante[posicionMenor];
                string estudianteBajo = "Estudiante: " + nombreEstudiante + "\n";
                Console.Write(estudianteBajo);
                string notabaja = "Nota: " + menor + "\n";
                Console.Write(notabaja);
            }




            string texto2 = "\n================================" +
                "\n1: Regresar";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("\nIngrese una opción: ", texto);
            if (opcion == 1) return 0;
            return 0;
        }

        public static int listadeEstudiantes()
        {
            string texto = "================================\n" +
                 "Lista de estudiantes\n" +
                 "================================\n";
            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No existen Estudiantes");
            }
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(estudiante[i] + "\t\t\t |" + nota[i]);
            }


            string texto2 = "================================\n" +
                "Presione enter para volver\n" +
                "================================\n";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("", texto);
            return opcion;
        }

    }
}



