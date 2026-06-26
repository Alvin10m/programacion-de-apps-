using System;

class Ejercicios
{
    
    // CATEGORÍA 1: CÁLCULOS DE SALARIO Y DESCUENTOS
   

    // Ejercicio 01 - Salario con horas extra (tarifa +50% si >40 h)
    public static void Ejercicio01()
    {
        Console.WriteLine("── Ejercicio 01: Salario con horas extra ──");
        double tarifa, horasTrabajadas, horasExtra, salario, tarifaExtra;

        Console.WriteLine("Ingrese horas trabajadas");
        horasTrabajadas = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingrese tarifa");
        tarifa = double.Parse(Console.ReadLine()!);

        if (horasTrabajadas <= 40 && horasTrabajadas >= 0)
        {
            salario = horasTrabajadas * tarifa;
            Console.WriteLine("El salario es: " + salario);
        }
        else if (horasTrabajadas > 40)
        {
            horasExtra   = horasTrabajadas - 40;
            tarifaExtra  = tarifa + 0.5 * tarifa;
            salario      = horasExtra * tarifaExtra + 40 * tarifa;
            Console.WriteLine("El salario es: " + salario);
        }
        else
        {
            Console.WriteLine("Las horas trabajadas no pueden ser negativas");
        }
    }

