/* Maestro, aquí aplico el encapsulamiento
lo cual, a mi entender, no es más que el ocultamiento de los datos
internos de una clase para que no puedan ser modificados
directamente desde otras partes del programa */





class Cliente
{
    // Atributos privados
    private string nombre;
    private string cedula;

    public Cliente(string nombre, string cedula)
    {
        this.nombre = nombre;
        this.cedula = cedula;
    }
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public string Cedula
    {
        get { return cedula; }
        set { cedula = value; }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Cliente");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Cédula: {Cedula}");
    }
}

