using System;

class Ejercicios
{
    public static void Ejercicio1()
    {
        Console.WriteLine("1. Número positivo, negativo o cero");
        Console.Write("Ingresa un número entero: ");

        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("Resultado: Positivo");
        else if (n < 0)
            Console.WriteLine("Resultado: Negativo");
        else
            Console.WriteLine("Resultado: Cero");
    }

    public static void Ejercicio2()
    {
        Console.WriteLine("2. Número par o impar");
        Console.Write("Ingresa un número entero: ");

        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0)
            Console.WriteLine("Resultado: Par");
        else
            Console.WriteLine("Resultado: Impar");
    }

    public static void Ejercicio3()
    {
        Console.WriteLine("3. Mayor de edad");
        Console.Write("Ingresa tu edad: ");

        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
            Console.WriteLine("Resultado: Mayor de edad");
        else
            Console.WriteLine("Resultado: Menor de edad");
    }

    public static void Ejercicio4()
    {
        Console.WriteLine("4. Múltiplo de 5");
        Console.Write("Ingresa un número: ");

        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 5 == 0)
            Console.WriteLine("Resultado: Es múltiplo de 5");
        else
            Console.WriteLine("Resultado: No es múltiplo de 5");
    }

    public static void Ejercicio5()
    {
        Console.WriteLine("5. Descuento por edad");
        Console.Write("Ingresa tu edad: ");

        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad > 60)
            Console.WriteLine("Resultado: Aplica 50% de descuento");
        else
            Console.WriteLine("Resultado: No aplica descuento");
    }

    public static void Ejercicio6()
    {
        Console.WriteLine("6. Calificación aprobatoria");
        Console.Write("Ingresa la calificación (0-100): ");

        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 60)
            Console.WriteLine("Resultado: Aprobado");
        else
            Console.WriteLine("Resultado: Reprobado");
    }

    public static void Ejercicio7()
    {
        Console.WriteLine("7. Día de la semana");
        Console.Write("Ingresa un número del 1 al 7: ");

        int d = Convert.ToInt32(Console.ReadLine());

        switch (d)
        {
            case 1: Console.WriteLine("Resultado: Lunes"); break;
            case 2: Console.WriteLine("Resultado: Martes"); break;
            case 3: Console.WriteLine("Resultado: Miércoles"); break;
            case 4: Console.WriteLine("Resultado: Jueves"); break;
            case 5: Console.WriteLine("Resultado: Viernes"); break;
            case 6: Console.WriteLine("Resultado: Sábado"); break;
            case 7: Console.WriteLine("Resultado: Domingo"); break;
            default: Console.WriteLine("Resultado: Número inválido"); break;
        }
    }

    public static void Ejercicio8()
    {
        Console.WriteLine("8. Número mayor entre dos");
        Console.Write("Ingresa el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
            Console.WriteLine("Resultado: Mayor = " + a);
        else if (b > a)
            Console.WriteLine("Resultado: Mayor = " + b);
        else
            Console.WriteLine("Resultado: Son iguales");
    }

    public static void Ejercicio9()
    {
        Console.WriteLine("9. Mayor entre tres números");

        Console.Write("Ingresa el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int mayor = a;

        if (b > mayor) mayor = b;
        if (c > mayor) mayor = c;

        Console.WriteLine("Resultado: Mayor = " + mayor);
    }

    public static void Ejercicio10()
    {
        Console.WriteLine("10. Clasificación de ángulos");
        Console.Write("Ingresa el ángulo en grados: ");

        int a = Convert.ToInt32(Console.ReadLine());

        if (a < 90)
            Console.WriteLine("Resultado: Ángulo agudo");
        else if (a == 90)
            Console.WriteLine("Resultado: Ángulo recto");
        else if (a < 180)
            Console.WriteLine("Resultado: Ángulo obtuso");
        else
            Console.WriteLine("Resultado: Ángulo llano o inválido");
    }

    public static void Ejercicio11()
    {
        Console.WriteLine("11. Cálculo de impuestos");
        Console.Write("Ingresa tu salario mensual: ");

        double s = Convert.ToDouble(Console.ReadLine());

        if (s < 10000)
            Console.WriteLine("Resultado: 0% impuesto");
        else if (s <= 30000)
            Console.WriteLine("Resultado: 10% impuesto");
        else
            Console.WriteLine("Resultado: 20% impuesto");
    }

    public static void Ejercicio12()
    {
        Console.WriteLine("12. Clasificación de números");

        Console.Write("Ingresa el primer número: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el tercer número: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
            Console.WriteLine("Resultado: Todos positivos");
        else if (a < 0 && b < 0 && c < 0)
            Console.WriteLine("Resultado: Todos negativos");
        else if (a == 0 || b == 0 || c == 0)
            Console.WriteLine("Resultado: Hay ceros");
        else
            Console.WriteLine("Resultado: Mixtos");
    }

    public static void Ejercicio13()
    {
        Console.WriteLine("13. Año bisiesto");
        Console.Write("Ingresa un año: ");

        int y = Convert.ToInt32(Console.ReadLine());

        if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            Console.WriteLine("Resultado: Bisiesto");
        else
            Console.WriteLine("Resultado: No bisiesto");
    }

    public static void Ejercicio14()
    {
        Console.WriteLine("14. Conversión de calificaciones");
        Console.Write("Ingresa la calificación (0-100): ");

        int n = Convert.ToInt32(Console.ReadLine());

        if (n >= 90) Console.WriteLine("Resultado: A");
        else if (n >= 80) Console.WriteLine("Resultado: B");
        else if (n >= 70) Console.WriteLine("Resultado: C");
        else if (n >= 60) Console.WriteLine("Resultado: D");
        else Console.WriteLine("Resultado: F");
    }

    public static void Ejercicio15()
    {
        Console.WriteLine("15. Comparación de tres longitudes");

        Console.Write("Ingresa la primera longitud: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa la segunda longitud: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa la tercera longitud: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Resultado: Sí forman triángulo");
        else
            Console.WriteLine("Resultado: No forman triángulo");
    }

    public static void Ejercicio16()
    {
        Console.WriteLine("16. Calculadora de descuentos");
        Console.Write("Ingresa el precio del producto: ");

        double p = Convert.ToDouble(Console.ReadLine());

        if (p < 50)
            Console.WriteLine("Resultado: Sin descuento");
        else if (p <= 100)
            Console.WriteLine("Resultado: 5% descuento");
        else
            Console.WriteLine("Resultado: 10% descuento");
    }

    public static void Ejercicio17()
    {
        Console.WriteLine("17. Tipo de triángulo");

        Console.Write("Ingresa lado 1: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa lado 2: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa lado 3: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Resultado: Equilátero");
        else if (a == b || a == c || b == c)
            Console.WriteLine("Resultado: Isósceles");
        else
            Console.WriteLine("Resultado: Escaleno");
    }

    public static void Ejercicio18()
    {
        Console.WriteLine("18. Evaluación de temperatura");
        Console.Write("Ingresa la temperatura en °C: ");

        int t = Convert.ToInt32(Console.ReadLine());

        if (t < 0)
            Console.WriteLine("Resultado: Hace mucho frío");
        else if (t <= 20)
            Console.WriteLine("Resultado: Clima fresco");
        else if (t <= 30)
            Console.WriteLine("Resultado: Clima agradable");
        else
            Console.WriteLine("Resultado: Hace mucho calor");
    }

    public static void Ejercicio19()
    {
        Console.WriteLine("19. Conversión de horas a turnos");
        Console.Write("Ingresa la hora (0-23): ");

        int h = Convert.ToInt32(Console.ReadLine());

        if (h >= 6 && h <= 11)
            Console.WriteLine("Resultado: Mañana");
        else if (h <= 17)
            Console.WriteLine("Resultado: Tarde");
        else if (h <= 23)
            Console.WriteLine("Resultado: Noche");
        else
            Console.WriteLine("Resultado: Madrugada");
    }

    public static void Ejercicio20()
    {
        Console.WriteLine("20. Clasificación de IMC");

        Console.Write("Ingresa tu peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa tu altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        if (imc < 18.5)
            Console.WriteLine("Resultado: Bajo peso");
        else if (imc < 25)
            Console.WriteLine("Resultado: Normal");
        else if (imc < 30)
            Console.WriteLine("Resultado: Sobrepeso");
        else
            Console.WriteLine("Resultado: Obesidad");
    }
}