    // Ejercicio 02 - Descuento escalonado sobre el sueldo
    public static void Ejercicio02()
    {
        Console.WriteLine("── Ejercicio 02: Descuento por tramos de sueldo ──");
        double sueldo, sueldoneto, descuento;

        Console.WriteLine("Ingrese el sueldo");
        sueldo = double.Parse(Console.ReadLine()!);

        if (sueldo <= 1000 && sueldo >= 0)
        {
            descuento  = sueldo * 0.1;
            sueldoneto = sueldo - descuento;
            Console.WriteLine("El descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else if (sueldo <= 2000 && sueldo >= 0)
        {
            descuento  = (sueldo - 1000) * 0.05 + (1000 * 0.1);
            sueldoneto = sueldo - descuento;
            Console.WriteLine("El descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else if (sueldo > 2000)
        {
            descuento  = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
            sueldoneto = sueldo - descuento;
            Console.WriteLine("El descuento es: {0} y el sueldo neto es: {1}", descuento, sueldoneto);
        }
        else
        {
            Console.WriteLine("Error: el sueldo no puede ser negativo");
        }
    }

    // Ejercicio 03 - Descuento según si el monto supera 100
    public static void Ejercicio03()
    {
        Console.WriteLine("── Ejercicio 03: Descuento por monto ──");
        double monto, descuento;

        Console.WriteLine("Ingrese monto");
        monto = double.Parse(Console.ReadLine()!);

        if (monto > 100)
        {
            descuento = monto * 0.1;
            Console.WriteLine("El monto {0} tiene un descuento del {1}", monto, descuento);
        }
        else if (monto <= 100 && monto > 0)
        {
            descuento = monto * 0.2;
            Console.WriteLine("El monto {0} tiene un descuento del {1}", monto, descuento);
        }
        else
        {
            Console.WriteLine("Error: el monto no puede ser negativo");
        }
    }

    // Ejercicio 07 - Suma de salarios de N trabajadores
    public static void Ejercicio07()
    {
        Console.WriteLine("── Ejercicio 07: Suma de salarios de todos los trabajadores ──");
        double x, salario, horasTrabajadas, tarifa, suma, numeroTrabajadores;
        suma = 0;

        Console.Write("Ingrese la cantidad de trabajadores: ");
        numeroTrabajadores = double.Parse(Console.ReadLine()!);

        for (x = 1; x <= numeroTrabajadores; x = x + 1)
        {
            Console.WriteLine(" Trabajador {0}: ", x);
            Console.Write(" Horas trabajadas : ");
            horasTrabajadas = double.Parse(Console.ReadLine()!);
            Console.Write(" Tarifa : ");
            tarifa  = double.Parse(Console.ReadLine()!);
            Console.WriteLine();
            salario = horasTrabajadas * tarifa;
            suma    = suma + salario;
        }
        Console.WriteLine("La suma de los salarios es : {0}", suma);
    }

    // Ejercicio 08 - Salario básico (horas × tarifa)
    public static void Ejercicio08()
    {
        Console.WriteLine("── Ejercicio 08: Salario básico ──");
        double horasTrabajadas, tarifa, salario;

        Console.Write("Ingrese horas trabajadas: ");
        horasTrabajadas = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese tarifa: ");
        tarifa  = double.Parse(Console.ReadLine()!);
        salario = horasTrabajadas * tarifa;
        Console.WriteLine("El salario del trabajador es: " + salario);
    }

   
    // CATEGORÍA 2: CÁLCULOS MATEMÁTICOS
   

    // Ejercicio 06 - Suma de los N primeros números naturales
    public static void Ejercicio06()
    {
        Console.WriteLine("── Ejercicio 06: Suma de N primeros números naturales ──");
        int x, numero, suma;

        Console.Write("Ingrese el número N : ");
        numero = int.Parse(Console.ReadLine()!);
        suma   = 0;

        for (x = 1; x <= numero; x = x + 1)
        {
            suma = suma + x;
            Console.WriteLine("n{0}: {1}", x, x);
        }
        Console.WriteLine();
        Console.WriteLine("La suma de la serie es: {0}", suma);
    }

    // Ejercicio 10 - Suma de los dígitos de un número
    public static void Ejercicio10()
    {
        Console.WriteLine("── Ejercicio 10: Suma de dígitos de un número ──");
        int numero, suma, residuo;
        suma = 0;

        Console.WriteLine("Ingresar un numero");
        numero = int.Parse(Console.ReadLine()!);

        do
        {
            residuo = numero % 10;
            suma    = suma + residuo;
            numero  = (numero - (numero % 10)) / 10;
        }
        while (numero != 0);

        Console.WriteLine();
        Console.WriteLine("La suma es de los dígitos es: {0} ", suma);
    }

    // Ejercicio 13 - Factorial de un número
    public static void Ejercicio13()
    {
        Console.WriteLine("── Ejercicio 13: Factorial de un número ──");
        int numero, factorial, i;

        Console.Write("Ingresar numero: ");
        numero    = int.Parse(Console.ReadLine()!);
        factorial = 1;

        for (i = 1; i <= numero; i++)
            factorial = factorial * i;

        Console.WriteLine();
        Console.WriteLine("Factorial: ");
        Console.WriteLine(" {0}! = {1} ", numero, factorial);
    }

    // Ejercicio 14 - Media de 100 números
    public static void Ejercicio14()
    {
        Console.WriteLine("── Ejercicio 14: Media de 100 números ──");
        double suma, media, numero;
        suma = 0;

        for (int x = 1; x <= 100; x = x + 1)
        {
            Console.Write("Ingrese {0}° numero: ", x);
            numero = double.Parse(Console.ReadLine()!);
            suma   = suma + numero;
        }

        media = Math.Round(suma / 100, 2);
        Console.WriteLine();
        Console.WriteLine("La media de los 100 números ingresados es: " + media);
    }

    // Ejercicio 15 - Suma y producto de números pares entre 20 y 400
    public static void Ejercicio15()
    {
        Console.WriteLine("── Ejercicio 15: Suma y producto de pares (20-400) ──");
        long suma     = 0;
        long producto = 1;

        for (int x = 20; x <= 400; x = x + 2)
        {
            suma     = suma + x;
            producto = producto * x;
        }

        Console.WriteLine("Rango: números pares del 20 al 400");
        Console.WriteLine();
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("El producto es: " + producto);
    }

    // Ejercicio 28 - Suma de enteros desde 8 hasta N
    public static void Ejercicio28()
    {
        Console.WriteLine("── Ejercicio 28: Suma de enteros desde 8 hasta N ──");
        int numero, suma, x;
        suma = 0;

        Console.Write("Ingrese el número N (debe ser >= 8): ");
        numero = int.Parse(Console.ReadLine()!);

        if (numero < 8)
        {
            Console.WriteLine();
            Console.WriteLine("Error: el número ingresado es menor a 8");
        }
        else
        {
            for (x = 8; x <= numero; x = x + 1)
                suma = suma + x;

            Console.WriteLine();
            Console.WriteLine("La suma de la serie de rango 8 hasta {0}, con un incremento de 1 es: {1}", numero, suma);
        }
    }

    
    // CATEGORÍA 3: CONVERSIÓN DE TIEMPO
   

    // Ejercicio 04 - Segundos restantes para completar un minuto
    public static void Ejercicio04()
    {
        Console.WriteLine("── Ejercicio 04: Segundos para completar minuto ──");
        int tiempoSegundos, minutos, segundosRestantes;

        Console.WriteLine("Ingrese el tiempo en segundos");
        tiempoSegundos = int.Parse(Console.ReadLine()!);

        if (tiempoSegundos < 60 && tiempoSegundos > 0)
        {
            segundosRestantes = 60 - tiempoSegundos;
            Console.WriteLine("Le falta {0} segundos para convertirse en minuto", segundosRestantes);
        }
        else if (tiempoSegundos >= 60)
        {
            minutos           = (tiempoSegundos - (tiempoSegundos % 60)) / 60;
            segundosRestantes = tiempoSegundos % 60;
            Console.WriteLine("Equivale a {0} minutos y le faltan {1} segundos para convertirse en minuto", minutos, segundosRestantes);
        }
        else
        {
            Console.WriteLine("La cantidad de segundos debe ser un número positivo");
        }
    }

    // Ejercicio 05 - Minutos a días, horas y minutos
    public static void Ejercicio05()
    {
        Console.WriteLine("── Ejercicio 05: Minutos → días, horas y minutos ──");
        int tiempo, dias, horas, minutos, x;

        Console.WriteLine("Ingrese un tiempo en minutos");
        tiempo = int.Parse(Console.ReadLine()!);

        if (tiempo >= 0)
        {
            dias    = (tiempo - (tiempo % 60)) / 1440;
            x       = tiempo % 1440;
            horas   = (x - (x % 60)) / 60;
            minutos = x % 60;
            Console.WriteLine("Equivale a {0} días con {1} horas y {2} minutos", dias, horas, minutos);
        }
        else
        {
            Console.WriteLine("El tiempo no puede ser negativo");
        }
    }

  
    // CATEGORÍA 4: GEOMETRÍA
   

    // Ejercicio 24 - Área de un triángulo cualquiera (fórmula de Herón)
    public static void Ejercicio24()
    {
        Console.WriteLine("── Ejercicio 24: Área de un triángulo (Herón) ──");
        double ladoA, ladoB, ladoC, sm, areaTriangulo;

        Console.Write("Ingrese lado A: ");
        ladoA = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese lado B: ");
        ladoB = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese lado C: ");
        ladoC = double.Parse(Console.ReadLine()!);

        sm             = (ladoA + ladoB + ladoC) / 2;
        areaTriangulo  = Math.Round(Math.Pow(sm * (sm - ladoA) * sm * (sm - ladoB) * sm * (sm - ladoC), 0.5), 2);
        Console.WriteLine("El área del triángulo es: " + areaTriangulo);
    }

    // Ejercicio 25 - Hipotenusa con el Teorema de Pitágoras
    public static void Ejercicio25()
    {
        Console.WriteLine("── Ejercicio 25: Hipotenusa (Pitágoras) ──");
        double catetoA, catetoB, hipotenusa;

        Console.Write("Ingrese primer cateto: ");
        catetoA    = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese segundo cateto: ");
        catetoB    = double.Parse(Console.ReadLine()!);
        hipotenusa = Math.Round(Math.Pow(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2), 0.5), 2);
        Console.WriteLine();
        Console.WriteLine("La hipotenusa es: {0}", hipotenusa);
    }

    // Ejercicio 26 - Longitud, área y volumen de la esfera para un radio dado
    public static void Ejercicio26()
    {
        Console.WriteLine("── Ejercicio 26: Circunferencia, área y volumen de esfera ──");
        double pi = 3.14;
        double radio, area, volumen, longitud;

        Console.Write("Ingrese el radio de la circunferencia: ");
        radio    = int.Parse(Console.ReadLine()!);
        longitud = 2 * pi * radio;
        area     = Math.Round(pi * Math.Pow(radio, 2), 2);
        volumen  = Math.Round((4.0 / 3) * pi * Math.Pow(radio, 3), 2);
        Console.WriteLine();
        Console.WriteLine("Longitud de la circunferencia: " + longitud);
        Console.WriteLine("Área de la circunferencia: "     + area);
        Console.WriteLine("Volumen de la esfera: "          + volumen);
    }

  
    // CATEGORÍA 5: FACTURACIÓN


    // Ejercicio 11 - Factura con IVA 15% y descuento si precio bruto >= 50
    public static void Ejercicio11()
    {
        Console.WriteLine("── Ejercicio 11: Factura con IVA y descuento ──");
        double precio, numeroArticulos, precioVenta, descuento, precioBruto, iva, totalPagar;

        Console.Write("Ingrese el precio: ");
        precio          = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese número de artículos: ");
        numeroArticulos = double.Parse(Console.ReadLine()!);

        precioVenta = precio * numeroArticulos;
        iva         = Math.Round(precioVenta * 0.15, 2);
        precioBruto = precioVenta + iva;

        if (precioBruto >= 50)
            descuento = Math.Round((precioBruto * 5) / 100, 2);
        else
            descuento = 0;

        totalPagar = precioBruto - descuento;

        Console.WriteLine(" ");
        Console.WriteLine(" Datos de la factura ");
        Console.WriteLine(" ");
        Console.WriteLine(" Precio de venta : "                          + precioVenta);
        Console.WriteLine(" Impuesto sobre el valor añadido (IVA) es: "  + iva);
        Console.WriteLine(" Precio bruto es : "                          + precioBruto);
        Console.WriteLine(" Descuento es : "                             + descuento);
        Console.WriteLine(" Total a pagar: "                             + totalPagar);
    }

   
    // CATEGORÍA 6: ESTADÍSTICAS Y NOTAS
    

    // Ejercicio 09 - Conteo de aprobados/desaprobados y promedios
    public static void Ejercicio09()
    {
        Console.WriteLine("── Ejercicio 09: Promedios y conteo de notas ──");
        double nota;
        int    aprobados = 0, desaprobados = 0;
        double sumaAprobados = 0, sumaDesaprobados = 0, sumaTotal = 0;
        int    total = 0;
        string respuesta;

        do
        {
            Console.Write("Introduce la nota: ");
            nota = double.Parse(Console.ReadLine()!);
            total++;
            sumaTotal += nota;

            if (nota >= 10.5)
            {
                aprobados++;
                sumaAprobados += nota;
            }
            else
            {
                desaprobados++;
                sumaDesaprobados += nota;
            }

            Console.Write("¿Deseas ingresar otra nota?: ");
            respuesta = Console.ReadLine()!.ToLower();
        }
        while (respuesta == "si");

        Console.WriteLine();
        Console.WriteLine("La cantidad de notas desaprobadas es: " + desaprobados);
        Console.WriteLine("La cantidad de notas aprobadas es: "    + aprobados);

        if (aprobados > 0)
            Console.WriteLine("El promedio de las notas aprobadas es: "    + Math.Round(sumaAprobados    / aprobados,    1));
        if (desaprobados > 0)
            Console.WriteLine("El promedio de las notas desaprobadas es: " + Math.Round(sumaDesaprobados / desaprobados, 1));

        Console.WriteLine("El promedio final es: " + Math.Round(sumaTotal / total, 1));
    }

    // Ejercicio 12 - Conteo de pares, impares, positivos y negativos entre 50 números
    public static void Ejercicio12()
    {
        Console.WriteLine("── Ejercicio 12: Conteo de pares, impares, positivos y negativos ──");
        int numero;
        int pares = 0, impares = 0, positivos = 0, negativos = 0;

        for (int i = 1; i <= 50; i++)
        {
            Console.Write("Ingrese {0}° número: ", i);
            numero = int.Parse(Console.ReadLine()!);

            if (numero % 2 == 0) pares++;    else impares++;
            if (numero > 0)      positivos++; else if (numero < 0) negativos++;
        }

        Console.WriteLine();
        Console.WriteLine("La cantidad de números pares es: "     + pares);
        Console.WriteLine("La cantidad de números impares es: "   + impares);
        Console.WriteLine("La cantidad de números negativos es: " + negativos);
        Console.WriteLine("La cantidad de números positivos es: " + positivos);
    }

    // Ejercicio 30 - Promedio de dos notas con indicación aprobado/desaprobado
    public static void Ejercicio30()
    {
        Console.WriteLine("── Ejercicio 30: Promedio de dos notas ──");
        double nota1, nota2, promedio;

        Console.Write("Ingrese primera nota: ");
        nota1 = double.Parse(Console.ReadLine()!);
        Console.Write("Ingrese segunda nota: ");
        nota2 = double.Parse(Console.ReadLine()!);
        promedio = (nota1 + nota2) / 2;

        if (nota1 >= 0 && nota1 <= 20 && nota2 >= 0 && nota2 <= 20)
        {
            Console.WriteLine();
            Console.WriteLine("Promedio: " + promedio);
            if (promedio >= 10.5 && promedio <= 20)
                Console.WriteLine("Aprobado");
            else
                Console.WriteLine("Desaprobado");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("ERROR... Las notas ingresadas no se encuentran en la escala vigesimal (0-20)");
        }
    }

    
    // CATEGORÍA 7: VARIOS
    

    // Ejercicio 18 - Primera vocal ingresada desde el teclado
    public static void Ejercicio18()
    {
        Console.WriteLine("── Ejercicio 18: Primera vocal ingresada ──");
        string caracter;
        int x = 1;

        do
        {
            Console.WriteLine("Ingrese carácter");
            caracter = Console.ReadLine()!;

            if (caracter.Equals("a") || caracter.Equals("e") ||
                caracter.Equals("i") || caracter.Equals("o") ||
                caracter.Equals("u"))
                x = 0;
        }
        while (x == 1);

        Console.WriteLine();
        Console.WriteLine("La primera vocal ingresada fue: " + caracter);
    }

    // Ejercicio 19 - Determinar si un número tiene parte fraccionaria
    public static void Ejercicio19()
    {
        Console.WriteLine("── Ejercicio 19: ¿Tiene parte fraccionaria? ──");
        double numero, pf;

        Console.WriteLine("Ingrese un número");
        numero = double.Parse(Console.ReadLine()!);
        pf     = Math.Truncate(numero);

        if (numero == pf)
            Console.WriteLine("No tiene parte fraccionaria");
        else
            Console.WriteLine("Tiene parte fraccionaria");
    }

    // Ejercicio 21 - Operaciones básicas durante 10 procesos con contador
    public static void Ejercicio21()
    {
        Console.WriteLine("── Ejercicio 21: Operaciones básicas (10 procesos) ──");
        double num1, num2, c, suma, resta, multiplicacion, division;
        c = 0;

        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO N°{0}:", c);
            Console.Write("Ingrese primer número: ");
            num1 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese segundo número: ");
            num2 = double.Parse(Console.ReadLine()!);

            suma           = num1 + num2;
            resta          = num1 - num2;
            multiplicacion = num1 * num2;
            division       = Math.Round(num1 / num2, 2);

            Console.WriteLine();
            Console.WriteLine("La suma es: "           + suma);
            Console.WriteLine("La resta es : "         + resta);
            Console.WriteLine("La multiplicación es: " + multiplicacion);
            Console.WriteLine("La división es: "       + division);
            Console.WriteLine(" ");
        }
        while (c <= 9);

        Console.WriteLine("Final del proceso");
    }

    // Ejercicio 22 - Cubo y raíz cuadrada, termina cuando se ingresa 0
    public static void Ejercicio22()
    {
        Console.WriteLine("── Ejercicio 22: Cubo y raíz cuadrada (0 para salir) ──");
        double numero, c, cubo, raizCuadrada;
        c = 0;

        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO N°{0}:", c);
            Console.Write("Ingrese un número: ");
            numero = double.Parse(Console.ReadLine()!);

            if (numero != 0)
            {
                cubo         = Math.Pow(numero, 3);
                raizCuadrada = Math.Round(Math.Pow(numero, 0.5), 2);
                Console.WriteLine("El cubo es: "          + cubo);
                Console.WriteLine("La raíz cuadrada es: " + raizCuadrada);
                Console.WriteLine();
            }
        }
        while (numero != 0);

        Console.WriteLine();
        Console.WriteLine("FINAL DEL PROCESO");
    }

    // Ejercicio 23 - Operaciones básicas, termina cuando primer número es 0
    public static void Ejercicio23()
    {
        Console.WriteLine("── Ejercicio 23: Operaciones básicas (0 para salir) ──");
        double num1, num2, c, suma, resta, multiplicacion, division;
        c = 0;

        do
        {
            c = c + 1;
            Console.WriteLine("PROCESO N°{0}:", c);
            Console.Write("Ingrese primer número: ");
            num1 = double.Parse(Console.ReadLine()!);

            if (num1 != 0)
            {
                Console.Write("Ingrese segundo número: ");
                num2 = double.Parse(Console.ReadLine()!);

                suma           = num1 + num2;
                resta          = num1 - num2;
                multiplicacion = num1 * num2;
                division       = Math.Round(num1 / num2, 2);

                Console.WriteLine();
                Console.WriteLine("La suma es: "           + suma);
                Console.WriteLine("La resta es : "         + resta);
                Console.WriteLine("La multiplicación es: " + multiplicacion);
                Console.WriteLine("La división es: "       + division);
                Console.WriteLine(" ");
            }
        }
        while (num1 != 0);

        Console.WriteLine(" ");
        Console.WriteLine("FINAL DEL PROCESO");
    }

    // Ejercicio 29 - Egresos de caja Barner ($3.71 inicial, termina con -1)
    public static void Ejercicio29()
    {
        Console.WriteLine("── Ejercicio 29: Egresos de caja Barner ──");
        double caja, egreso, cont, totalEgresos, restoCaja;
        totalEgresos = 0;
        caja         = 371;   // $3.71 representado en centavos para evitar decimales
        cont         = 0;

        // Nota: el original usaba 371 como entero; aquí se respeta la lógica
        do
        {
            cont = cont + 1;
            Console.Write("Ingrese {0} egreso: ", cont);
            egreso       = double.Parse(Console.ReadLine()!);
            totalEgresos = totalEgresos + egreso;
            restoCaja    = caja - totalEgresos;
        }
        while (egreso != -1);

        Console.WriteLine();
        Console.WriteLine("El total de egresos es: {0}",  totalEgresos + 1);
        Console.WriteLine("Lo sobrante en caja es: {0}", restoCaja    - 1);
    }

    // Ejercicio 31 - Verificación de clave de acceso (5 palabras)
    public static void Ejercicio31()
    {
        Console.WriteLine("── Ejercicio 31: Verificación de clave de acceso ──");
        string[] claves = { "tienes", "que ser", "invitado", "para", "ingresar" };
        string[] ingresadas = new string[5];
        bool acceso = true;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese {0}° clave:  ", i + 1);
            ingresadas[i] = Console.ReadLine()!;
            if (ingresadas[i] != claves[i]) acceso = false;
        }

        Console.WriteLine();
        if (acceso)
            Console.WriteLine("BIENVENIDO A LA FIESTA");
        else
            Console.WriteLine("ACCESO DENEGADO");
    }
}