using System;

class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco("Banco Nacional");

        Cliente cliente = new Cliente(
            "Alvin Manuel González",
            "001-1234567-8"
        );

        Cuenta cuenta1 = new CuentaAhorro(
            "0001",
            15000,
            cliente
        );

        Cuenta cuenta2 = new CuentaCorriente(
            "0002",
            30000,
            cliente
        );

        banco.MostrarBanco();

        Console.WriteLine();

        cliente.MostrarInformacion();

        Console.WriteLine();

        cuenta1.MostrarTipoCuenta();
        cuenta1.MostrarSaldo();

        Console.WriteLine();

        cuenta2.MostrarTipoCuenta();
        cuenta2.MostrarSaldo();
    }
}