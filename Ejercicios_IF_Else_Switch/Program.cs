using System;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();

            Console.WriteLine("===== EJERCICIOS IF / ELSE / SWITCH =====\n");

            Console.WriteLine("1. Número positivo, negativo o cero");
            Console.WriteLine("2. Número par o impar");
            Console.WriteLine("3. Mayor de edad");
            Console.WriteLine("4. Múltiplo de 5");
            Console.WriteLine("5. Descuento por edad");
            Console.WriteLine("6. Calificación aprobatoria");
            Console.WriteLine("7. Día de la semana");
            Console.WriteLine("8. Número mayor entre dos");
            Console.WriteLine("9. Mayor entre tres números");
            Console.WriteLine("10. Clasificación de ángulos");
            Console.WriteLine("11. Cálculo de impuestos");
            Console.WriteLine("12. Clasificación de números");
            Console.WriteLine("13. Verificación de año bisiesto");
            Console.WriteLine("14. Conversión de calificaciones");
            Console.WriteLine("15. Comparación de tres longitudes");
            Console.WriteLine("16. Calculadora de descuentos");
            Console.WriteLine("17. Tipo de triángulo");
            Console.WriteLine("18. Evaluación de temperatura");
            Console.WriteLine("19. Conversión de horas a turnos");
            Console.WriteLine("20. Clasificación de IMC");

            Console.WriteLine("0. Salir\n");

            Console.Write("Selecciona una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1: Ejercicios.Ejercicio1(); break;
                case 2: Ejercicios.Ejercicio2(); break;
                case 3: Ejercicios.Ejercicio3(); break;
                case 4: Ejercicios.Ejercicio4(); break;
                case 5: Ejercicios.Ejercicio5(); break;
                case 6: Ejercicios.Ejercicio6(); break;
                case 7: Ejercicios.Ejercicio7(); break;
                case 8: Ejercicios.Ejercicio8(); break;
                case 9: Ejercicios.Ejercicio9(); break;
                case 10: Ejercicios.Ejercicio10(); break;
                case 11: Ejercicios.Ejercicio11(); break;
                case 12: Ejercicios.Ejercicio12(); break;
                case 13: Ejercicios.Ejercicio13(); break;
                case 14: Ejercicios.Ejercicio14(); break;
                case 15: Ejercicios.Ejercicio15(); break;
                case 16: Ejercicios.Ejercicio16(); break;
                case 17: Ejercicios.Ejercicio17(); break;
                case 18: Ejercicios.Ejercicio18(); break;
                case 19: Ejercicios.Ejercicio19(); break;
                case 20: Ejercicios.Ejercicio20(); break;

                case 0:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }
}