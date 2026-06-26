using System;

class Banco
{
    public string Nombre { get; set; }

    public Banco(string nombre)
    {
        Nombre = nombre;
    }

    public void MostrarBanco()
    {
        Console.WriteLine($"Banco: {Nombre}");
    }
}