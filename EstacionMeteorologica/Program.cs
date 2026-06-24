using System;

class Program
{
    static void Main()
    {
        double[] temperaturas = new double[7];

        // Captura de datos
        for (int i = 0; i < 7; i++)
        {
            double temp;

            do
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                temp = Convert.ToDouble(Console.ReadLine());

                if (temp < -50 || temp > 50)
                {
                    Console.WriteLine("Temperatura inválida. Debe estar entre -50 y 50°C.");
                }

            } while (temp < -50 || temp > 50);

            temperaturas[i] = temp;
        }

        double min = ObtenerMinimo(temperaturas);
        double max = ObtenerMaximo(temperaturas);
        double promedio = CalcularPromedio(temperaturas);

        Console.WriteLine($"\nRESULTADOS:");
        Console.WriteLine($"Temperatura mínima: {min}°C");
        Console.WriteLine($"Temperatura máxima: {max}°C");
        Console.WriteLine($"Promedio: {promedio:F2}°C");

        if (promedio < 4)
        {
            Console.Write("\nIngrese la velocidad del viento (bajo / alto): ");
            string viento = (Console.ReadLine() ?? string.Empty).ToLower();

            switch (viento)
            {
                case "bajo":
                    Console.WriteLine("ALERTA AMARILLA: Riesgo de helada moderada.");
                    break;

                case "alto":
                    Console.WriteLine("ALERTA ROJA: Helada inminente.");
                    break;

                default:
                    Console.WriteLine("Valor de viento no reconocido.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("No hay riesgo de helada.");
        }
    }

    static double ObtenerMinimo(double[] datos)
    {
        double min = datos[0];

        for (int i = 1; i < datos.Length; i++)
        {
            if (datos[i] < min)
            {
                min = datos[i];
            }
        }

        return min;
    }

    static double ObtenerMaximo(double[] datos)
    {
        double max = datos[0];

        for (int i = 1; i < datos.Length; i++)
        {
            if (datos[i] > max)
            {
                max = datos[i];
            }
        }

        return max;
    }

    static double CalcularPromedio(double[] datos)
    {
        double suma = 0;

        for (int i = 0; i < datos.Length; i++)
        {
            suma += datos[i];
        }

        return suma / datos.Length;
    }
}
