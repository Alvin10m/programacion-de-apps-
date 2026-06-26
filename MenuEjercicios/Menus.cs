using System;

class Submenus
{
    
    // 1. CÁLCULOS DE SALARIO Y DESCUENTOS
    
    public static void MenuSalarios()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("   CÁLCULOS DE SALARIO Y DESCUENTOS");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Ejercicio 01 - Salario con horas extra");
            Console.WriteLine("2. Ejercicio 02 - Descuento por tramos de sueldo");
            Console.WriteLine("3. Ejercicio 03 - Descuento por monto");
            Console.WriteLine("4. Ejercicio 07 - Suma de salarios de trabajadores");
            Console.WriteLine("5. Ejercicio 08 - Salario básico");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) opcion = -1;
            Console.Clear();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio01(); break;
                case 2: Ejercicios.Ejercicio02(); break;
                case 3: Ejercicios.Ejercicio03(); break;
                case 4: Ejercicios.Ejercicio07(); break;
                case 5: Ejercicios.Ejercicio08(); break;
                case 0: break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

    
    // 2. CÁLCULOS MATEMÁTICOS
   
    public static void MenuMatematicos()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("         CÁLCULOS MATEMÁTICOS");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Ejercicio 06 - Suma de N primeros naturales");
            Console.WriteLine("2. Ejercicio 10 - Suma de dígitos de un número");
            Console.WriteLine("3. Ejercicio 13 - Factorial de un número");
            Console.WriteLine("4. Ejercicio 14 - Media de 100 números");
            Console.WriteLine("5. Ejercicio 15 - Suma y producto de pares (20-400)");
            Console.WriteLine("6. Ejercicio 28 - Suma de enteros desde 8 hasta N");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) opcion = -1;
            Console.Clear();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio06(); break;
                case 2: Ejercicios.Ejercicio10(); break;
                case 3: Ejercicios.Ejercicio13(); break;
                case 4: Ejercicios.Ejercicio14(); break;
                case 5: Ejercicios.Ejercicio15(); break;
                case 6: Ejercicios.Ejercicio28(); break;
                case 0: break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }


    // 3. CONVERSIÓN DE TIEMPO
   
    public static void MenuTiempo()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("          CONVERSIÓN DE TIEMPO");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Ejercicio 04 - Segundos restantes para minuto completo");
            Console.WriteLine("2. Ejercicio 05 - Minutos a días, horas y minutos");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) opcion = -1;
            Console.Clear();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio04(); break;
                case 2: Ejercicios.Ejercicio05(); break;
                case 0: break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

 
    // 4. GEOMETRÍA
    
    public static void MenuGeometria()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("              GEOMETRÍA");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Ejercicio 24 - Área de un triángulo (Herón)");
            Console.WriteLine("2. Ejercicio 25 - Hipotenusa (Pitágoras)");
            Console.WriteLine("3. Ejercicio 26 - Circunferencia, área y volumen de esfera");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) opcion = -1;
            Console.Clear();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio24(); break;
                case 2: Ejercicios.Ejercicio25(); break;
                case 3: Ejercicios.Ejercicio26(); break;
                case 0: break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

    
    // 5. FACTURACIÓN
   
    public static void MenuFacturacion()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("             FACTURACIÓN");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Ejercicio 11 - Factura con IVA y descuento");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) opcion = -1;
            Console.Clear();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio11(); break;
                case 0: break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

    
    // 6. ESTADÍSTICAS Y NOTAS
   
    public static void MenuEstadisticas()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("         ESTADÍSTICAS Y NOTAS");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Ejercicio 09 - Promedios y conteo de notas");
            Console.WriteLine("2. Ejercicio 12 - Conteo de pares, impares, positivos y negativos");
            Console.WriteLine("3. Ejercicio 30 - Promedio de dos notas (aprobado/desaprobado)");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) opcion = -1;
            Console.Clear();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio09(); break;
                case 2: Ejercicios.Ejercicio12(); break;
                case 3: Ejercicios.Ejercicio30(); break;
                case 0: break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }

    
    // 7. VARIOS
    
    public static void MenuVarios()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("                VARIOS");
            Console.WriteLine("===========================================");
            Console.WriteLine("1. Ejercicio 18 - Primera vocal ingresada");
            Console.WriteLine("2. Ejercicio 19 - Detectar parte fraccionaria");
            Console.WriteLine("3. Ejercicio 21 - Operaciones básicas (10 procesos)");
            Console.WriteLine("4. Ejercicio 22 - Cubo y raíz cuadrada (hasta ingresar 0)");
            Console.WriteLine("5. Ejercicio 23 - Operaciones básicas (hasta ingresar 0)");
            Console.WriteLine("6. Ejercicio 29 - Egresos de caja Barner");
            Console.WriteLine("7. Ejercicio 31 - Verificación de clave de acceso");
            Console.WriteLine("0. Volver al menú principal");
            Console.WriteLine("===========================================");
            Console.Write("Seleccione una opción: ");

            string? entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcion)) opcion = -1;
            Console.Clear();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio18(); break;
                case 2: Ejercicios.Ejercicio19(); break;
                case 3: Ejercicios.Ejercicio21(); break;
                case 4: Ejercicios.Ejercicio22(); break;
                case 5: Ejercicios.Ejercicio23(); break;
                case 6: Ejercicios.Ejercicio29(); break;
                case 7: Ejercicios.Ejercicio31(); break;
                case 0: break;
                default: Console.WriteLine("Opción no válida."); break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        } while (opcion != 0);
    }
}