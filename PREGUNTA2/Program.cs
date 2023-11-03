using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PREGUNTA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.patallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Pantallas.ingresarNota();
                        break;
                    case 2:
                        opcion = Pantallas.notaMasAlta();
                        break;
                    case 3:
                        opcion = Pantallas.notaMasBaja();
                        break;
                    case 4:
                        opcion = Pantallas.listadeEstudiantes();
                        break;
                    case 0:
                    default:
                        opcion = Pantallas.patallaPrincipal();
                        break;
                }
            } while (opcion != 5);
        }
    }
}
