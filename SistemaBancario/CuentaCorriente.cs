using System;

class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string numeroCuenta, double saldo, Cliente titular)
        : base(numeroCuenta, saldo, titular)
    {
    }

    public override void MostrarTipoCuenta()
    {
        Console.WriteLine("Tipo de cuenta: Cuenta Corriente");
    }
}