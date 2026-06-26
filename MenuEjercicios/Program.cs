using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("===========================================");
            Console.WriteLine("          MENÚ PRINCIPAL");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Cálculos de salario y descuentos");
            Console.WriteLine("2. Cálculos matemáticos");
            Console.WriteLine("3. Conversión de tiempo");
            Console.WriteLine("4. Geometría");
            Console.WriteLine("5. Facturación");
            Console.WriteLine("6. Estadísticas y notas");
            Console.WriteLine("7. Varios");
            Console.WriteLine("0. Salir");
            Console.WriteLine("===========================================");

            Console.Write("Seleccione una opción: ");
            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                opcion = -1;
            }

            Console.Clear();

            switch (opcion)
            {
                case 1:
                    Submenus.MenuSalarios();
                    break;

                case 2:
                    Submenus.MenuMatematicos();
                    break;

                case 3:
                    Submenus.MenuTiempo();
                    break;

                case 4:
                    Submenus.MenuGeometria();
                    break;

                case 5:
                    Submenus.MenuFacturacion();
                    break;

                case 6:
                    Submenus.MenuEstadisticas();
                    break;

                case 7:
                    Submenus.MenuVarios();
                    break;

                case 0:
                    Console.WriteLine("Gracias por usar el programa.");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }
}