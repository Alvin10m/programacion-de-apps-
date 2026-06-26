/* La herencia me permite crear una nueva 
clase a partir de una clase 
existente, reutilizando sus características y agregando 
o modificando comportamientos propios. */




using System;

class CuentaAhorro : Cuenta
{
    // Constructor
    public CuentaAhorro(string numeroCuenta, double saldo, Cliente titular)
        : base(numeroCuenta, saldo, titular)
    {
    }

    // Implementación del método abstracto
    public override void MostrarTipoCuenta()
    {
        Console.WriteLine("Tipo de cuenta: Cuenta de Ahorro");
    }
}